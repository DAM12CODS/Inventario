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
    public partial class FormGestionVentas : Form
    {
        
        private FormMenuPrincipal formAnterior;

        // Constructor que recibe el formulario anterior
        public FormGestionVentas(FormMenuPrincipal anterior)
        {
            InitializeComponent();
            this.formAnterior = anterior;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario
            formAnterior.Show(); // Muestra el menú principal nuevamente
        }
    }
}
