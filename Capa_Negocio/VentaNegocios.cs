// <copyright file="VentaNegocios.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CapaNegocios
{
    using System;
    using Capa_Entidad;
    using CapaDatos;
    using Inventario;

    /// <summary>
    /// Representa el area donde se gestiona las ventas haciendo uso de la capa de datos.
    /// </summary>
    public class VentaNegocios
    {
        /// <summary>
        /// Registra una venta, actualizando el stock de productos y sobrescribiendo el archivo CSV.
        /// </summary>
        /// <param name="venta">La venta que se desea registrar.</param>
        /// <param name="archivoProductosCSV">Ruta al archivo CSV que contiene los productos.</param>
        /// <param name="encabezadoCSV">Encabezado del archivo CSV.</param>
        /// <param name="productos">Lista de productos disponibles.</param>
        /// <exception cref="ArgumentNullException">Se lanza si <paramref name="venta"/> es nulo.</exception>
        /// <exception cref="InvalidOperationException">
        /// Se lanza si la venta no contiene productos o si no hay suficiente stock para algún producto.
        /// </exception>
        public void RegistrarVenta(Venta venta, string archivoProductosCSV, string encabezadoCSV, List<Producto> productos)
        {
            if (venta == null)
            {
                throw new ArgumentNullException(nameof(venta));
            }

            if (venta.Detalles == null || !venta.Detalles.Any())
            {
                throw new InvalidOperationException("La venta no contiene productos.");
            }

            foreach (var detalle in venta.Detalles)
            {
                Producto producto = detalle.Producto ?? throw new InvalidOperationException("Producto no asignado");

                if (producto.CantidadProducto < detalle.Cantidad)
                {
                    throw new InvalidOperationException($"No hay suficiente stock para el producto {producto.NombreProducto}");
                }

                // Descontar stock
                producto.CantidadProducto -= detalle.Cantidad;
            }

            // Guardar cambios en archivo CSV (Excel)
            Datos.GestionProducto gestor = new Datos.GestionProducto();

            string tempFile = Path.GetTempFileName();
            gestor.ReescribirArchivo(tempFile, archivoProductosCSV, encabezadoCSV, productos);
        }
    }
}
