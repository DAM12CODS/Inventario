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
    public partial class FormMenuPrincipal : Form
    {
        private FormLogin formAnterior;

        // Constructor que recibe el login como referencia
        public FormMenuPrincipal(FormLogin anterior)
        {
            InitializeComponent();
            this.formAnterior = anterior;
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();              // Cierra el menú
            formAnterior.Show();
        }

        private void btnGProductos_Click(object sender, EventArgs e)
        {
            FormGestionProductos gestion = new FormGestionProductos(this); 
            gestion.Show();
            this.Hide(); // Oculta el menú principal

        }

        private void btnGVentas_Click(object sender, EventArgs e)
        {
            FormGestionVentas venta = new FormGestionVentas(this);
            venta.Show();
            this.Hide(); // Oculta el menú principal
        }

        private void btnEInventario_Click(object sender, EventArgs e)
        {
            FormEstadoInventario estadoInventario = new FormEstadoInventario(this);
            estadoInventario.Show();
            this.Hide(); // Oculta el menú principal
        }
    }
}

