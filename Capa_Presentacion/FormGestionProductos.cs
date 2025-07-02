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
            FormGestionProductos_Load(this, EventArgs.Empty);
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
        private void FormGestionProductos_Load(object sender, EventArgs e)
        {
            // Cargar productos desde archivo si es necesario
            archivo.CargarProductos(productosCSV, encabezado, productos);

            // Llenar ComboBox de editar
            cmbEditar.DataSource = null;
            cmbEditar.DataSource = productos;
            cmbEditar.DisplayMember = "NombreProducto";
            cmbEditar.ValueMember = "CodigoProducto";

            // Llenar ComboBox de eliminar
            cmbEliminar.DataSource = null;
            cmbEliminar.DataSource = productos;
            cmbEliminar.DisplayMember = "NombreProducto";
            cmbEliminar.ValueMember = "CodigoProducto";

            // Mostrar productos en el DataGrid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //var agregar = new GestionProducto();
            string codigoP = txtCodigo.Text.Trim();
            string nombreP = txtNombreProducto.Text.Trim();
            string categoriaP = txtCategoria.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigoP) || string.IsNullOrWhiteSpace(nombreP) || string.IsNullOrWhiteSpace(categoriaP))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidadP))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }
            if (!double.TryParse(txtPrecio.Text.Trim(), out double precioP))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }
            archivo.AgregarProducto(productosCSV, encabezado, productos, codigoP, nombreP, categoriaP, cantidadP,
                precioP);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            txtCodigo.Text = "";
            txtPrecio.Text = "";
            txtCategoria.Text = "";
            txtCantidad.Text = "";
            txtNombreProducto.Text = ""; 
            //Guardar en el combobox de editar producto 
            cmbEditar.DataSource = null;
            cmbEditar.DataSource = productos;
            cmbEditar.DisplayMember = "NombreProducto";
            cmbEditar.ValueMember = "CodigoProducto";

            //Guardar en el combobox de eliminar producto
            cmbEliminar.DataSource = null;
            cmbEliminar.DataSource = productos;
            cmbEliminar.DisplayMember = "NombreProducto";
            cmbEliminar.ValueMember = "CodigoProducto";

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Verifica que haya un producto seleccionado
            if (cmbEditar.SelectedIndex == -1 || cmbEditar.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto válido para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoP = cmbEditar.SelectedValue?.ToString().Trim();
            string nombreP = txtNombreEditar.Text.Trim();
            string categoriaP = txtCategoriaEditar.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigoP) || string.IsNullOrWhiteSpace(nombreP) || string.IsNullOrWhiteSpace(categoriaP))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtCantidadEditar.Text.Trim(), out int cantidadP))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }

            if (!double.TryParse(txtPrecioEditar.Text.Trim(), out double precioP))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }

            archivo.ActualizarProducto(productosCSV, encabezado, productos, codigoP, nombreP, categoriaP, cantidadP, precioP);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
            txtNombreEditar.Text = "";
            txtCategoriaEditar.Text = "";
            
            MessageBox.Show("Producto actualizado correctamente.");
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //var eliminar = new GestionProducto();
            string codigoP = cmbEliminar.SelectedValue?.ToString().Trim();

            if (cmbEliminar.SelectedIndex == -1 || cmbEliminar.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            archivo.EliminarProducto(productosCSV, encabezado, productos, codigoP);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            //Refresca ComboBox de editar
            cmbEditar.DataSource = null;
            cmbEditar.DataSource = productos;
            cmbEditar.DisplayMember = "NombreProducto";
            cmbEditar.ValueMember = "CodigoProducto";

            //Refresca ComboBox de eliminar
            cmbEliminar.DataSource = null;
            cmbEliminar.DataSource = productos;
            cmbEliminar.DisplayMember = "NombreProducto";
            cmbEliminar.ValueMember = "CodigoProducto";

            MessageBox.Show("Producto eliminado correctamente.");
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
