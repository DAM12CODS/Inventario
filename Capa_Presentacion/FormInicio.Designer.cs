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
            Ingresar = new Button();
            SuspendLayout();
            // 
            // Ingresar
            // 
            Ingresar.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ingresar.Location = new Point(289, 301);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(194, 80);
            Ingresar.TabIndex = 1;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ingresar);
            Name = "FormInicio";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Ingresar;
    }
}