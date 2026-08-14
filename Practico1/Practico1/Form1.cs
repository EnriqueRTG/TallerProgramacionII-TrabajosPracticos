namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        // Manejador del evento Click del botón "Guardar"
        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Se concatenan los valores de los TextBox TBApellido y TBNombre y se asignan al TextBox TBResultado
            TBResultado.Text = TBApellido.Text + ", " + TBNombre.Text;
        }

        // Manejador del evento Click del botón "Eliminar"
        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Se limpian el contenido del TextBox TBResultado
            TBResultado.Clear();
        }

        // Manejador del evento Click del botón "Salir"
        private void BSalir_Click(object sender, EventArgs e)
        {
            // Finaliza la aplicación Windows Forms.
            Application.Exit(); // sentencia "End" solo aplica a VB. En C# se utiliza Application.Exit() para cerrar la aplicación.
        }

        // Manejador del evento KeyDown del formulario.
        // KeyPreview está configurado en True para permitir que el formulario
        // detecte combinaciones de teclas aun cuando otro control tenga el foco.
        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Simula el clic sobre BSalir para reutilizar el comportamiento
                // definido en su evento Click.
                BSalir.PerformClick();

                // Evita que la combinación continúe propagándose a otros controles.
                e.SuppressKeyPress = true;
            }
        }
    }
}
