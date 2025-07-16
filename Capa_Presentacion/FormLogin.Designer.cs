namespace Capa_Presentacion
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            btnVolver = new Button();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            btnCrearCuenta = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.WindowFrame;
            btnSalir.Font = new Font("Britannic Bold", 12F);
            btnSalir.ForeColor = SystemColors.ControlLight;
            btnSalir.Location = new Point(594, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 36);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir Programa";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F);
            label1.Location = new Point(206, 184);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 12F);
            label2.Location = new Point(206, 215);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(310, 184);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(310, 214);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(224, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            txtContraseña.KeyPress += txtContraseña_KeyPress;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.WindowFrame;
            btnVolver.Font = new Font("Britannic Bold", 12F);
            btnVolver.ForeColor = SystemColors.ControlLight;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(78, 31);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ControlLight;
            btnIngresar.Location = new Point(253, 247);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(255, 29);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Iniciar Sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 157);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = SystemColors.Window;
            btnCrearCuenta.Location = new Point(310, 419);
            btnCrearCuenta.Margin = new Padding(2);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(151, 20);
            btnCrearCuenta.TabIndex = 8;
            btnCrearCuenta.Text = "Crear una cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 380);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 15);
            label3.TabIndex = 9;
            label3.Text = "¿Es la primera vez que usas Inventory?";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(270, 298);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 55);
            label4.TabIndex = 10;
            label4.Text = "Es gratis y muy fácil. Descubre miles de programas para usarlos en tus proyectos de venta.";
            label4.Click += label4_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 477);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCrearCuenta);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngresar);
            Controls.Add(btnVolver);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private Button btnVolver;
        private Button btnIngresar;
        private PictureBox pictureBox1;
        private Button btnCrearCuenta;
        private Label label3;
        private Label label4;
    }
}