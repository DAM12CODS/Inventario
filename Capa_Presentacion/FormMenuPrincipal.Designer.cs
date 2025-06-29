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
            btnGProductos = new Button();
            btnGVentas = new Button();
            btnEInventario = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnGProductos
            // 
            btnGProductos.Location = new Point(110, 148);
            btnGProductos.Name = "btnGProductos";
            btnGProductos.Size = new Size(150, 23);
            btnGProductos.TabIndex = 0;
            btnGProductos.Text = "Gestionar Productos";
            btnGProductos.UseVisualStyleBackColor = true;
            btnGProductos.Click += btnGProductos_Click;
            // 
            // btnGVentas
            // 
            btnGVentas.Location = new Point(131, 192);
            btnGVentas.Name = "btnGVentas";
            btnGVentas.Size = new Size(112, 23);
            btnGVentas.TabIndex = 1;
            btnGVentas.Text = "Gestionar Ventas";
            btnGVentas.UseVisualStyleBackColor = true;
            btnGVentas.Click += btnGVentas_Click;
            // 
            // btnEInventario
            // 
            btnEInventario.Location = new Point(110, 244);
            btnEInventario.Name = "btnEInventario";
            btnEInventario.Size = new Size(150, 23);
            btnEInventario.TabIndex = 2;
            btnEInventario.Text = "Estado Inventario";
            btnEInventario.UseVisualStyleBackColor = true;
            btnEInventario.Click += btnEInventario_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(43, 370);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(93, 23);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click_1;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 430);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEInventario);
            Controls.Add(btnGVentas);
            Controls.Add(btnGProductos);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGProductos;
        private Button btnGVentas;
        private Button btnEInventario;
        private Button btnCerrarSesion;
    }
}