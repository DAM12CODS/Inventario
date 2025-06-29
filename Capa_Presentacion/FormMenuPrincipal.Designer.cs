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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGProductos
            // 
            btnGProductos.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGProductos.Location = new Point(64, 147);
            btnGProductos.Name = "btnGProductos";
            btnGProductos.Size = new Size(188, 23);
            btnGProductos.TabIndex = 0;
            btnGProductos.Text = "Gestionar Productos";
            btnGProductos.UseVisualStyleBackColor = true;
            btnGProductos.Click += btnGProductos_Click;
            // 
            // btnGVentas
            // 
            btnGVentas.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGVentas.Location = new Point(81, 192);
            btnGVentas.Name = "btnGVentas";
            btnGVentas.Size = new Size(152, 23);
            btnGVentas.TabIndex = 1;
            btnGVentas.Text = "Gestionar Ventas";
            btnGVentas.UseVisualStyleBackColor = true;
            btnGVentas.Click += btnGVentas_Click;
            // 
            // btnEInventario
            // 
            btnEInventario.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEInventario.Location = new Point(81, 242);
            btnEInventario.Name = "btnEInventario";
            btnEInventario.Size = new Size(150, 23);
            btnEInventario.TabIndex = 2;
            btnEInventario.Text = "Estado Inventario";
            btnEInventario.UseVisualStyleBackColor = true;
            btnEInventario.Click += btnEInventario_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(26, 383);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(120, 23);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(319, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 257);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 313);
            label1.Name = "label1";
            label1.Size = new Size(296, 27);
            label1.TabIndex = 5;
            label1.Text = "\"ORGANIZANDO AL MUNDO\"";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 430);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEInventario);
            Controls.Add(btnGVentas);
            Controls.Add(btnGProductos);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
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
        private Label label1;
    }
}