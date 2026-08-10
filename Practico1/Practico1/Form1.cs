namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            TBResultado.Text = TBApellido.Text + ", " + TBNombre.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            TBResultado.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // sentencia "End" solo aplica a VB. En C# se utiliza Application.Exit() para cerrar la aplicación.
        }
    }
}
