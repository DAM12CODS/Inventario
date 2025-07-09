using Capa_Entidad;
using CapaDatos;
using Datos;
using Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FormGestionVentas : Form
    {
        // Variables de clase
        private FormMenuPrincipal formAnterior;
        private List<Venta> ventas = new List<Venta>();
        private List<Producto> productosDisponibles = new List<Producto>();
        private List<DetalleVenta> detallesTemporales = new List<DetalleVenta>();
        private GestionVentas gestionVentas = new GestionVentas("ventas.csv", "detalles_ventas.csv");
        private GestionProducto gestionProducto = new GestionProducto();
        
        private string productosCSV = "productos.csv";
        private string encabezado = "Codigo;Nombre;Categoria;Cantidad;Precio";
        public FormGestionVentas(FormMenuPrincipal anterior)
        {
            InitializeComponent();
            this.formAnterior = anterior;
            ConfigurarInterfaz();

            var gestor = new GestionProducto();
            gestor.CargarProductos(productosCSV, encabezado, productosDisponibles);

        }

        private void ConfigurarInterfaz()
        {
            // Establecer títulos y etiquetas según el diseño
            label1.Text = "Registrar Venta:";
            label4.Text = "Eliminar Venta:";
            label5.Text = "Generar Reporte Venta:";
            label8.Text = "Productos Venta:";
            label9.Text = "Ventas Existentes:";

            // Configurar DataGridViews
            ConfigurarDataGridProductos();
            ConfigurarDataGridVentas();
        }

        private void ConfigurarDataGridProductos()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Codigo", "Código");
            dataGridView1.Columns.Add("Categoria", "Categoría");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
        }

        private void ConfigurarDataGridVentas()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("IdVenta", "IdVenta");
            dataGridView2.Columns.Add("Productos", "Productos");
            dataGridView2.Columns.Add("Cantidad", "Cantidad");
            dataGridView2.Columns.Add("PrecioTotal", "Precio Total");
        }

        private void FormGestionVentas_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            try
            {
                // Cargar productos
                gestionProducto.CargarProductos(productosCSV,encabezado, productosDisponibles);
                cmbProductosVenta.DataSource = productosDisponibles;
                cmbProductosVenta.DisplayMember = "NombreProducto";
                cmbProductosVenta.ValueMember = "CodigoProducto";

                // Cargar ventas existentes
                ventas = gestionVentas.CargarVentas(productosDisponibles);
                ActualizarListaVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaVentas()
        {
            cmbEliminarVenta.DataSource = ventas.ToList();
            cmbEliminarVenta.DisplayMember = "IdVenta";
            cmbVentaReporte.DataSource = ventas.ToList();
            cmbVentaReporte.DisplayMember = "IdVenta";

            ActualizarDataGridVentas();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductosVenta.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidadProducto.Text))
            {
                MessageBox.Show("Seleccione un producto y especifique la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var producto = (Producto)cmbProductosVenta.SelectedItem;
                int cantidad = int.Parse(txtCantidadProducto.Text);

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (producto.CantidadProducto < cantidad)
                {
                    MessageBox.Show("No hay suficiente stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var detalle = new DetalleVenta(producto, cantidad);
                detallesTemporales.Add(detalle);

                // Actualizar DataGrid
                dataGridView1.Rows.Add(
                    producto.NombreProducto,
                    producto.CodigoProducto,
                    producto.CategoriaProducto,
                    producto.PrecioProducto.ToString("C")
                );

                // Limpiar controles
                txtCantidadProducto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (detallesTemporales.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string idVenta = "V" + (ventas.Count + 1).ToString("D3");
                var nuevaVenta = new Venta(idVenta, DateTime.Now);

                foreach (var detalle in detallesTemporales)
                {
                    nuevaVenta.AgregarDetalle(detalle);
                    // Actualizar stock
                    detalle.Producto.CantidadProducto -= detalle.Cantidad;
                }

                gestionVentas.RegistrarVenta(nuevaVenta);
                ventas.Add(nuevaVenta);

                // Actualizar interfaz
                detallesTemporales.Clear();
                dataGridView1.Rows.Clear();
                ActualizarListaVentas();

                MessageBox.Show("Venta registrada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (cmbEliminarVenta.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una venta para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var venta = (Venta)cmbEliminarVenta.SelectedItem;
                gestionVentas.EliminarVenta(venta.IdVenta, ventas);
                ActualizarListaVentas();
                MessageBox.Show("Venta eliminada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cmbVentaReporte.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una venta para generar el reporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var venta = (Venta)cmbVentaReporte.SelectedItem;
                string reporte = GenerarReporteVenta(venta);
                MessageBox.Show(reporte, $"Reporte de Venta {venta.IdVenta}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridView2.Rows.Clear();
            foreach (var venta in ventas)
            {
                string productos = string.Join(", ", venta.Detalles.Select(d => $"{d.Producto.NombreProducto} x{d.Cantidad}"));
                dataGridView2.Rows.Add(
                    venta.IdVenta,
                    productos,
                    venta.Detalles.Sum(d => d.Cantidad),
                    venta.Total.ToString("C")
                );
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            formAnterior.Show();
        }

        private void cmbProductosVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEliminarVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbVentaReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}