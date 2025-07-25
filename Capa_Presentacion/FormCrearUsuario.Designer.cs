namespace Capa_Presentacion
{
    partial class FormCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearUsuario));
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnCrear = new Button();
            cmbRoles = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Rockwell", 12F);
            txtNombre.Location = new Point(175, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 26);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Rockwell", 12F);
            txtApellido.Location = new Point(175, 118);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(166, 26);
            txtApellido.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Rockwell", 12F);
            txtEmail.Location = new Point(175, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Rockwell", 12F);
            txtPassword.Location = new Point(175, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 26);
            txtPassword.TabIndex = 3;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.LightSeaGreen;
            btnCrear.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.FromArgb(64, 64, 64);
            btnCrear.Location = new Point(233, 262);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(170, 44);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear Cuenta";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.Font = new Font("Rockwell", 12F);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(459, 73);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(121, 27);
            cmbRoles.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(568, 12);
            button1.Name = "button1";
            button1.Size = new Size(74, 27);
            button1.TabIndex = 6;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(242, 27);
            label1.TabIndex = 7;
            label1.Text = "Creacion de usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F);
            label2.Location = new Point(15, 73);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F);
            label3.Location = new Point(15, 117);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 9;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F);
            label4.Location = new Point(15, 160);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 10;
            label4.Text = "Correo Electrónico: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F);
            label5.Location = new Point(15, 208);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 11;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F);
            label6.Location = new Point(421, 75);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 12;
            label6.Text = "Rol:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(975, 59);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // FormCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(654, 329);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cmbRoles);
            Controls.Add(btnCrear);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrearUsuario";
            Text = "Crear Usuario ";
            Load += FormCrearUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnCrear;
        private ComboBox cmbRoles;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
    }
}