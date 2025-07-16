namespace Capa_Presentacion
{
    partial class FormGestionProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionProductos));
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreProducto = new TextBox();
            txtCodigo = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnRegistrar = new Button();
            label7 = new Label();
            label8 = new Label();
            cmbEditar = new ComboBox();
            txtNombreEditar = new TextBox();
            txtCantidadEditar = new TextBox();
            txtPrecioEditar = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnGuardarCambios = new Button();
            label14 = new Label();
            label15 = new Label();
            cmbEliminar = new ComboBox();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            cmbCategorias = new ComboBox();
            cmbCategorias2 = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Red;
            btnVolver.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ControlLight;
            btnVolver.Location = new Point(892, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 30);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += BtnVolver_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 11);
            label1.Name = "label1";
            label1.Size = new Size(150, 17);
            label1.TabIndex = 1;
            label1.Text = "Registrar Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 197);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "Código: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 64);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 3;
            label3.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 104);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 2;
            label4.Text = "Categoría: ";   
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 253);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 2;
            label5.Text = "Cantidad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 149);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 2;
            label6.Text = "Precio: ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(144, 59);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 25);
            txtNombreProducto.TabIndex = 4;
            txtNombreProducto.TextChanged += TxtNombreProducto_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(144, 194);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 25);
            txtCodigo.TabIndex = 5;
            txtCodigo.TextChanged += txtCodigo_TextChanged_1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(144, 250);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 25);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(144, 141);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 25);
            txtPrecio.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(315, 141);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 49);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 25);
            label7.Name = "label7";
            label7.Size = new Size(131, 17);
            label7.TabIndex = 10;
            label7.Text = "Editar Producto: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 61);
            label8.Name = "label8";
            label8.Size = new Size(166, 17);
            label8.TabIndex = 11;
            label8.Text = "Seleccionar Producto:";
            // 
            // cmbEditar
            // 
            cmbEditar.FormattingEnabled = true;
            cmbEditar.Location = new Point(41, 90);
            cmbEditar.Name = "cmbEditar";
            cmbEditar.Size = new Size(121, 25);
            cmbEditar.TabIndex = 12;
            cmbEditar.SelectedIndexChanged += CmbEditar_SelectedIndexChanged;
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.Location = new Point(349, 37);
            txtNombreEditar.Name = "txtNombreEditar";
            txtNombreEditar.Size = new Size(100, 25);
            txtNombreEditar.TabIndex = 13;
            // 
            // txtCantidadEditar
            // 
            txtCantidadEditar.Location = new Point(349, 110);
            txtCantidadEditar.Name = "txtCantidadEditar";
            txtCantidadEditar.Size = new Size(100, 25);
            txtCantidadEditar.TabIndex = 15;
            // 
            // txtPrecioEditar
            // 
            txtPrecioEditar.Location = new Point(349, 141);
            txtPrecioEditar.Name = "txtPrecioEditar";
            txtPrecioEditar.Size = new Size(100, 25);
            txtPrecioEditar.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(250, 40);
            label10.Name = "label10";
            label10.Size = new Size(69, 17);
            label10.TabIndex = 18;
            label10.Text = "Nombre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(250, 76);
            label11.Name = "label11";
            label11.Size = new Size(86, 17);
            label11.TabIndex = 19;
            label11.Text = "Categoria: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(250, 113);
            label12.Name = "label12";
            label12.Size = new Size(80, 17);
            label12.TabIndex = 20;
            label12.Text = "Cantidad: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(250, 146);
            label13.Name = "label13";
            label13.Size = new Size(64, 17);
            label13.TabIndex = 21;
            label13.Text = "Precio: ";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(175, 247);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(146, 30);
            btnGuardarCambios.TabIndex = 22;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += BtnGuardarCambios_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(29, 37);
            label14.Name = "label14";
            label14.Size = new Size(147, 17);
            label14.TabIndex = 23;
            label14.Text = "Eliminar Producto: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(54, 98);
            label15.Name = "label15";
            label15.Size = new Size(166, 17);
            label15.TabIndex = 24;
            label15.Text = "Seleccionar Producto:";
            // 
            // cmbEliminar
            // 
            cmbEliminar.FormattingEnabled = true;
            cmbEliminar.Location = new Point(75, 119);
            cmbEliminar.Name = "cmbEliminar";
            cmbEliminar.Size = new Size(121, 23);
            cmbEliminar.TabIndex = 25;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(304, 98);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 44);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(551, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 404);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1051, 73);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gray;
            label9.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(13, 23);
            label9.Name = "label9";
            label9.Size = new Size(196, 27);
            label9.TabIndex = 29;
            label9.Text = "Gestion Producto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(227, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1051, 73);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(485, 297);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(491, 296);
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(24, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(470, 269);
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(144, 101);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 25);
            cmbCategorias.TabIndex = 31; 
            // 
            // cmbCategorias2
            // 
            cmbCategorias2.FormattingEnabled = true;
            cmbCategorias2.Location = new Point(349, 73);
            cmbCategorias2.Name = "cmbCategorias2";
            cmbCategorias2.Size = new Size(121, 25);
            cmbCategorias2.TabIndex = 32;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(9, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(536, 365);
            tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistrar);
            tabPage1.Controls.Add(cmbCategorias);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtNombreProducto);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Controls.Add(txtCantidad);
            tabPage1.Controls.Add(txtPrecio);
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(528, 335);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtCantidadEditar);
            tabPage2.Controls.Add(cmbCategorias2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(cmbEditar);
            tabPage2.Controls.Add(txtNombreEditar);
            tabPage2.Controls.Add(txtPrecioEditar);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(btnGuardarCambios);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(528, 335);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox6);
            tabPage3.Controls.Add(btnEliminar);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(cmbEliminar);
            tabPage3.Controls.Add(pictureBox4);
            tabPage3.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(528, 335);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(313, 148);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(133, 117);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // FormGestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 513);
            Controls.Add(tabControl1);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FormGestionProductos";
            Text = "Gestion Productos";
            Load += FormGestionProductos_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreProducto;
        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnRegistrar;
        private Label label7;
        private Label label8;
        private ComboBox cmbEditar;
        private TextBox txtNombreEditar;
        private TextBox txtCantidadEditar;
        private TextBox txtPrecioEditar;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnGuardarCambios;
        private Label label14;
        private Label label15;
        private ComboBox cmbEliminar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ComboBox cmbCategorias;
        private ComboBox cmbCategorias2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox pictureBox6;
    }
}