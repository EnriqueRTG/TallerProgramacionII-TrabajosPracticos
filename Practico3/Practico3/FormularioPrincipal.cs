using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practico3
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        // Manejo del evento Load del formulario principal para abrir el formulario hijo al iniciar la aplicación
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            // Crear una instancia del formulario hijo (Form1)
            Form1 formulario = new Form1();

            // Establecer el formulario principal como MDI parent del formulario hijo
            formulario.MdiParent = this;

            // Mostrar el formulario hijo
            formulario.Show();
        }

        // Manejo del evento Click del menú "Nuevo Cliente" para abrir un nuevo formulario hijo
        private void NuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario hijo (Form1)
            Form1 formulario = new Form1();

            // Establecer el formulario principal como MDI parent del formulario hijo
            formulario.MdiParent = this;

            // Mostrar el formulario hijo
            formulario.Show();
        }

        // Manejo del evento Click del menú "Salir" para cerrar la aplicación
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Mi version de Visual Sudio/.NET no tiene la plantilla "Formulario Primario MDI"
        // Solucion: Sobre el proyecto agregar otro formulario "Add → Form (Windows Forms)"
        // Seleccioná el formulario y en Properties cambiar "IsMdiContainer = True"
        // A partir de ese momento ese Form normal es un MDI Parent
        // Asignar desde el form principal: -Form1 formulario = new Form1(); -formulario.MdiParent = this; -formulario.Show();
    }
}
