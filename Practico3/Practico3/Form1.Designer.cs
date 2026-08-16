namespace Practico3
{
    partial class Form1
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
            LNyA = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            panel1 = new Panel();
            CBMastercard = new CheckBox();
            CBVisa = new CheckBox();
            CBNaranja = new CheckBox();
            LTarjetasDeCredito = new Label();
            TTelofono = new TextBox();
            LTelefono = new Label();
            LTituloNuevoCliente = new Label();
            PBSexo = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            BSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBSexo).BeginInit();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(30, 23);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(31, 74);
            LDni.Name = "LDni";
            LDni.Size = new Size(32, 15);
            LDni.TabIndex = 1;
            LDni.Text = "*DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(30, 118);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(56, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "*Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(30, 163);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(56, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "*Nombre";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(187, 23);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(187, 66);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(187, 110);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(187, 155);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.Image = Properties.Resources.guardar;
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(51, 510);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(90, 40);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Image = Properties.Resources.eliminar;
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(231, 510);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(90, 40);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(CBMastercard);
            panel1.Controls.Add(CBVisa);
            panel1.Controls.Add(CBNaranja);
            panel1.Controls.Add(LTarjetasDeCredito);
            panel1.Controls.Add(TTelofono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNyA);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(LModificar);
            panel1.Location = new Point(22, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 364);
            panel1.TabIndex = 10;
            // 
            // CBMastercard
            // 
            CBMastercard.AutoSize = true;
            CBMastercard.Location = new Point(187, 313);
            CBMastercard.Name = "CBMastercard";
            CBMastercard.Size = new Size(85, 19);
            CBMastercard.TabIndex = 13;
            CBMastercard.Text = "Mastercard";
            CBMastercard.UseVisualStyleBackColor = true;
            // 
            // CBVisa
            // 
            CBVisa.AutoSize = true;
            CBVisa.Location = new Point(187, 288);
            CBVisa.Name = "CBVisa";
            CBVisa.Size = new Size(47, 19);
            CBVisa.TabIndex = 12;
            CBVisa.Text = "Visa";
            CBVisa.UseVisualStyleBackColor = true;
            // 
            // CBNaranja
            // 
            CBNaranja.AutoSize = true;
            CBNaranja.Location = new Point(187, 263);
            CBNaranja.Name = "CBNaranja";
            CBNaranja.Size = new Size(67, 19);
            CBNaranja.TabIndex = 11;
            CBNaranja.Text = "Naranja";
            CBNaranja.UseVisualStyleBackColor = true;
            // 
            // LTarjetasDeCredito
            // 
            LTarjetasDeCredito.AutoSize = true;
            LTarjetasDeCredito.Location = new Point(32, 246);
            LTarjetasDeCredito.Name = "LTarjetasDeCredito";
            LTarjetasDeCredito.Size = new Size(114, 15);
            LTarjetasDeCredito.TabIndex = 10;
            LTarjetasDeCredito.Text = "Tarjetas de creditos: ";
            // 
            // TTelofono
            // 
            TTelofono.Location = new Point(187, 202);
            TTelofono.Name = "TTelofono";
            TTelofono.Size = new Size(100, 23);
            TTelofono.TabIndex = 9;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(30, 205);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(53, 15);
            LTelefono.TabIndex = 8;
            LTelefono.Text = "Telefono";
            // 
            // LTituloNuevoCliente
            // 
            LTituloNuevoCliente.AutoSize = true;
            LTituloNuevoCliente.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloNuevoCliente.ForeColor = Color.OrangeRed;
            LTituloNuevoCliente.Location = new Point(198, 29);
            LTituloNuevoCliente.Name = "LTituloNuevoCliente";
            LTituloNuevoCliente.Size = new Size(230, 45);
            LTituloNuevoCliente.TabIndex = 11;
            LTituloNuevoCliente.Text = "Nuevo Cliente";
            // 
            // PBSexo
            // 
            PBSexo.Image = Properties.Resources.varon;
            PBSexo.Location = new Point(444, 101);
            PBSexo.Name = "PBSexo";
            PBSexo.Size = new Size(105, 133);
            PBSexo.SizeMode = PictureBoxSizeMode.Zoom;
            PBSexo.TabIndex = 12;
            PBSexo.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(411, 264);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 13;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(527, 264);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 14;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.salir;
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(444, 510);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(90, 40);
            BSalir.TabIndex = 15;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 593);
            Controls.Add(BSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(PBSexo);
            Controls.Add(LTituloNuevoCliente);
            Controls.Add(panel1);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBSexo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNyA;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button TGuardar;
        private Button TEliminar;
        private Panel panel1;
        private Label LTituloNuevoCliente;
        private TextBox TTelofono;
        private Label LTelefono;
        private PictureBox PBSexo;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Label LTarjetasDeCredito;
        private CheckBox CBMastercard;
        private CheckBox CBVisa;
        private CheckBox CBNaranja;
        private Button BSalir;
    }
}
