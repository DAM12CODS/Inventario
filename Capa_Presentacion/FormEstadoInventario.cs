using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Inventario;

namespace Capa_Presentacion
{
    public partial class FormEstadoInventario : Form
    {
        private FormMenuPrincipal formAnterior;
        private List<Producto> productos = new List<Producto>();
        private string productosCSV = "productos.csv";
        private string encabezado = "Codigo;Nombre;Categoria;Cantidad;Precio";

        // Constructor que recibe el formulario anterior
        public FormEstadoInventario(FormMenuPrincipal anterior)
        {
            InitializeComponent();
            this.formAnterior = anterior;
            var gestor = new GestionProducto();
            gestor.CargarProductos(productosCSV, encabezado, productos);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario
            formAnterior.Show(); // Muestra el menú principal nuevamente
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEstadoInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
