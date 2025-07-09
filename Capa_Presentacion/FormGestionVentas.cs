using Capa_Entidad;
using CapaDatos;
using Datos;
using Inventario;
using CapaNegocios; 
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

            productosDisponibles.Clear();
            gestionProducto.CargarProductos(productosCSV, encabezado, productosDisponibles);

            cmbProductosVenta.DataSource = productosDisponibles;
            cmbProductosVenta.DisplayMember = "NombreProducto";
            cmbProductosVenta.ValueMember = "CodigoProducto";
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
            dataGridView1.AllowUserToAddRows = false; 
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Codigo", "Código");
            dataGridView1.Columns.Add("Categoria", "Categoría");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
        }


        private void ConfigurarDataGridVentas()
        {
            dataGridView2.AllowUserToAddRows = false; 
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
                productosDisponibles.Clear(); // Limpia antes de cargar
                gestionProducto.CargarProductos(productosCSV, encabezado, productosDisponibles);

                cmbProductosVenta.DataSource = null;
                cmbProductosVenta.DataSource = productosDisponibles;
                cmbProductosVenta.DisplayMember = "NombreProducto";
                cmbProductosVenta.ValueMember = "CodigoProducto";
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
            try
            {
                string textoCantidad = txtCantidadProducto.Text.Trim();

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

                if (cmbProductosVenta.SelectedItem is not Producto producto)
                {
                    MessageBox.Show("Seleccione un producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cantidad > producto.CantidadProducto)
                {
                    MessageBox.Show("No hay suficiente stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (detallesTemporales.Any(d => d.Producto.CodigoProducto == producto.CodigoProducto))
                {
                    MessageBox.Show("Este producto ya fue agregado a la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear detalle y agregarlo a la lista y al DataGridView
                var detalle = new DetalleVenta(producto, cantidad);
                detallesTemporales.Add(detalle);

                dataGridView1.Rows.Add(
                    producto.NombreProducto,
                    producto.CodigoProducto,
                    producto.CategoriaProducto,
                    producto.PrecioProducto.ToString("C"),
                    cantidad
                );

                txtCantidadProducto.Clear();
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
                    if (detalle.Cantidad <= 0)
                    {
                        MessageBox.Show($"El producto {detalle.Producto.NombreProducto} tiene cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nuevaVenta.AgregarDetalle(detalle);
                }


                VentaNegocios negocio = new VentaNegocios();
                negocio.RegistrarVenta(nuevaVenta, productosCSV, encabezado, productosDisponibles);
                gestionVentas.RegistrarVenta(nuevaVenta);

                ventas.Add(nuevaVenta);

                // Actualizar interfaz
                detallesTemporales.Clear();
                dataGridView1.Rows.Clear();
                ActualizarListaVentas();

                dataGridView1.Rows.Clear(); // Limpia productos agregados temporalmente
                ActualizarListaVentas();    // Refresca ventas registradas
            

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

                //  Devolver stock a productos
                foreach (var detalle in venta.Detalles)
                {
                    var producto = productosDisponibles.FirstOrDefault(p => p.CodigoProducto == detalle.Producto.CodigoProducto);
                    if (producto != null)
                    {
                        producto.CantidadProducto += detalle.Cantidad; // Se devuelve el stock
                    }
                }

                // Actualizar archivo productos.csv
                gestionProducto.ReescribirArchivo(Path.GetTempFileName(), productosCSV, encabezado, productosDisponibles);

                // Eliminar venta del archivo
                gestionVentas.EliminarVenta(venta.IdVenta, ventas);

                // Actualizar UI
                ActualizarListaVentas();

                MessageBox.Show("Venta eliminada y stock restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // Mostrar y guardar
                DialogResult opcion = MessageBox.Show(reporte + "\n\n¿Desea guardar este reporte como archivo?",
                                                      $"Reporte de Venta {venta.IdVenta}",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    GuardarReporteEnArchivo(reporte, venta.IdVenta);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}