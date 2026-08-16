namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Manejo de evento KeyPress para el TextBox DNI
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Llamar al método que valida solo números
            this.SoloNumeros_KeyPress(sender, e);
        }

        // Manejo de evento KeyPress para el TextBox Apellido
        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Llamar al método que valida solo letras
            this.SoloLetras_KeyPress(sender, e);
        }

        // Manejo de evento KeyPress para el TextBox Nombre
        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Llamar al método que valida solo letras
            this.SoloLetras_KeyPress(sender, e);
        }

        // Método que valida solo números y teclas de control
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como retroceso)
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Marcar el evento como manejado para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        // Método que valida solo letras, espacios y teclas de control
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el carácter ingresado no es una letra, un espacio o una tecla de control, se marca como manejado (no se permite)
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Marcar el evento como manejado para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        // Manejo de evento Click para el botón Guardar
        private void TGuardar_Click(object sender, EventArgs e)
        {
            // Validar si los campos están completos antes de actualizar el Label LModificar
            if (ValidarCampos())
            {
                // Metodo para mostrar un mensaje de error
                this.MostrarMensajeError("Debe completar todos los campos", "Error");
                return;
            }
            else
            {
                // Variable para almacenar la respuesta del usuario al mensaje de confirmación
                DialogResult ask; // El equivalente a MsgBoxResult en VB

                // Se llama al método para mostrar un mensaje de confirmación
                // Luego se almacena la respuesta del usuario en la variable ask
                ask = this.MostrarMensajeConfirmacion("Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción");

                // Si el usuario responde "Sí", se llama al método para actualizar el contenido del Label LModificar
                if (this.EsRespuestaSi(ask))
                {
                    // Se llama al método para actualizar el contenido del Label LModificar
                    this.ActualizarLModificar(sender, e);

                    // Se llama al método para mostrar un mensaje de éxito indicando que el cliente se ha guardado correctamente
                    this.MostrarMensajeInformacion("El Cliente: " + LModificar.Text + " se insertó correctamente", "Guardar");
                }
            }
        }

        // Método para mostrar un mensaje de error con el texto y la leyenda proporcionados
        private void MostrarMensajeError(string mensaje, string leyenda)
        {
            // Mostrar un mensaje de error
            MessageBox.Show(mensaje, leyenda, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Método para mostrar un mensaje de confirmación con el texto proporcionado y la leyenda
        // Devuelve la respuesta del usuario
        private DialogResult MostrarMensajeConfirmacion(string mensaje, string leyenda)
        {
            // Mostrar un mensaje de confirmación
            return MessageBox.Show(mensaje, leyenda, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        // Método para mostrar un mensaje de información con el texto proporcionado y la leyenda
        private void MostrarMensajeInformacion(string mensaje, string leyenda)
        {
            // Mostrar un mensaje de confirmación
            MessageBox.Show(mensaje, leyenda, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para verificar si la respuesta del usuario es "Sí"
        private bool EsRespuestaSi(DialogResult respuesta)
        {
            // Devuelve true si la respuesta del usuario es "Sí", de lo contrario devuelve false
            return respuesta == DialogResult.Yes;
        }

        // Método para actualizar el contenido del Label LModificar
        private void ActualizarLModificar(object sender, EventArgs e)
        {
            // Se actualiza el contenido con el nombre y apellido ingresados en los TextBox TNombre y TApellido
            LModificar.Text = TNombre.Text + " " + TApellido.Text;
        }

        // Método para validar si los campos están completos
        // Devuelve true si algún campo está vacío, de lo contrario devuelve false
        private bool ValidarCampos()
        {
            // Verifica los campos TDni, TApellido y TNombre para asegurarse de que no estén vacíos o contengan solo espacios en blanco
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TNombre.Text))
            {
                // Si algún campo está vacío, se retorna true indicando que hay campos incompletos
                return true;
            }
            // Si todos los campos están completos, se retorna false
            return false;
        }

        // Manejo de evento Click para el botón Eliminar
        private void TEliminar_Click(object sender, EventArgs e)
        {

            // Variable para almacenar la respuesta del usuario al mensaje de confirmación
            DialogResult ask; // El equivalente a MsgBoxResult en VB

            // Se llama al método para mostrar un mensaje de confirmación antes de eliminar el cliente
            // Luego se almacena la respuesta del usuario en la variable ask
            ask = this.MostrarMensajeAdvertencia("Está a punto de eliminar el Cliente: " + LModificar.Text, "Confirmar Eliminación");

            // Si el usuario responde "Sí", se procede a eliminar el cliente y limpiar los campos
            if (EsRespuestaSi(ask))
            {
                // Mostrar un mensaje de éxito indicando que el cliente se ha eliminado correctamente
                this.MostrarMensajeInformacion("El Cliente: " + LModificar.Text + " se eliminó correctamente", "Eliminar");

                // Se llama al método para limpiar los campos de texto
                this.LimpiarCampos();

                // Se llama al método para limpiar el contenido del Label LModificar
                this.LimpiarLModificar();
            }
        }

        // Método para limpiar el contenido del Label LModificar
        private void LimpiarLModificar()
        {
            LModificar.Text = string.Empty; // Limpiar el contenido del Label LModificar
        }

        // Método para mostrar un mensaje de advertencia con el texto proporcionado y la leyenda
        // Devuelve la respuesta del usuario
        private DialogResult MostrarMensajeAdvertencia(string mensaje, string leyenda)
        {
            // Mostrar un mensaje de advertencia
            return MessageBox.Show(mensaje, leyenda, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            TDni.Clear();// Limpiar el TextBox TDni
            TApellido.Clear();// Limpiar el TextBox TApellido
            TNombre.Clear();// Limpiar el TextBox TNombre
        }

        // Manejo de evento Click para el botón Salir
        private void BSalir_Click(object sender, EventArgs e)
        {
            // Metodo para cerrar la aplicación
            this.Close();
        }

        // Manejo de evento CheckedChanged para el RadioButton RBVaron
        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            // Si el RadioButton RBVaron está seleccionado, se cambia la imagen del PictureBox
            if (RBVaron.Checked)
            {
                // Cambia la imagen del PictureBox PBSexo a la imagen de varón
                PBSexo.Image = Properties.Resources.varon;
            }

        }

        // Manejo de evento CheckedChanged para el RadioButton RBMujer
        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            // Si el RadioButton RBMujer está seleccionado, se cambia la imagen del PictureBox
            if (!RBVaron.Checked)
            {
                // Cambia la imagen del PictureBox PBSexo a la imagen de mujer
                PBSexo.Image = Properties.Resources.mujer;
            }
        }
    }
}
