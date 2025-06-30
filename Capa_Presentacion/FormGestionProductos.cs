using Inventario;
using Datos;

namespace Capa_Presentacion
{
    public partial class FormGestionProductos : Form
    {
        private FormMenuPrincipal formAnterior;

        private List<Producto> productos = new List<Producto>();
        private string productosCSV = "productos.csv";
        private string encabezado = "Codigo;Nombre;Categoria;Cantidad;Precio";
        GestionProducto archivo = new GestionProducto();


        // Constructor que recibe el formulario anterior
        public FormGestionProductos(FormMenuPrincipal anterior)
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

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //var agregar = new GestionProducto();
            string codigoP = txtCodigo.Text.Trim();
            string nombreP = txtNombreProducto.Text.Trim();
            string categoriaP = txtCategoria.Text.Trim();
            int cantidadP = int.Parse(txtCantidad.Text.Trim());
            double precioP = double.Parse(txtPrecio.Text.Trim());
            archivo.AgregarProducto(productosCSV, encabezado, productos, codigoP, nombreP, categoriaP, cantidadP,
                precioP);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //var editar = new GestionProducto();
            string codigoP = comboBox1.Text.Trim();
            string nombreP = txtNombreEditar.Text.Trim();
            string categoriaP = txtCategoriaEditar.Text.Trim();
            int cantidadP = int.Parse(txtCantidadEditar.Text.Trim());
            double precioP = double.Parse(txtPrecioEditar.Text.Trim());
            archivo.ActualizarProducto(productosCSV, encabezado, productos, codigoP, nombreP, categoriaP, cantidadP,
                precioP);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //var eliminar = new GestionProducto();
            string codigoP = comboBox2.Text.Trim();
            archivo.EliminarProducto(productosCSV, encabezado, productos, codigoP);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
        }
    }

}
