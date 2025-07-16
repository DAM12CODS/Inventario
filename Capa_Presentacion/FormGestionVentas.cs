// <copyright file="FormGestionVentas.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Presentacion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Capa_Entidad;
    using CapaDatos;
    using CapaNegocios;
    using Datos;
    using Inventario;

    /// <summary>
    /// Representa el formulario de gestion de venta.
    /// Muestra el area de generacion de venta, reportes y elimacion de la misma ademaas permite volver al menú principal.
    /// </summary>
    public partial class FormGestionVentas : Form
    {
        // Variables de clase
        private List<Venta> ventas = new List<Venta>();
        private List<Producto> productosDisponibles = new List<Producto>();
        private List<DetalleVenta> detallesTemporales = new List<DetalleVenta>();
        private GestionVentas gestionVentas = new GestionVentas("ventas.csv", "detalles_ventas.csv");
        private bool confirmandoCierre = false;
        private GestionProducto gestionProducto = new GestionProducto();

        private string productosCSV = "productos.csv";
        private string encabezado = "Codigo;Nombre;Categoria;Cantidad;Precio";


        /// <summary>
        /// Initializes a new instance of the <see cref="FormGestionVentas"/> class.
        /// </summary>
        public FormGestionVentas()
        {
            InitializeComponent();
            this.FormClosing += FormX_FormClosing; // reemplaza "X" por el nombre del formulario
            this.ConfigurarInterfaz();

            this.productosDisponibles.Clear();
            this.gestionProducto.CargarProductos(this.productosCSV, this.encabezado, this.productosDisponibles);

            this.cmbProductosVenta.DataSource = this.productosDisponibles;
            this.cmbProductosVenta.DisplayMember = "NombreProducto";
            this.cmbProductosVenta.ValueMember = "CodigoProducto";

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


        private void ConfigurarInterfaz()
        {
            // Establecer títulos y etiquetas según el diseño
            this.label4.Text = "Eliminar Venta:";
            this.label8.Text = "Productos Venta:";
            this.label9.Text = "Ventas Existentes:";

            // Configurar DataGridViews
            this.ConfigurarDataGridProductos();
            this.ConfigurarDataGridVentas();
        }

        private void ConfigurarDataGridProductos()
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("Nombre", "Nombre");
            this.dataGridView1.Columns.Add("Codigo", "Código");
            this.dataGridView1.Columns.Add("Categoria", "Categoría");
            this.dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
            this.dataGridView1.Columns.Add("Cantidad", "Cantidad");
        }

        private void ConfigurarDataGridVentas()
        {
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Columns.Clear();
            this.dataGridView2.Columns.Add("IdVenta", "IdVenta");
            this.dataGridView2.Columns.Add("Productos", "Productos");
            this.dataGridView2.Columns.Add("Cantidad", "Cantidad");
            this.dataGridView2.Columns.Add("PrecioTotal", "Precio Total");

            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.Columns.Clear();
            this.dataGridView3.Columns.Add("IdVenta", "IdVenta");
            this.dataGridView3.Columns.Add("Productos", "Productos");
            this.dataGridView3.Columns.Add("Cantidad", "Cantidad");
            this.dataGridView3.Columns.Add("PrecioTotal", "Precio Total");
        }

        private void FormGestionVentas_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            try
            {
                this.productosDisponibles.Clear(); // Limpia antes de cargar
                this.gestionProducto.CargarProductos(this.productosCSV, this.encabezado, this.productosDisponibles);

                this.cmbProductosVenta.DataSource = null;
                this.cmbProductosVenta.DataSource = this.productosDisponibles;
                this.cmbProductosVenta.DisplayMember = "NombreProducto";
                this.cmbProductosVenta.ValueMember = "CodigoProducto";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaVentas()
        {
            this.cmbEliminarVenta.DataSource = this.ventas.ToList();
            this.cmbEliminarVenta.DisplayMember = "IdVenta";
            this.cmbVentaReporte.DataSource = this.ventas.ToList();
            this.cmbVentaReporte.DisplayMember = "IdVenta";

            this.ActualizarDataGridVentas();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string textoCantidad = this.txtCantidadProducto.Text.Trim();

                if (string.IsNullOrWhiteSpace(textoCantidad))
                {
                    MessageBox.Show("Ingrese una cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textoCantidad, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.cmbProductosVenta.SelectedItem is not Producto producto)
                {
                    MessageBox.Show("Seleccione un producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cantidad > producto.CantidadProducto)
                {
                    MessageBox.Show("No hay suficiente stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.detallesTemporales.Any(d => d.Producto.CodigoProducto == producto.CodigoProducto))
                {
                    MessageBox.Show("Este producto ya fue agregado a la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear detalle y agregarlo a la lista y al DataGridView
                var detalle = new DetalleVenta(producto, cantidad);
                this.detallesTemporales.Add(detalle);

                this.dataGridView1.Rows.Add(
                    producto.NombreProducto,
                    producto.CodigoProducto,
                    producto.CategoriaProducto,
                    producto.PrecioProducto.ToString("C"),
                    cantidad);

                this.txtCantidadProducto.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"No se pudo agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (this.detallesTemporales.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string idVenta = "V" + (this.ventas.Count + 1).ToString("D3");
                var nuevaVenta = new Venta(idVenta, DateTime.Now);

                foreach (var detalle in this.detallesTemporales)
                {
                    if (detalle.Cantidad <= 0)
                    {
                        MessageBox.Show($"El producto {detalle.Producto.NombreProducto} tiene cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nuevaVenta.AgregarDetalle(detalle);
                }

                VentaNegocios negocio = new VentaNegocios();
                negocio.RegistrarVenta(nuevaVenta, this.productosCSV, this.encabezado, this.productosDisponibles);
                this.gestionVentas.RegistrarVenta(nuevaVenta);

                this.ventas.Add(nuevaVenta);

                // Actualizar interfaz
                this.detallesTemporales.Clear();
                this.dataGridView1.Rows.Clear();
                this.ActualizarListaVentas();

                this.dataGridView1.Rows.Clear(); // Limpia productos agregados temporalmente
                this.ActualizarListaVentas();    // Refresca ventas registradas

                MessageBox.Show("Venta registrada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (this.cmbEliminarVenta.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una venta para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var venta = (Venta)this.cmbEliminarVenta.SelectedItem;

                // Devolver stock a productos
                foreach (var detalle in venta.Detalles)
                {
                    var producto = this.productosDisponibles.FirstOrDefault(p => p.CodigoProducto == detalle.Producto.CodigoProducto);
                    if (producto != null)
                    {
                        producto.CantidadProducto += detalle.Cantidad; // Se devuelve el stock
                    }
                }

                // Actualizar archivo productos.csv
                this.gestionProducto.ReescribirArchivo(Path.GetTempFileName(), this.productosCSV, this.encabezado, this.productosDisponibles);

                // Eliminar venta del archivo
                this.gestionVentas.EliminarVenta(venta.IdVenta, this.ventas);

                // Actualizar UI
                this.ActualizarListaVentas();

                MessageBox.Show("Venta eliminada y stock restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (this.cmbVentaReporte.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una venta para generar el reporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var venta = (Venta)this.cmbVentaReporte.SelectedItem;
                string reporte = this.GenerarReporteVenta(venta);

                // Mostrar y guardar
                DialogResult opcion = MessageBox.Show(
                    reporte + "\n\n¿Desea guardar este reporte como archivo?",
                    $"Reporte de Venta {venta.IdVenta}",
                    MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    this.GuardarReporteEnArchivo(reporte, venta.IdVenta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarReporteEnArchivo(string reporte, string idVenta)
        {
            try
            {
                string nombreArchivo = $"Reporte_{idVenta}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);
                File.WriteAllText(ruta, reporte);
                MessageBox.Show($"Reporte guardado en:\n{ruta}", "Reporte generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarReporteVenta(Venta venta)
        {
            string reporte = $"=== REPORTE DE VENTA ===\n\n" +
                            $"ID Venta: {venta.IdVenta}\n" +
                            $"Fecha: {venta.FechaVenta:dd/MM/yyyy HH:mm}\n\n" +
                            $"PRODUCTOS:\n";

            foreach (var detalle in venta.Detalles)
            {
                reporte += $"- {detalle.Producto.NombreProducto} ({detalle.Cantidad} x {detalle.PrecioUnitario:C}) = {detalle.Subtotal:C}\n";
            }

            reporte += $"\nSUBTOTAL: {venta.Subtotal:C}\n" +
                      $"IMPUESTO (12%): {venta.Impuesto:C}\n" +
                      $"TOTAL: {venta.Total:C}";

            return reporte;
        }

        private void ActualizarDataGridVentas()
        {
            this.dataGridView2.Rows.Clear();
            this.dataGridView3.Rows.Clear(); // AÑADIDO

            foreach (var venta in this.ventas)
            {
                string productos = string.Join(", ", venta.Detalles.Select(d => $"{d.Producto.NombreProducto} x{d.Cantidad}"));
                string cantidadTotal = venta.Detalles.Sum(d => d.Cantidad).ToString();
                string total = venta.Total.ToString("C");

                // dataGridView2
                this.dataGridView2.Rows.Add(
                    venta.IdVenta,
                    productos,
                    cantidadTotal,
                    total);

                // dataGridView3
                this.dataGridView3.Rows.Add(
                    venta.IdVenta,
                    productos,
                    cantidadTotal,
                    total);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();
        }

        private void CmbProductosVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbProductosVenta.SelectedItem is Producto producto)
            {
                this.lblCodigoProducto.Text = $"{producto.CodigoProducto}";
                this.lblNombreProducto.Text = $"{producto.NombreProducto}";
                this.lblCategoriaProducto.Text = $"{producto.CategoriaProducto}";
                this.lblPrecioProducto.Text = $"{producto.PrecioProducto:C}";
                this.lblStockDisponible.Text = $"{producto.CantidadProducto}";
            }
            else
            {
                this.lblCodigoProducto.Text = "Código:";
                this.lblNombreProducto.Text = "Nombre:";
                this.lblCategoriaProducto.Text = "Categoría:";
                this.lblPrecioProducto.Text = "Precio:";
                this.lblStockDisponible.Text = "Stock Disponible:";
            }
        }

        private void CmbEliminarVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CmbVentaReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Label9_Click(object sender, EventArgs e)
        {
        }

        private void Label8_Click(object sender, EventArgs e)
        {
        }

        private void FormGestionVentas_Load_1(object sender, EventArgs e)
        {

        }
    }
}