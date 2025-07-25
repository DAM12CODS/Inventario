namespace Capa_Presentacion
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            btnGProductos = new Button();
            btnGVentas = new Button();
            btnEInventario = new Button();
            btnCerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            lblEntrada = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGProductos
            // 
            btnGProductos.Cursor = Cursors.SizeNESW;
            btnGProductos.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnGProductos.Location = new Point(54, 134);
            btnGProductos.Name = "btnGProductos";
            btnGProductos.Size = new Size(197, 37);
            btnGProductos.TabIndex = 0;
            btnGProductos.Text = "Gestionar Productos";
            btnGProductos.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGProductos.UseVisualStyleBackColor = true;
            btnGProductos.Click += BtnGProductos_Click;
            // 
            // btnGVentas
            // 
            btnGVentas.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnGVentas.Location = new Point(59, 191);
            btnGVentas.Name = "btnGVentas";
            btnGVentas.Size = new Size(181, 37);
            btnGVentas.TabIndex = 1;
            btnGVentas.Text = "Gestionar Ventas";
            btnGVentas.UseVisualStyleBackColor = true;
            btnGVentas.Click += BtnGVentas_Click;
            // 
            // btnEInventario
            // 
            btnEInventario.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnEInventario.Location = new Point(59, 251);
            btnEInventario.Name = "btnEInventario";
            btnEInventario.Size = new Size(181, 37);
            btnEInventario.TabIndex = 2;
            btnEInventario.Text = "Estado Inventario";
            btnEInventario.UseVisualStyleBackColor = true;
            btnEInventario.Click += BtnEInventario_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Red;
            btnCerrarSesion.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ControlLight;
            btnCerrarSesion.Location = new Point(18, 389);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(129, 29);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += BtnCerrarSesion_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(345, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntrada.Location = new Point(18, 16);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(0, 17);
            lblEntrada.TabIndex = 5;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 430);
            Controls.Add(lblEntrada);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEInventario);
            Controls.Add(btnGVentas);
            Controls.Add(btnGProductos);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenuPrincipal";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGProductos;
        private Button btnGVentas;
        private Button btnEInventario;
        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private Label lblEntrada;
    }
}