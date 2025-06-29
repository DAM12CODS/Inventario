using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FormLogin : Form
    {
        private FormInicio formAnterior;

        public FormLogin(FormInicio anterior)
        {
            InitializeComponent();
            this.formAnterior = anterior;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (usuario == "admin" && contraseña == "1234")
            {
                FormMenuPrincipal menu = new FormMenuPrincipal(this);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();               // Cierra FormLogin
            formAnterior.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
