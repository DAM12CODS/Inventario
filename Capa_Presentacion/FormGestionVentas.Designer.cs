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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionVentas));
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbProductosVenta = new ComboBox();
            txtCantidadProducto = new TextBox();
            btnAgregarProducto = new Button();
            btnRegistrarVenta = new Button();
            label4 = new Label();
            label5 = new Label();
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
            dataGridView2 = new DataGridView();
            IdVenta = new DataGridViewTextBoxColumn();
            Productos = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioUnitarioVenta = new DataGridViewTextBoxColumn();
            PrecioTotal = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Red;
            btnVolver.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ControlLight;
            btnVolver.Location = new Point(817, 16);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(80, 27);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F);
            label1.Location = new Point(44, 79);
            label1.Name = "label1";
            label1.Size = new Size(121, 17);
            label1.TabIndex = 1;
            label1.Text = "Registar Venta: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 128);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Producto: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 154);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad: ";
            // 
            // cmbProductosVenta
            // 
            cmbProductosVenta.FormattingEnabled = true;
            cmbProductosVenta.Location = new Point(103, 120);
            cmbProductosVenta.Name = "cmbProductosVenta";
            cmbProductosVenta.Size = new Size(121, 23);
            cmbProductosVenta.TabIndex = 4;
            cmbProductosVenta.SelectedIndexChanged += cmbProductosVenta_SelectedIndexChanged;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(103, 149);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(121, 23);
            txtCantidadProducto.TabIndex = 5;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(70, 178);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(119, 23);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(285, 146);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(105, 23);
            btnRegistrarVenta.TabIndex = 7;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 12F);
            label5.Location = new Point(34, 380);
            label5.Name = "label5";
            label5.Size = new Size(180, 17);
            label5.TabIndex = 9;
            label5.Text = "Generar Reporte Venta: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 261);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 10;
            label6.Text = "Seleccionar Venta: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 413);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 11;
            label7.Text = "Seleccione Venta:";
            // 
            // cmbEliminarVenta
            // 
            cmbEliminarVenta.FormattingEnabled = true;
            cmbEliminarVenta.Location = new Point(51, 289);
            cmbEliminarVenta.Name = "cmbEliminarVenta";
            cmbEliminarVenta.Size = new Size(121, 23);
            cmbEliminarVenta.TabIndex = 12;
            cmbEliminarVenta.SelectedIndexChanged += cmbEliminarVenta_SelectedIndexChanged;
            // 
            // cmbVentaReporte
            // 
            cmbVentaReporte.FormattingEnabled = true;
            cmbVentaReporte.Location = new Point(70, 443);
            cmbVentaReporte.Name = "cmbVentaReporte";
            cmbVentaReporte.Size = new Size(121, 23);
            cmbVentaReporte.TabIndex = 13;
            cmbVentaReporte.SelectedIndexChanged += cmbVentaReporte_SelectedIndexChanged;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(285, 289);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(105, 23);
            btnEliminarVenta.TabIndex = 14;
            btnEliminarVenta.Text = "Eliminar venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(285, 442);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(105, 23);
            btnGenerarReporte.TabIndex = 15;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Codigo, Categoria, PrecioUnitario });
            dataGridView1.Location = new Point(463, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 135);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IdVenta, Productos, Cantidad, PrecioUnitarioVenta, PrecioTotal });
            dataGridView2.Location = new Point(463, 331);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(443, 122);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "IdVenta";
            IdVenta.Name = "IdVenta";
            // 
            // Productos
            // 
            Productos.HeaderText = "Productos";
            Productos.Name = "Productos";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitarioVenta
            // 
            PrecioUnitarioVenta.HeaderText = "Precio Unitario";
            PrecioUnitarioVenta.Name = "PrecioUnitarioVenta";
            // 
            // PrecioTotal
            // 
            PrecioTotal.HeaderText = "Precio Total";
            PrecioTotal.Name = "PrecioTotal";
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
            label8.Font = new Font("Britannic Bold", 12F);
            label8.Location = new Point(466, 75);
            label8.Name = "label8";
            label8.Size = new Size(136, 17);
            label8.TabIndex = 19;
            label8.Text = "Productos Venta: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 12F);
            label9.Location = new Point(465, 305);
            label9.Name = "label9";
            label9.Size = new Size(142, 17);
            label9.TabIndex = 20;
            label9.Text = "Ventas Existentes: ";
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 104);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 252);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(400, 104);
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(20, 400);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(400, 104);
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // FormGestionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 547);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenerarReporte);
            Controls.Add(btnEliminarVenta);
            Controls.Add(cmbVentaReporte);
            Controls.Add(cmbEliminarVenta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtCantidadProducto);
            Controls.Add(cmbProductosVenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Name = "FormGestionVentas";
            Text = "FormGestionVentas";
            Load += FormGestionVentas_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbProductosVenta;
        private TextBox txtCantidadProducto;
        private Button btnAgregarProducto;
        private Button btnRegistrarVenta;
        private Label label4;
        private Label label5;
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
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn Productos;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnitarioVenta;
        private DataGridViewTextBoxColumn PrecioTotal;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}