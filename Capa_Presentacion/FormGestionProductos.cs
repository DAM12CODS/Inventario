// <copyright file="FormGestionProductos.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Presentacion
{
    using Capa_Entidad;
    using Datos;
    using Inventario;

    /// <summary>
    /// Representa el formulario de gestion de productos.
    /// Muestra area para agregar productos, editar ademas de eliminar y permite volver al menú principal.
    /// </summary>
    public partial class FormGestionProductos : Form
    {

        private List<Producto> productos = new List<Producto>();
        private List<string> categorias = new List<string>
        {
            "Frutas y verduras","Carnes y embutidos", "Bebidas",
            "Cereales y productos secos", "Detergentes y jabones","Desinfectantes","Champús y acondicionadores","Desodorantes","Utilies Escolares",
        };

        private string productosCSV = "productos.csv";
        private string encabezado = "Codigo;Nombre;Categoria;Cantidad;Precio";
        private GestionProducto archivo = new GestionProducto();
        private bool confirmandoCierre = false;

        // Constructor que recibe el formulario anterior

        /// <summary>
        /// Initializes a new instance of the <see cref="FormGestionProductos"/> class.
        /// </summary>
        /// <param name="anterior">Permite volver al anterior form.</param>
        public FormGestionProductos()
        {
            this.InitializeComponent();
            this.FormClosing += FormX_FormClosing; // reemplaza "X" por el nombre del formulario
            var gestor = new GestionProducto();
            gestor.CargarProductos(this.productosCSV, this.encabezado, this.productos);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.productos;

            // Lita de Categorias
            cmbCategorias.DataSource = null;
            cmbCategorias.DataSource = categorias;
            cmbCategorias2.DataSource = categorias;
            this.FormGestionProductos_Load(this, EventArgs.Empty);
        }

        private void FormX_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.confirmandoCierre && e.CloseReason == CloseReason.UserClosing)
            {
                this.confirmandoCierre = true;

                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea salir?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    this.confirmandoCierre = false;
                }
                else
                {
                    Application.Exit();
                }
            }
        }


        private void LimpiarCampos()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtNombreProducto.Text = string.Empty;
            // string categoriaP = cmbCategorias.SelectedValue?.ToString().Trim();
            this.txtCantidad.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TxtNombreProducto_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormGestionProductos_Load(object sender, EventArgs e)
        {
            // Cargar productos desde archivo si es necesario
            this.archivo.CargarProductos(this.productosCSV, this.encabezado, this.productos);

            // Llenar ComboBox de editar
            this.cmbEditar.DataSource = null;
            this.cmbEditar.DataSource = this.productos;
            this.cmbEditar.DisplayMember = "NombreProducto";
            this.cmbEditar.ValueMember = "CodigoProducto";

            // Llenar ComboBox de eliminar
            this.cmbEliminar.DataSource = null;
            this.cmbEliminar.DataSource = this.productos;
            this.cmbEliminar.DisplayMember = "NombreProducto";
            this.cmbEliminar.ValueMember = "CodigoProducto";

            // Mostrar productos en el DataGrid
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.productos;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string codigoP = this.txtCodigo.Text.Trim();
            string nombreP = this.txtNombreProducto.Text.Trim();
            string categoriaP = cmbCategorias.SelectedValue?.ToString().Trim();
            string cantidadText = this.txtCantidad.Text.Trim();
            string precioText = this.txtPrecio.Text.Trim();

            List<string> errores = new List<string>();
            bool hayCampoVacio = false;

            // Validar código
            if (string.IsNullOrWhiteSpace(codigoP))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (codigoP.Length != 6)
                {
                    errores.Add("El código del producto debe tener exactamente 6 caracteres entre letras o numeros.");
                }

                if (this.productos.Any(p => p.CodigoProducto.Equals(codigoP, StringComparison.OrdinalIgnoreCase)))
                {
                    errores.Add("Ya existe un producto con ese código.");
                }
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombreP))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!nombreP.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    errores.Add("El nombre del producto solo debe contener letras.");
                }
            }

            // Validar categoría
            if (string.IsNullOrWhiteSpace(categoriaP))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!categoriaP.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    errores.Add("La categoría solo debe contener letras.");
                }
            }

            // Validar cantidad
            int cantidadP = 0;
            if (string.IsNullOrWhiteSpace(cantidadText))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!int.TryParse(cantidadText, out cantidadP))
                {
                    errores.Add("La cantidad debe ser un número entero válido.");
                }
            }

            // Validar precio
            double precioP = 0;
            if (string.IsNullOrWhiteSpace(precioText))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!double.TryParse(precioText, out precioP))
                {
                    errores.Add("El precio debe ser un número válido.");
                }
            }

            // Mostrar errores en orden
            foreach (string error in errores)
            {
                MessageBox.Show(error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si hubo errores, no continuar
            if (errores.Count > 0)
            {
                return;
            }

            // Si no hay errores pero sí campos vacíos
            if (hayCampoVacio)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo está bien, registrar producto
            this.archivo.AgregarProducto(this.productosCSV, this.encabezado, this.productos, codigoP, nombreP, categoriaP, cantidadP, precioP);

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.productos;

            this.LimpiarCampos();

            this.cmbEditar.DataSource = null;
            this.cmbEditar.DataSource = this.productos;
            this.cmbEditar.DisplayMember = "NombreProducto";
            this.cmbEditar.ValueMember = "CodigoProducto";

            this.cmbEliminar.DataSource = null;
            this.cmbEliminar.DataSource = this.productos;
            this.cmbEliminar.DisplayMember = "NombreProducto";
            this.cmbEliminar.ValueMember = "CodigoProducto";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Guardar Cambios".
        /// Valida los datos del producto editado y actualiza el registro en el archivo CSV.
        /// </summary>
        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Validación: debe seleccionarse un producto
            if (this.cmbEditar.SelectedIndex == -1 || this.cmbEditar.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto válido para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recolección y validación básica de datos
            string codigoP = ((string)this.cmbEditar.SelectedValue).Trim();
            string nombreP = this.txtNombreEditar.Text.Trim();
            string categoriaP = cmbCategorias2.SelectedValue?.ToString().Trim();

            if (string.IsNullOrWhiteSpace(codigoP) ||
                string.IsNullOrWhiteSpace(nombreP) ||
                string.IsNullOrWhiteSpace(categoriaP))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(this.txtCantidadEditar.Text.Trim(), out int cantidadP))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(this.txtPrecioEditar.Text.Trim(), out double precioP))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de aplicar los cambios
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de realizar los cambios?",
                "Editar Producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
            {
                MessageBox.Show("Acción cancelada.");
                return;
            }

            // Aplicar cambios
            try
            {
                this.archivo.ActualizarProducto(this.productosCSV, this.encabezado, this.productos, codigoP, nombreP, categoriaP, cantidadP, precioP);

                // Actualizar interfaz
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = this.productos;

                // Limpiar campos
                this.txtNombreEditar.Clear();
                this.txtCantidadEditar.Clear();
                this.txtPrecioEditar.Clear();
                this.cmbCategorias2.SelectedIndex = -1;

                MessageBox.Show("Producto actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los cambios:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Eliminar".
        /// Confirma la eliminación del producto seleccionado y actualiza la interfaz.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un producto válido ANTES de preguntar al usuario
            if (this.cmbEliminar.SelectedIndex == -1 || this.cmbEliminar.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de eliminar el producto?",
                "Eliminar Producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
            {
                MessageBox.Show("Acción cancelada.");
                return;
            }

            string codigoP = ((string)this.cmbEliminar.SelectedValue)
                .Trim();

            try
            {
                this.archivo.EliminarProducto(this.productosCSV, this.encabezado, this.productos, codigoP);

                // Actualizar DataGridView con la lista actualizada
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = this.productos;

                // Refrescar ComboBox de editar
                this.cmbEditar.DataSource = null;
                this.cmbEditar.DataSource = this.productos;
                this.cmbEditar.DisplayMember = "NombreProducto";
                this.cmbEditar.ValueMember = "CodigoProducto";

                // Refrescar ComboBox de eliminar
                this.cmbEliminar.DataSource = null;
                this.cmbEliminar.DataSource = this.productos;
                this.cmbEliminar.DisplayMember = "NombreProducto";
                this.cmbEliminar.ValueMember = "CodigoProducto";

                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el producto:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {
        }

        private void CmbEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEditar.SelectedItem is Producto productoSeleccionado)
            {
                this.txtNombreEditar.Text = productoSeleccionado.NombreProducto;
                this.cmbCategorias2.SelectedItem = productoSeleccionado.CategoriaProducto;
                this.txtCantidadEditar.Text = productoSeleccionado.CantidadProducto.ToString();
                this.txtPrecioEditar.Text = productoSeleccionado.PrecioProducto.ToString("F2"); // Formato con 2 decimales, opcional
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // No dispara el FormClosing
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();
        }

        private void FormGestionProductos_Load_1(object sender, EventArgs e)
        {
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            BtnEliminar_Click(sender, e);
        }
    }
}
