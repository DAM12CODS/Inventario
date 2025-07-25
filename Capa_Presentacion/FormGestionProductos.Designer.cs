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
            label15 = new Label();
            cmbEliminar = new ComboBox();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            cmbCategorias = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            cmbCategorias2 = new ComboBox();
            txtCantidadEditar = new TextBox();
            label11 = new Label();
            txtPrecioEditar = new TextBox();
            label10 = new Label();
            btnGuardarCambios = new Button();
            label13 = new Label();
            label8 = new Label();
            label12 = new Label();
            txtNombreEditar = new TextBox();
            cmbEditar = new ComboBox();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F);
            label2.Location = new Point(25, 166);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 2;
            label2.Text = "Código: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F);
            label3.Location = new Point(27, 50);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 3;
            label3.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F);
            label4.Location = new Point(25, 85);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 2;
            label4.Text = "Categoría: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F);
            label5.Location = new Point(25, 205);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 2;
            label5.Text = "Cantidad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F);
            label6.Location = new Point(25, 126);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 2;
            label6.Text = "Precio: ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Rockwell", 12F);
            txtNombreProducto.Location = new Point(141, 45);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 26);
            txtNombreProducto.TabIndex = 4;
            txtNombreProducto.TextChanged += TxtNombreProducto_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Rockwell", 12F);
            txtCodigo.Location = new Point(139, 163);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 26);
            txtCodigo.TabIndex = 5;
            txtCodigo.TextChanged += txtCodigo_TextChanged_1;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Rockwell", 12F);
            txtCantidad.Location = new Point(139, 202);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 26);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Rockwell", 12F);
            txtPrecio.Location = new Point(139, 122);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 26);
            txtPrecio.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSeaGreen;
            btnRegistrar.Font = new Font("Rockwell", 12F);
            btnRegistrar.Location = new Point(309, 122);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(127, 52);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar Producto";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Rockwell", 12F);
            label15.Location = new Point(30, 56);
            label15.Name = "label15";
            label15.Size = new Size(169, 19);
            label15.TabIndex = 24;
            label15.Text = "Seleccionar Producto:";
            // 
            // cmbEliminar
            // 
            cmbEliminar.Font = new Font("Rockwell", 12F);
            cmbEliminar.FormattingEnabled = true;
            cmbEliminar.Location = new Point(51, 77);
            cmbEliminar.Name = "cmbEliminar";
            cmbEliminar.Size = new Size(121, 27);
            cmbEliminar.TabIndex = 25;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Rockwell", 12F);
            btnEliminar.Location = new Point(277, 64);
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
            dataGridView1.ReadOnly = true;
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
            // cmbCategorias
            // 
            cmbCategorias.Font = new Font("Rockwell", 12F);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(139, 81);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 27);
            cmbCategorias.TabIndex = 31;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(9, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(536, 365);
            tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(528, 333);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(cmbCategorias);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(28, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 283);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrar Producto: ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(528, 333);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbCategorias2);
            groupBox3.Controls.Add(txtCantidadEditar);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtPrecioEditar);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnGuardarCambios);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtNombreEditar);
            groupBox3.Controls.Add(cmbEditar);
            groupBox3.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox3.Location = new Point(24, 33);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(473, 275);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "Editar Producto: ";
            // 
            // cmbCategorias2
            // 
            cmbCategorias2.Font = new Font("Rockwell", 12F);
            cmbCategorias2.FormattingEnabled = true;
            cmbCategorias2.Location = new Point(330, 85);
            cmbCategorias2.Name = "cmbCategorias2";
            cmbCategorias2.Size = new Size(121, 27);
            cmbCategorias2.TabIndex = 32;
            // 
            // txtCantidadEditar
            // 
            txtCantidadEditar.Font = new Font("Rockwell", 12F);
            txtCantidadEditar.Location = new Point(330, 122);
            txtCantidadEditar.Name = "txtCantidadEditar";
            txtCantidadEditar.Size = new Size(100, 26);
            txtCantidadEditar.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 12F);
            label11.Location = new Point(210, 88);
            label11.Name = "label11";
            label11.Size = new Size(92, 19);
            label11.TabIndex = 19;
            label11.Text = "Categoria: ";
            // 
            // txtPrecioEditar
            // 
            txtPrecioEditar.Font = new Font("Rockwell", 12F);
            txtPrecioEditar.Location = new Point(330, 159);
            txtPrecioEditar.Name = "txtPrecioEditar";
            txtPrecioEditar.Size = new Size(100, 26);
            txtPrecioEditar.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 12F);
            label10.Location = new Point(210, 55);
            label10.Name = "label10";
            label10.Size = new Size(75, 19);
            label10.TabIndex = 18;
            label10.Text = "Nombre:";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.LightSeaGreen;
            btnGuardarCambios.Font = new Font("Rockwell", 12F);
            btnGuardarCambios.Location = new Point(233, 214);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(178, 30);
            btnGuardarCambios.TabIndex = 22;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += BtnGuardarCambios_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 12F);
            label13.Location = new Point(210, 162);
            label13.Name = "label13";
            label13.Size = new Size(64, 19);
            label13.TabIndex = 21;
            label13.Text = "Precio: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F);
            label8.Location = new Point(17, 45);
            label8.Name = "label8";
            label8.Size = new Size(169, 19);
            label8.TabIndex = 11;
            label8.Text = "Seleccionar Producto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 12F);
            label12.Location = new Point(210, 125);
            label12.Name = "label12";
            label12.Size = new Size(86, 19);
            label12.TabIndex = 20;
            label12.Text = "Cantidad: ";
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.Font = new Font("Rockwell", 12F);
            txtNombreEditar.Location = new Point(330, 45);
            txtNombreEditar.Name = "txtNombreEditar";
            txtNombreEditar.Size = new Size(100, 26);
            txtNombreEditar.TabIndex = 13;
            // 
            // cmbEditar
            // 
            cmbEditar.Font = new Font("Rockwell", 12F);
            cmbEditar.FormattingEnabled = true;
            cmbEditar.Location = new Point(27, 74);
            cmbEditar.Name = "cmbEditar";
            cmbEditar.Size = new Size(121, 27);
            cmbEditar.TabIndex = 12;
            cmbEditar.SelectedIndexChanged += CmbEditar_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(528, 333);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(cmbEliminar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(24, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 295);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eliminar Producto";
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(288, 121);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(133, 117);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
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
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormGestionProductos";
            Text = "Gestion Productos";
            Load += FormGestionProductos_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
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
        private Label label15;
        private ComboBox cmbEliminar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox pictureBox2;
        private ComboBox cmbCategorias;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private PictureBox pictureBox6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private TextBox txtCantidadEditar;
        private ComboBox cmbCategorias2;
        private Label label8;
        private ComboBox cmbEditar;
        private TextBox txtNombreEditar;
        private TextBox txtPrecioEditar;
        private Label label10;
        private Button btnGuardarCambios;
        private Label label11;
        private Label label13;
        private Label label12;
    }
}