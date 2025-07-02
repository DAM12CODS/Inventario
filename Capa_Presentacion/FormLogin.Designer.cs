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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ControlLight;
            btnSalir.Location = new Point(1103, 787);
            btnSalir.Margin = new Padding(6, 6, 6, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(264, 77);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir Programa";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 599);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 663);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 37);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(513, 599);
            txtNombre.Margin = new Padding(6, 6, 6, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(459, 39);
            txtNombre.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(559, 663);
            txtContraseña.Margin = new Padding(6, 6, 6, 6);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(357, 39);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Red;
            btnVolver.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ControlLight;
            btnVolver.Location = new Point(22, 815);
            btnVolver.Margin = new Padding(6, 6, 6, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 66);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ControlLight;
            btnIngresar.Location = new Point(591, 725);
            btnIngresar.Margin = new Padding(6, 6, 6, 6);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(230, 98);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 26);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(951, 542);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 890);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngresar);
            Controls.Add(btnVolver);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormLogin";
            Text = "FormLogin";
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
    }
}