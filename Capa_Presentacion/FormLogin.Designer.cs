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
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            btnVolver = new Button();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(594, 369);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 36);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir Programa";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 213);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 243);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(250, 213);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(249, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(275, 243);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(224, 23);
            txtContraseña.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 382);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(315, 288);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(124, 46);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 417);
            Controls.Add(btnIngresar);
            Controls.Add(btnVolver);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Name = "FormLogin";
            Text = "FormLogin";
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
    }
}