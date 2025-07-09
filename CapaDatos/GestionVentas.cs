using Capa_Entidad;
using Datos;
using Inventario;
using System;
using System.Collections.Generic;
using System.IO;

namespace CapaDatos
{
    public class GestionVentas
    {
        private readonly string _ventasFilePath;
        private readonly string _detallesFilePath;
        private readonly GestionDatos _gestionDatos;

        public GestionVentas(string ventasFilePath, string detallesFilePath)
        {
            _ventasFilePath = ventasFilePath;
            _detallesFilePath = detallesFilePath;
            _gestionDatos = new GestionDatos();
        }

        // Cargar todas las ventas y sus detalles desde archivos
        public List<Venta> CargarVentas(List<Producto> productosDisponibles)
        {
            var ventas = new List<Venta>();
            var detalles = new List<DetalleVenta>();

            try
            {
                // Cargar ventas principales
                if (File.Exists(_ventasFilePath))
                {
                    using (var reader = new StreamReader(_ventasFilePath))
                    {
                        reader.ReadLine(); // Saltar encabezado
                        string linea;
                        while ((linea = reader.ReadLine()) != null)
                        {
                            var datos = linea.Split(';');
                            if (datos.Length >= 2)
                            {
                                var venta = new Venta(datos[0], DateTime.Parse(datos[1]));
                                ventas.Add(venta);
                            }
                        }
                    }
                }

                // Cargar detalles de ventas
                if (File.Exists(_detallesFilePath))
                {
                    using (var reader = new StreamReader(_detallesFilePath))
                    {
                        reader.ReadLine(); // Saltar encabezado
                        string linea;
                        while ((linea = reader.ReadLine()) != null)
                        {
                            var datos = linea.Split(';');
                            if (datos.Length >= 4)
                            {
                                var producto = productosDisponibles.FirstOrDefault(p => p.CodigoProducto == datos[0]);
                                if (producto != null)
                                {
                                    var detalle = new DetalleVenta(producto, int.Parse(datos[1]));
                                    detalles.Add(detalle);
                                    // Asociar detalle a la venta correspondiente
                                    var venta = ventas.FirstOrDefault(v => v.IdVenta == datos[3]);
                                    venta?.AgregarDetalle(detalle);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar ventas: " + ex.Message);
            }

            return ventas;
        }

        // Registrar una nueva venta (guarda en archivos)
        public void RegistrarVenta(Venta venta)
        {
            try
            {
                // Guardar venta en archivo principal
                using (var writer = new StreamWriter(_ventasFilePath, true))
                {
                    if (new FileInfo(_ventasFilePath).Length == 0)
                        writer.WriteLine("ID;Fecha"); // Encabezado si el archivo está vacío

                    writer.WriteLine($"{venta.IdVenta};{venta.FechaVenta:yyyy-MM-dd}");
                }

                // Guardar detalles en archivo secundario
                using (var writer = new StreamWriter(_detallesFilePath, true))
                {
                    if (new FileInfo(_detallesFilePath).Length == 0)
                        writer.WriteLine("ProductoCodigo;Cantidad;PrecioUnitario;Subtotal;VentaID");

                    foreach (var detalle in venta.Detalles)
                    {
                        writer.WriteLine(
                            $"{detalle.Producto.CodigoProducto};" +
                            $"{detalle.Cantidad};" +
                            $"{detalle.PrecioUnitario};" +
                            $"{detalle.Subtotal};" +
                            $"{venta.IdVenta}"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar venta: " + ex.Message);
            }
        }

        // Eliminar venta por ID
        public void EliminarVenta(string idVenta, List<Venta> ventas)
        {
            var venta = ventas.FirstOrDefault(v => v.IdVenta == idVenta);
            if (venta != null)
            {
                ventas.Remove(venta);
                ReescribirArchivos(ventas);
            }
        }

        // Reescribe los archivos CSV completos (para actualizaciones/eliminaciones)
        private void ReescribirArchivos(List<Venta> ventas)
        {
            // Reescribir archivo de ventas
            File.WriteAllText(_ventasFilePath, "ID;Fecha\n");
            foreach (var venta in ventas)
            {
                File.AppendAllText(_ventasFilePath, $"{venta.IdVenta};{venta.FechaVenta:yyyy-MM-dd}\n");
            }

            // Reescribir archivo de detalles
            File.WriteAllText(_detallesFilePath, "ProductoCodigo;Cantidad;PrecioUnitario;Subtotal;VentaID\n");
            foreach (var venta in ventas)
            {
                foreach (var detalle in venta.Detalles)
                {
                    File.AppendAllText(_detallesFilePath,
                        $"{detalle.Producto.CodigoProducto};" +
                        $"{detalle.Cantidad};" +
                        $"{detalle.PrecioUnitario};" +
                        $"{detalle.Subtotal};" +
                        $"{venta.IdVenta}\n"
                    );
                }
            }
        }
    }
}