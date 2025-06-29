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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(this); // Pasa el formulario actual como referencia
            login.Show();
            this.Hide(); // Oculta FormInicio
        }

        private void btnSalirPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
