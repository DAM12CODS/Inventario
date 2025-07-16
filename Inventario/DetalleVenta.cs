// <copyright file="DetalleVenta.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Entidad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Inventario;

    /// <summary>
    /// Representa el detalle de un producto vendido en una venta.
    /// </summary>
    public class DetalleVenta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalleVenta"/> class.
        /// Inicializa una nueva instancia de la clase DetalleVenta.
        /// </summary>
        /// <param name="producto">Producto vendido.</param>
        /// <param name="cantidad">Cantidad vendida.</param>
        public DetalleVenta(Producto producto, int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor a cero.");
            }

            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto));
            }

            this.Producto = producto;
            this.Cantidad = cantidad;
        }

        /// <summary>Gets or sets producto asociado a la venta.</summary>
        public Producto Producto { get; set; }

        /// <summary>Gets or sets cantidad de unidades vendidas.</summary>
        public int Cantidad { get; set; }

        /// <summary>Gets precio unitario del producto.</summary>
        public double PrecioUnitario => this.Producto.PrecioProducto;

        /// <summary>Gets subtotal calculado (cantidad * precio).</summary>
        public double Subtotal => this.Cantidad * this.PrecioUnitario;
    }
}
