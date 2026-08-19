using System.Drawing.Design;
using System.IO;

namespace Practico4
{
    public partial class FormDataGrid : Form
    {
        public FormDataGrid()
        {
            InitializeComponent();
        }

        // Metodo para cargar la foto en el PictureBox
        private void BFoto_Click(object sender, EventArgs e)
        {
            // Configurar el OpenFileDialog para seleccionar una imagen
            OFDFoto.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            // Mostrar el OpenFileDialog y verificar si se seleccionó un archivo
            if (OFDFoto.ShowDialog() == DialogResult.OK)
            {

                // Obtener la ruta del archivo seleccionado
                string rutaOrigen = OFDFoto.FileName;

                // Crear la ruta de la carpeta "Fotos" dentro del directorio de inicio de la aplicación
                string carpetaFotos = Path.Combine(Application.StartupPath, "Fotos");

                // Crear la carpeta "Fotos" si no existe
                Directory.CreateDirectory(carpetaFotos);

                // Obtener el nombre del archivo seleccionado
                string nombreArchivo = Path.GetFileName(rutaOrigen);

                // Crear la ruta de destino para copiar el archivo a la carpeta "Fotos"
                string rutaDestino = Path.Combine(carpetaFotos, nombreArchivo);

                // Copiar el archivo seleccionado a la carpeta "Fotos", sobrescribiendo si ya existe
                File.Copy(rutaOrigen, rutaDestino, true);

                // Asignar la ruta del archivo seleccionado al TextBox
                TFoto.Text = rutaDestino;

                // Cargar la imagen en el PictureBox
                PBFoto.BackgroundImage = Image.FromFile(rutaDestino);
            }
        }

        // Evento Leave para los TextBox de nombre y apellido
        private void Texto_Leave(object sender, EventArgs e)
        {
            // Verificar si el control que disparó el evento es un TextBox y si tiene texto
            if (sender is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
            {
                // Dividir el texto en palabras, eliminando espacios vacíos
                string[] palabras = textBox.Text.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Recorrer cada palabra
                for (int i = 0; i < palabras.Length; i++)
                {
                    // Capitalizar la primera letra y convertir el resto a minúsculas
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
                }

                // Unir las palabras nuevamente y asignarlas al TextBox
                textBox.Text = string.Join(" ", palabras);
            }
        }

        // Método para obtener el sexo seleccionado en los RadioButtons
        private string ObtenerSexoSeleccionado()
        {
            // Verificar cuál RadioButton está seleccionado y devolver el texto correspondiente
            if (RBHombre.Checked)
                return RBHombre.Text;
            else if (RBMujer.Checked)
                return RBMujer.Text;
            else
                return string.Empty; // Retornar cadena vacía si ninguno está seleccionado
        }

        // Método para obtener la fecha de nacimiento en formato corto
        private string ObtenerFechaNacimiento(DateTime fechaNacimiento)
        {
            // Retornar la fecha de nacimiento en formato corto (dd/MM/yyyy)
            return fechaNacimiento.ToShortDateString();
        }

        // Evento Click del botón Agregar
        private void BAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos de apellido y nombre no estén vacíos
            if (!ValidarFormulario())
                return;

            // Validar que el saldo ingresado sea un número decimal válido
            if (!decimal.TryParse(TSaldo.Text, out decimal saldo))
            {
                MensajeError(
                    "Por favor, ingrese un saldo válido.",
                    "Error");
                return;
            }

            // Agregar una nueva fila al DataGridView con los datos del cliente
            // Se obtiene el índice de la nueva fila agregada para poder modificar su estilo si es necesario
            int indiceFila = DGVCliente.Rows.Add(TApellido.Text, TNombre.Text, ObtenerFechaNacimiento(DTPFechaNacimiento.Value), ObtenerSexoSeleccionado(), "Eliminar",
                saldo, PBFoto.BackgroundImage, TFoto.Text);

            // Crear una referencia a la fila recién agregada
            DataGridViewRow fila = DGVCliente.Rows[indiceFila];

            // Llamar al método AplicarFormatoSaldo
            AplicarFormatoSaldo(fila, saldo);

            // Limpiar la selección del DataGridView para que no quede ninguna fila seleccionada
            DGVCliente.ClearSelection();

            // Llamar al método LimpiarFormulario
            LimpiarFormulario();
        }

        // Método para validar que los campos de apellido y nombre no estén vacíos
        private bool ValidarFormulario()
        {
            // Verificar si los campos de apellido y nombre están vacíos o contienen solo espacios en blanco
            if (string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MensajeError(
                    "Debe completar el nombre y apellido.",
                    "Datos incompletos");

                return false;
            }

            // Verificar si se ha seleccionado un sexo en los RadioButtons
            if (string.IsNullOrEmpty(ObtenerSexoSeleccionado()))
            {
                MensajeError(
                    "Debe seleccionar el sexo.",
                    "Datos incompletos");

                return false;
            }

            return true;
        }

        // Método para aplicar formato a la fila del DataGridView según el saldo
        private void AplicarFormatoSaldo(DataGridViewRow fila, decimal saldo)
        {
            // Si el saldo es menor a 50
            if (saldo < 50)
            {
                // Cambiar el color de fondo de la fila a rojo
                fila.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        // Evento CellContentClick del DataGridView para manejar la eliminación de filas
        private void DGVCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el índice de la columna es válido
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Verificar si la columna clickeada es la columna de eliminar
            if (DGVCliente.Columns[e.ColumnIndex].Name == "CEliminar")
            {
                // Se almacena la respuesta del usuario a la confirmación de eliminación
                // Se llama al método MensajeConfirmacion para mostrar un cuadro de diálogo de confirmación
                DialogResult respuesta = MensajeConfirmacion("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación");

                // Si el usuario confirma la eliminación, eliminar la fila correspondiente
                if (respuesta == DialogResult.Yes)
                {
                    // Eliminar la fila del DataGridView
                    DGVCliente.Rows.RemoveAt(e.RowIndex);

                    // Limpiar el formulario después de eliminar la fila
                    LimpiarFormulario();
                }
            }
        }

        // Método para mostrar un cuadro de diálogo de confirmación
        private DialogResult MensajeConfirmacion(string mensaje, string titulo)
        {
            // Mostrar un cuadro de diálogo de confirmación con el mensaje y título proporcionados
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        // Método para mostrar un cuadro de diálogo de error
        private void MensajeError(string mensaje, string titulo)
        {
            // Mostrar un cuadro de diálogo de error con el mensaje y título proporcionados
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Evento CellClick del DataGridView para cargar los datos de la fila seleccionada en el formulario
        private void DGVCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el índice de la fila es válido
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Verificar si la columna clickeada es la columna de eliminar, en cuyo caso no se cargan los datos en el formulario
            if (DGVCliente.Columns[e.ColumnIndex].Name == "CEliminar")
                return;

            // Llamar al método CargarFilaEnFormulario para cargar los datos de la fila seleccionada en el formulario
            CargarFilaEnFormulario(e.RowIndex);
        }

        // Método para cargar los datos de una fila del DataGridView en el formulario
        private void CargarFilaEnFormulario(int indiceFila)
        {
            // Obtener la fila correspondiente al índice proporcionado
            DataGridViewRow fila = DGVCliente.Rows[indiceFila];

            // Cargar los datos de la fila en los controles del formulario
            TApellido.Text = fila.Cells["CApellido"].Value?.ToString() ?? "";
            TNombre.Text = fila.Cells["CNombre"].Value?.ToString() ?? "";
            string fechaTexto = fila.Cells["CFechaNacimiento"].Value?.ToString() ?? "";
            if (DateTime.TryParse(fechaTexto, out DateTime fecha)) // Intentar convertir el texto de la fecha a un objeto DateTime
            {
                DTPFechaNacimiento.Value = fecha;
            }
            string sexo = fila.Cells["CSexo"].Value?.ToString() ?? "";
            RBHombre.Checked = sexo == RBHombre.Text;
            RBMujer.Checked = sexo == RBMujer.Text;
            TSaldo.Text = fila.Cells["CSaldo"].Value?.ToString() ?? "";
            object? imagen = fila.Cells["CFoto"].Value;
            if (imagen is Image foto) // Verificar si la celda contiene una imagen y asignarla al PictureBox
            {
                PBFoto.BackgroundImage = foto;
            }
            else
            {
                PBFoto.BackgroundImage = null;
            }
            TFoto.Text = fila.Cells["CRuta"].Value?.ToString() ?? "";
        }

        //  Método para limpiar el formulario después de agregar un cliente
        private void LimpiarFormulario()
        {
            // Limpiar los campos del formulario
            TApellido.Clear();
            TNombre.Clear();
            DTPFechaNacimiento.Value = DateTime.Now;
            RBHombre.Checked = false;
            RBMujer.Checked = false;
            TSaldo.Clear();
            PBFoto.BackgroundImage = Properties.Resources.avatar2;
            TFoto.Clear();
        }

        // Evento KeyPress para permitir solo letras, espacios y teclas de control en los TextBox de nombre y apellido
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento KeyPress para permitir solo números, el punto decimal y teclas de control en el TextBox de saldo
        private void SoloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Permitir números y teclas de control
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Permitir una sola coma como separador decimal
                if (e.KeyChar == ',' && !textBox.Text.Contains(','))
                {
                    return;
                }

                // Bloquear cualquier otro carácter
                e.Handled = true;
            }
        }
    }
}
