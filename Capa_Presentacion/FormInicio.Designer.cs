namespace Capa_Presentacion
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            Ingresar = new Button();
            pictureBox1 = new PictureBox();
            btnSalirPrograma = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Ingresar
            // 
            Ingresar.BackColor = Color.RoyalBlue;
            Ingresar.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ingresar.ForeColor = SystemColors.ButtonFace;
            Ingresar.Location = new Point(297, 317);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(194, 80);
            Ingresar.TabIndex = 1;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = false;
            Ingresar.Click += Ingresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 251);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSalirPrograma
            // 
            btnSalirPrograma.BackColor = Color.Red;
            btnSalirPrograma.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalirPrograma.ForeColor = SystemColors.ButtonHighlight;
            btnSalirPrograma.Location = new Point(12, 12);
            btnSalirPrograma.Name = "btnSalirPrograma";
            btnSalirPrograma.Size = new Size(74, 29);
            btnSalirPrograma.TabIndex = 3;
            btnSalirPrograma.Text = "SALIR";
            btnSalirPrograma.UseVisualStyleBackColor = false;
            btnSalirPrograma.Click += BtnSalirPrograma_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalirPrograma);
            Controls.Add(pictureBox1);
            Controls.Add(Ingresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInicio";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Ingresar;
        private PictureBox pictureBox1;
        private Button btnSalirPrograma;
    }
}