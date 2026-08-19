namespace Practico4
{
    partial class FormDataGrid
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            TApellido = new TextBox();
            panel1 = new Panel();
            RBMujer = new RadioButton();
            RBHombre = new RadioButton();
            TFoto = new TextBox();
            BFoto = new Button();
            DTPFechaNacimiento = new DateTimePicker();
            BAgregar = new Button();
            TSaldo = new TextBox();
            TNombre = new TextBox();
            LSaldo = new Label();
            LSexo = new Label();
            LFechaNacimiento = new Label();
            LApellido = new Label();
            LNombre = new Label();
            PBFoto = new PictureBox();
            OFDFoto = new OpenFileDialog();
            DGVCliente = new DataGridView();
            CApellido = new DataGridViewTextBoxColumn();
            CNombre = new DataGridViewTextBoxColumn();
            CFechaNacimiento = new DataGridViewTextBoxColumn();
            CSexo = new DataGridViewTextBoxColumn();
            CEliminar = new DataGridViewButtonColumn();
            CSaldo = new DataGridViewTextBoxColumn();
            CFoto = new DataGridViewImageColumn();
            CRuta = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVCliente).BeginInit();
            SuspendLayout();
            // 
            // TApellido
            // 
            TApellido.Location = new Point(235, 88);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(202, 23);
            TApellido.TabIndex = 6;
            TApellido.KeyPress += SoloLetras_KeyPress;
            TApellido.Leave += Texto_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.images;
            panel1.Controls.Add(RBMujer);
            panel1.Controls.Add(RBHombre);
            panel1.Controls.Add(TFoto);
            panel1.Controls.Add(BFoto);
            panel1.Controls.Add(DTPFechaNacimiento);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(TSaldo);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LSaldo);
            panel1.Controls.Add(LSexo);
            panel1.Controls.Add(LFechaNacimiento);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(78, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 350);
            panel1.TabIndex = 0;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBMujer.ForeColor = Color.White;
            RBMujer.Location = new Point(343, 175);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(59, 23);
            RBMujer.TabIndex = 13;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Checked = true;
            RBHombre.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBHombre.ForeColor = Color.White;
            RBHombre.Location = new Point(235, 175);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(74, 23);
            RBHombre.TabIndex = 12;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // TFoto
            // 
            TFoto.Location = new Point(235, 257);
            TFoto.Name = "TFoto";
            TFoto.Size = new Size(202, 23);
            TFoto.TabIndex = 11;
            // 
            // BFoto
            // 
            BFoto.Location = new Point(25, 256);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(75, 23);
            BFoto.TabIndex = 10;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = true;
            BFoto.Click += BFoto_Click;
            // 
            // DTPFechaNacimiento
            // 
            DTPFechaNacimiento.Format = DateTimePickerFormat.Short;
            DTPFechaNacimiento.Location = new Point(235, 128);
            DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            DTPFechaNacimiento.Size = new Size(202, 23);
            DTPFechaNacimiento.TabIndex = 9;
            // 
            // BAgregar
            // 
            BAgregar.Image = Properties.Resources.flopydisck;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(196, 307);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(80, 25);
            BAgregar.TabIndex = 8;
            BAgregar.Text = "Agregar";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // TSaldo
            // 
            TSaldo.Location = new Point(235, 217);
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(202, 23);
            TSaldo.TabIndex = 7;
            TSaldo.KeyPress += SoloDecimal_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(235, 45);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(202, 23);
            TNombre.TabIndex = 5;
            TNombre.KeyPress += SoloLetras_KeyPress;
            TNombre.Leave += Texto_Leave;
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.Font = new Font("Papyrus", 15.75F);
            LSaldo.ForeColor = Color.White;
            LSaldo.Location = new Point(25, 210);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(78, 33);
            LSaldo.TabIndex = 4;
            LSaldo.Text = "Saldo:";
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Font = new Font("Papyrus", 15.75F);
            LSexo.ForeColor = Color.White;
            LSexo.Location = new Point(25, 167);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(70, 33);
            LSexo.TabIndex = 3;
            LSexo.Text = "Sexo:";
            // 
            // LFechaNacimiento
            // 
            LFechaNacimiento.AutoSize = true;
            LFechaNacimiento.Font = new Font("Papyrus", 15.75F);
            LFechaNacimiento.ForeColor = Color.White;
            LFechaNacimiento.Location = new Point(25, 124);
            LFechaNacimiento.Name = "LFechaNacimiento";
            LFechaNacimiento.Size = new Size(184, 33);
            LFechaNacimiento.TabIndex = 2;
            LFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(25, 81);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(98, 33);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(25, 38);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(92, 33);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre:";
            // 
            // PBFoto
            // 
            PBFoto.BackColor = Color.Transparent;
            PBFoto.BackgroundImage = Properties.Resources.avatar2;
            PBFoto.BackgroundImageLayout = ImageLayout.Zoom;
            PBFoto.Enabled = false;
            PBFoto.Location = new Point(614, 40);
            PBFoto.Name = "PBFoto";
            PBFoto.Size = new Size(350, 350);
            PBFoto.SizeMode = PictureBoxSizeMode.Zoom;
            PBFoto.TabIndex = 1;
            PBFoto.TabStop = false;
            // 
            // OFDFoto
            // 
            OFDFoto.FileName = "Avatar";
            // 
            // DGVCliente
            // 
            DGVCliente.AllowUserToAddRows = false;
            DGVCliente.AllowUserToDeleteRows = false;
            DGVCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCliente.BorderStyle = BorderStyle.Fixed3D;
            DGVCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCliente.Columns.AddRange(new DataGridViewColumn[] { CApellido, CNombre, CFechaNacimiento, CSexo, CEliminar, CSaldo, CFoto, CRuta });
            DGVCliente.Location = new Point(40, 454);
            DGVCliente.MultiSelect = false;
            DGVCliente.Name = "DGVCliente";
            DGVCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCliente.Size = new Size(969, 147);
            DGVCliente.TabIndex = 2;
            DGVCliente.CellClick += DGVCliente_CellClick;
            DGVCliente.CellContentClick += DGVCliente_CellContentClick;
            // 
            // CApellido
            // 
            dataGridViewCellStyle1.Font = new Font("Papyrus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CApellido.DefaultCellStyle = dataGridViewCellStyle1;
            CApellido.HeaderText = "Apellido";
            CApellido.Name = "CApellido";
            // 
            // CNombre
            // 
            dataGridViewCellStyle2.Font = new Font("Papyrus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CNombre.DefaultCellStyle = dataGridViewCellStyle2;
            CNombre.HeaderText = "Nombre";
            CNombre.Name = "CNombre";
            // 
            // CFechaNacimiento
            // 
            CFechaNacimiento.HeaderText = "Fecha Nacimiento";
            CFechaNacimiento.Name = "CFechaNacimiento";
            // 
            // CSexo
            // 
            CSexo.HeaderText = "Sexo";
            CSexo.Name = "CSexo";
            // 
            // CEliminar
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(2);
            CEliminar.DefaultCellStyle = dataGridViewCellStyle3;
            CEliminar.HeaderText = "Eliminar";
            CEliminar.Name = "CEliminar";
            CEliminar.Resizable = DataGridViewTriState.True;
            CEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CSaldo
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            CSaldo.DefaultCellStyle = dataGridViewCellStyle4;
            CSaldo.HeaderText = "Saldo";
            CSaldo.Name = "CSaldo";
            // 
            // CFoto
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "ID: 28e - (System.Drawing.Bitmap)";
            CFoto.DefaultCellStyle = dataGridViewCellStyle5;
            CFoto.HeaderText = "Foto";
            CFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            CFoto.Name = "CFoto";
            CFoto.Resizable = DataGridViewTriState.True;
            CFoto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CRuta
            // 
            CRuta.HeaderText = "Ruta";
            CRuta.Name = "CRuta";
            // 
            // FormDataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cuadros_negros_734708;
            ClientSize = new Size(1046, 630);
            Controls.Add(DGVCliente);
            Controls.Add(PBFoto);
            Controls.Add(panel1);
            Name = "FormDataGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario con Grid";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LSaldo;
        private Label LSexo;
        private Label LFechaNacimiento;
        private Label LApellido;
        private Label LNombre;
        private TextBox TSaldo;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button BAgregar;
        private PictureBox PBFoto;
        private DateTimePicker DTPFechaNacimiento;
        private TextBox TFoto;
        private Button BFoto;
        private RadioButton RBMujer;
        private RadioButton RBHombre;
        private OpenFileDialog OFDFoto;
        private DataGridView DGVCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn CApellido;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CFechaNacimiento;
        private DataGridViewTextBoxColumn CSexo;
        private DataGridViewButtonColumn CEliminar;
        private DataGridViewTextBoxColumn CSaldo;
        private DataGridViewImageColumn CFoto;
        private DataGridViewTextBoxColumn CRuta;
    }
}
