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
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreProducto = new TextBox();
            txtCodigo = new TextBox();
            txtCategoria = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnRegistrar = new Button();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            txtNombreEditar = new TextBox();
            txtCategoriaEditar = new TextBox();
            txtCantidadEditar = new TextBox();
            txtPrecioEditar = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnGuardarCambios = new Button();
            label14 = new Label();
            label15 = new Label();
            comboBox2 = new ComboBox();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(872, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 30);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 39);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Registrar Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 106);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Código: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 77);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 132);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "Categoría: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 161);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 2;
            label5.Text = "Cantidad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 188);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 2;
            label6.Text = "Precio: ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(102, 73);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(103, 102);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 5;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(106, 129);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(106, 158);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(94, 187);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(271, 115);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 49);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 236);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 10;
            label7.Text = "Editar Producto: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 264);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 11;
            label8.Text = "Seleccionar Producto:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 282);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.Location = new Point(106, 318);
            txtNombreEditar.Name = "txtNombreEditar";
            txtNombreEditar.Size = new Size(100, 23);
            txtNombreEditar.TabIndex = 13;
            // 
            // txtCategoriaEditar
            // 
            txtCategoriaEditar.Location = new Point(106, 347);
            txtCategoriaEditar.Name = "txtCategoriaEditar";
            txtCategoriaEditar.Size = new Size(100, 23);
            txtCategoriaEditar.TabIndex = 14;
            // 
            // txtCantidadEditar
            // 
            txtCantidadEditar.Location = new Point(106, 376);
            txtCantidadEditar.Name = "txtCantidadEditar";
            txtCantidadEditar.Size = new Size(100, 23);
            txtCantidadEditar.TabIndex = 15;
            // 
            // txtPrecioEditar
            // 
            txtPrecioEditar.Location = new Point(106, 405);
            txtPrecioEditar.Name = "txtPrecioEditar";
            txtPrecioEditar.Size = new Size(100, 23);
            txtPrecioEditar.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 321);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 18;
            label10.Text = "Nombre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 347);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 19;
            label11.Text = "Categoria: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 379);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 20;
            label12.Text = "Cantidad: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 408);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 21;
            label13.Text = "Precio: ";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(44, 455);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(138, 26);
            btnGuardarCambios.TabIndex = 22;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(322, 242);
            label14.Name = "label14";
            label14.Size = new Size(108, 15);
            label14.TabIndex = 23;
            label14.Text = "Eliminar Producto: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(327, 265);
            label15.Name = "label15";
            label15.Size = new Size(122, 15);
            label15.TabIndex = 24;
            label15.Text = "Seleccionar Producto:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(328, 283);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 25;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(322, 400);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 30);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Codigo, Cantidad, PrecioUnitario });
            dataGridView1.Location = new Point(486, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 382);
            dataGridView1.TabIndex = 27;
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
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            // 
            // FormGestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 568);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(comboBox2);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnGuardarCambios);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtPrecioEditar);
            Controls.Add(txtCantidadEditar);
            Controls.Add(txtCategoriaEditar);
            Controls.Add(txtNombreEditar);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombreProducto);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Name = "FormGestionProductos";
            Text = "FormGestionProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtCategoria;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnRegistrar;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox txtNombreEditar;
        private TextBox txtCategoriaEditar;
        private TextBox txtCantidadEditar;
        private TextBox txtPrecioEditar;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnGuardarCambios;
        private Label label14;
        private Label label15;
        private ComboBox comboBox2;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnitario;
    }
}