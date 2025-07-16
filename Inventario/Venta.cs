// <copyright file="Venta.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Entidad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Clase que representa una venta realizada

    /// <summary>
    /// Representa los atributos y metodos que tendra venta.
    /// </summary>
    public class Venta
    {
        // Constructor que inicializa la venta con su ID y fecha

        /// <summary>
        /// Initializes a new instance of the <see cref="Venta"/> class.
        /// </summary>
        /// <param name="idVenta"> Indica el identificador de la venta.</param>
        /// <param name="fecha">Indica el momento de la creacion de la venta para generar un reporte.</param>
        public Venta(
            string idVenta,
            DateTime fecha)
        {
            // Validación: el ID de la venta no puede estar vacío o contener solo espacios
            if (string.IsNullOrWhiteSpace(idVenta))
            {
                throw new ArgumentException("El ID no puede estar vacío.");
            }

            this.IdVenta = idVenta;
            this.FechaVenta = fecha;
        }

        // Identificador único de la venta

        /// <summary>Gets or sets producto asociado a la venta.</summary>
        public string IdVenta { get; set; }

        // Fecha en que se realizó la venta

        /// <summary>Gets or sets producto asociado a la venta.</summary>
        public DateTime FechaVenta { get; set; }

        // Lista de todos los detalles (productos o servicios) asociados a la venta

        /// <summary>Gets or sets producto asociado a la venta.</summary>
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        // Propiedad calculada que devuelve la suma de los subtotales de todos los detalles

        /// <summary>Gets producto asociado a la venta.</summary>
        public double Subtotal => this.Detalles.Sum(d => d.Subtotal);

        // Propiedad calculada que aplica el impuesto (IVA del 12%) al subtotal

        /// <summary>Gets producto asociado a la venta.</summary>
        public double Impuesto => this.Subtotal * 0.12;

        // Propiedad calculada que representa el valor total de la venta (subtotal + impuesto)

        /// <summary>Gets producto asociado a la venta.</summary>
        public double Total => this.Subtotal + this.Impuesto;

        // Método para agregar un detalle (producto o servicio) a la venta

        /// <summary>
        /// Agrega un detalle de producto a la venta.
        /// </summary>
        /// <param name="detalle">El detalle de la venta que se va a agregar.</param>
        /// <exception cref="ArgumentNullException">Se lanza si <paramref name="detalle"/> es nulo.</exception>
        public void AgregarDetalle(DetalleVenta detalle)
        {
            if (detalle == null)
            {
                throw new ArgumentNullException(nameof(detalle));
            }

            this.Detalles.Add(detalle);
        }
    }
}
