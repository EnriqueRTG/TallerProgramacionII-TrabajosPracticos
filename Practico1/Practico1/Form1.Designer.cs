namespace Practico1
{
    partial class Formulario1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BGuardar = new Button();
            BEliminar = new Button();
            LApellido = new Label();
            LNombre = new Label();
            TBApellido = new TextBox();
            TBNombre = new TextBox();
            TBResultado = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(47, 197);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(178, 197);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 1;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(47, 53);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(47, 120);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(153, 45);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(100, 23);
            TBApellido.TabIndex = 4;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(153, 112);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(100, 23);
            TBNombre.TabIndex = 5;
            // 
            // TBResultado
            // 
            TBResultado.ImeMode = ImeMode.On;
            TBResultado.Location = new Point(288, 45);
            TBResultado.Multiline = true;
            TBResultado.Name = "TBResultado";
            TBResultado.Size = new Size(139, 130);
            TBResultado.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(352, 197);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BSalir);
            Controls.Add(TBResultado);
            Controls.Add(TBNombre);
            Controls.Add(TBApellido);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Formulario1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi Primer Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label LApellido;
        private Label LNombre;
        private TextBox TBApellido;
        private TextBox TBNombre;
        private TextBox TBResultado;
        private Button BSalir;
    }
}
