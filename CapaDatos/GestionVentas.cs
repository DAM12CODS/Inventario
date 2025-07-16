// <copyright file="GestionVentas.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Capa_Entidad;
    using Datos;
    using Inventario;

    /// <summary>
    /// Clase para la gestión de ventas.
    /// </summary>
    public class GestionVentas
    {
        private readonly string ventasFilePath;
        private readonly string detallesFilePath;
        private readonly GestionDatos gestionDatos;

        /// <summary>
        /// Initializes a new instance of the <see cref="GestionVentas"/> class.
        /// Inicializa una nueva instancia de la clase <see cref="GestionVentas"/>.
        /// </summary>
        /// <param name="ventasFilePath">Ruta del archivo de ventas.</param>
        /// <param name="detallesFilePath">Ruta del archivo de detalles de ventas.</param>
        public GestionVentas(string ventasFilePath, string detallesFilePath)
        {
            this.ventasFilePath = ventasFilePath;
            this.detallesFilePath = detallesFilePath;
            this.gestionDatos = new GestionDatos();
        }

        /// <summary>
        /// Carga las ventas y sus detalles desde los archivos CSV.
        /// </summary>
        /// <param name="productosDisponibles">Lista de productos disponibles para vincular a los detalles.</param>
        /// <returns>Lista de ventas cargadas.</returns>
        /// <exception cref="Exception">Lanza una excepción si ocurre un error durante la carga.</exception>
        public List<Venta> CargarVentas(List<Producto> productosDisponibles)
        {
            var ventas = new List<Venta>();
            var detalles = new List<DetalleVenta>();

            try
            {
                if (File.Exists(this.ventasFilePath))
                {
                    using (var reader = new StreamReader(this.ventasFilePath))
                    {
                        reader.ReadLine(); // Saltar encabezado
                        string? linea;
                        while ((linea = reader.ReadLine()) != null)
                        {
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
                }

                if (File.Exists(this.detallesFilePath))
                {
                    using (var reader = new StreamReader(this.detallesFilePath))
                    {
                        reader.ReadLine(); // Saltar encabezado
                        string? linea;
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
                                    var venta = ventas.FirstOrDefault(v => v.IdVenta == datos[4]);
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

        /// <summary>
        /// Registra una nueva venta en los archivos CSV.
        /// </summary>
        /// <param name="venta">Venta a registrar.</param>
        /// <exception cref="Exception">Lanza una excepción si no se puede guardar.</exception>
        public void RegistrarVenta(Venta venta)
        {
            try
            {
                using (var writer = new StreamWriter(this.ventasFilePath, true))
                {
                    if (new FileInfo(this.ventasFilePath).Length == 0)
                    {
                        writer.WriteLine("ID;Fecha");
                    }

                    writer.WriteLine($"{venta.IdVenta};{venta.FechaVenta:yyyy-MM-dd}");
                }

                using (var writer = new StreamWriter(this.detallesFilePath, true))
                {
                    if (new FileInfo(this.detallesFilePath).Length == 0)
                    {
                        writer.WriteLine("ProductoCodigo;Cantidad;PrecioUnitario;Subtotal;VentaID");
                    }

                    foreach (var detalle in venta.Detalles)
                    {
                        writer.WriteLine(
                            $"{detalle.Producto.CodigoProducto};" +
                            $"{detalle.Cantidad};" +
                            $"{detalle.PrecioUnitario};" +
                            $"{detalle.Subtotal};" +
                            $"{venta.IdVenta}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar venta: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina una venta identificada por su ID.
        /// </summary>
        /// <param name="idVenta">ID de la venta a eliminar.</param>
        /// <param name="ventas">Lista actual de ventas.</param>
        public void EliminarVenta(string idVenta, List<Venta> ventas)
        {
            var venta = ventas.FirstOrDefault(v => v.IdVenta == idVenta);
            if (venta != null)
            {
                ventas.Remove(venta);
                this.ReescribirArchivos(ventas);
            }
        }

        /// <summary>
        /// Reescribe completamente los archivos CSV de ventas y detalles.
        /// </summary>
        /// <param name="ventas">Lista actualizada de ventas.</param>
        private void ReescribirArchivos(List<Venta> ventas)
        {
            File.WriteAllText(this.ventasFilePath, "ID;Fecha\n");
            foreach (var venta in ventas)
            {
                File.AppendAllText(this.ventasFilePath, $"{venta.IdVenta};{venta.FechaVenta:yyyy-MM-dd}\n");
            }

            File.WriteAllText(this.detallesFilePath, "ProductoCodigo;Cantidad;PrecioUnitario;Subtotal;VentaID\n");
            foreach (var venta in ventas)
            {
                foreach (var detalle in venta.Detalles)
                {
                    File.AppendAllText(this.detallesFilePath, $"{detalle.Producto.CodigoProducto};{detalle.Cantidad};{detalle.PrecioUnitario};{detalle.Subtotal};{venta.IdVenta}\n");
                }
            }
        }
    }
}
