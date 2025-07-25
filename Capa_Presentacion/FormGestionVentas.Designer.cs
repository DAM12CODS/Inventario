namespace Capa_Presentacion
{
    partial class FormGestionVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionVentas));
            btnVolver = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbProductosVenta = new ComboBox();
            txtCantidadProducto = new TextBox();
            btnAgregarProducto = new Button();
            btnRegistrarVenta = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbEliminarVenta = new ComboBox();
            cmbVentaReporte = new ComboBox();
            btnEliminarVenta = new Button();
            btnGenerarReporte = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            lblStockDisponible = new Label();
            lblPrecioProducto = new Label();
            lblCategoriaProducto = new Label();
            lblNombreProducto = new Label();
            lblCodigoProducto = new Label();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Red;
            btnVolver.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ControlLight;
            btnVolver.Location = new Point(967, 16);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(80, 27);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += BtnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F);
            label2.Location = new Point(19, 43);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 2;
            label2.Text = "Producto: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F);
            label3.Location = new Point(19, 70);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 3;
            label3.Text = "Cantidad: ";
            // 
            // cmbProductosVenta
            // 
            cmbProductosVenta.Font = new Font("Rockwell", 12F);
            cmbProductosVenta.FormattingEnabled = true;
            cmbProductosVenta.Location = new Point(109, 39);
            cmbProductosVenta.Name = "cmbProductosVenta";
            cmbProductosVenta.Size = new Size(121, 27);
            cmbProductosVenta.TabIndex = 4;
            cmbProductosVenta.SelectedIndexChanged += CmbProductosVenta_SelectedIndexChanged;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Font = new Font("Rockwell", 12F);
            txtCantidadProducto.Location = new Point(109, 68);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(121, 26);
            txtCantidadProducto.TabIndex = 5;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.CadetBlue;
            btnAgregarProducto.Font = new Font("Rockwell", 12F);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(36, 103);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(169, 37);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.LightSeaGreen;
            btnRegistrarVenta.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarVenta.ForeColor = Color.FromArgb(64, 64, 64);
            btnRegistrarVenta.Location = new Point(314, 43);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(127, 50);
            btnRegistrarVenta.TabIndex = 7;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += BtnRegistrarVenta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 12F);
            label4.Location = new Point(44, 232);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 8;
            label4.Text = "Eliminar Venta: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(26, 32);
            label6.Name = "label6";
            label6.Size = new Size(150, 19);
            label6.TabIndex = 10;
            label6.Text = "Seleccionar Venta: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 12F);
            label7.Location = new Point(22, 30);
            label7.Name = "label7";
            label7.Size = new Size(139, 19);
            label7.TabIndex = 11;
            label7.Text = "Seleccione Venta:";
            // 
            // cmbEliminarVenta
            // 
            cmbEliminarVenta.Font = new Font("Rockwell", 12F);
            cmbEliminarVenta.ForeColor = Color.FromArgb(64, 64, 64);
            cmbEliminarVenta.FormattingEnabled = true;
            cmbEliminarVenta.Location = new Point(41, 50);
            cmbEliminarVenta.Name = "cmbEliminarVenta";
            cmbEliminarVenta.Size = new Size(121, 27);
            cmbEliminarVenta.TabIndex = 12;
            cmbEliminarVenta.SelectedIndexChanged += CmbEliminarVenta_SelectedIndexChanged;
            // 
            // cmbVentaReporte
            // 
            cmbVentaReporte.Font = new Font("Rockwell", 12F);
            cmbVentaReporte.ForeColor = Color.FromArgb(64, 64, 64);
            cmbVentaReporte.FormattingEnabled = true;
            cmbVentaReporte.Location = new Point(41, 54);
            cmbVentaReporte.Name = "cmbVentaReporte";
            cmbVentaReporte.Size = new Size(121, 27);
            cmbVentaReporte.TabIndex = 13;
            cmbVentaReporte.SelectedIndexChanged += CmbVentaReporte_SelectedIndexChanged;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.BackColor = Color.LightSeaGreen;
            btnEliminarVenta.Font = new Font("Rockwell", 12F);
            btnEliminarVenta.ForeColor = Color.FromArgb(64, 64, 64);
            btnEliminarVenta.Location = new Point(251, 32);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(148, 42);
            btnEliminarVenta.TabIndex = 14;
            btnEliminarVenta.Text = "Eliminar venta";
            btnEliminarVenta.UseVisualStyleBackColor = false;
            btnEliminarVenta.Click += BtnEliminarVenta_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.LightSeaGreen;
            btnGenerarReporte.Font = new Font("Rockwell", 12F);
            btnGenerarReporte.ForeColor = Color.FromArgb(64, 64, 64);
            btnGenerarReporte.Location = new Point(230, 30);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(156, 41);
            btnGenerarReporte.TabIndex = 15;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += BtnGenerarReporte_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Codigo, Categoria, PrecioUnitario });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Onyx", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(530, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 135);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(975, 59);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(557, 7);
            label8.Name = "label8";
            label8.Size = new Size(241, 20);
            label8.TabIndex = 19;
            label8.Text = "Productos Agregados a Venta: ";
            label8.Click += Label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gray;
            label10.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(12, 16);
            label10.Name = "label10";
            label10.Size = new Size(159, 27);
            label10.TabIndex = 30;
            label10.Text = "Gestion Venta";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(189, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(975, 59);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(txtCantidadProducto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbProductosVenta);
            groupBox1.Controls.Add(btnAgregarProducto);
            groupBox1.Controls.Add(btnRegistrarVenta);
            groupBox1.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(10, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 146);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Venta: ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(20, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1039, 425);
            tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label8);
            tabPage1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 23);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1031, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar Venta";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(224, 224, 224);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(lblStockDisponible);
            groupBox2.Controls.Add(lblPrecioProducto);
            groupBox2.Controls.Add(lblCategoriaProducto);
            groupBox2.Controls.Add(lblNombreProducto);
            groupBox2.Controls.Add(lblCodigoProducto);
            groupBox2.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(10, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(488, 192);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion del Producto";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Rockwell", 12F);
            label15.Location = new Point(10, 158);
            label15.Name = "label15";
            label15.Size = new Size(124, 19);
            label15.TabIndex = 9;
            label15.Text = "Stock Producto:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 12F);
            label14.Location = new Point(10, 126);
            label14.Name = "label14";
            label14.Size = new Size(130, 19);
            label14.TabIndex = 8;
            label14.Text = "Precio Producto:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 12F);
            label13.Location = new Point(10, 100);
            label13.Name = "label13";
            label13.Size = new Size(158, 19);
            label13.TabIndex = 7;
            label13.Text = "Categoria Producto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 12F);
            label12.Location = new Point(10, 66);
            label12.Name = "label12";
            label12.Size = new Size(145, 19);
            label12.TabIndex = 6;
            label12.Text = "Nombre Producto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 12F);
            label11.Location = new Point(10, 33);
            label11.Name = "label11";
            label11.Size = new Size(138, 19);
            label11.TabIndex = 5;
            label11.Text = "Codigo Producto:";
            // 
            // lblStockDisponible
            // 
            lblStockDisponible.AutoSize = true;
            lblStockDisponible.Font = new Font("Rockwell", 12F);
            lblStockDisponible.Location = new Point(182, 159);
            lblStockDisponible.Name = "lblStockDisponible";
            lblStockDisponible.Size = new Size(0, 19);
            lblStockDisponible.TabIndex = 4;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Rockwell", 12F);
            lblPrecioProducto.Location = new Point(182, 129);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(0, 19);
            lblPrecioProducto.TabIndex = 3;
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Font = new Font("Rockwell", 12F);
            lblCategoriaProducto.Location = new Point(182, 99);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(0, 19);
            lblCategoriaProducto.TabIndex = 2;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Rockwell", 12F);
            lblNombreProducto.Location = new Point(182, 69);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(0, 19);
            lblNombreProducto.TabIndex = 1;
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Font = new Font("Rockwell", 12F);
            lblCodigoProducto.Location = new Point(182, 39);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(0, 19);
            lblCodigoProducto.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 23);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1031, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estado Venta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(224, 224, 224);
            groupBox4.Controls.Add(btnGenerarReporte);
            groupBox4.Controls.Add(cmbVentaReporte);
            groupBox4.Controls.Add(label7);
            groupBox4.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox4.Location = new Point(30, 186);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(421, 107);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Generar Reporte Venta: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(480, 46);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 22;
            label5.Text = "Ventas Existentes: ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(224, 224, 224);
            groupBox3.Controls.Add(btnEliminarVenta);
            groupBox3.Controls.Add(cmbEliminarVenta);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox3.Location = new Point(32, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(419, 100);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Venta: ";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView3.Location = new Point(480, 69);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(530, 224);
            dataGridView3.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "IdVenta";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Productos";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio Unitario";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Precio Total";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormGestionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 501);
            Controls.Add(tabControl1);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGestionVentas";
            Text = "Gestion Ventas";
            Load += FormGestionVentas_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label2;
        private Label label3;
        private ComboBox cmbProductosVenta;
        private TextBox txtCantidadProducto;
        private Button btnAgregarProducto;
        private Button btnRegistrarVenta;
        private Label label4;
        private Label label6;
        private Label label7;
        private ComboBox cmbEliminarVenta;
        private ComboBox cmbVentaReporte;
        private Button btnEliminarVenta;
        private Button btnGenerarReporte;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label10;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label lblStockDisponible;
        private Label lblPrecioProducto;
        private Label lblCategoriaProducto;
        private Label lblNombreProducto;
        private Label lblCodigoProducto;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label5;
    }
}