// <copyright file="IProducto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Entidad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Representa la interfaz a seguir por cada producto que se genere.
    /// </summary>
    public interface IProducto // Interfaz respecto de los productos.
    {
        /// <summary>Gets or sets marca atributo a tener cada producto.</summary>
        string CodigoProducto { get; set; }

        /// <summary>Gets or sets marca atributo a tener cada producto.</summary>
        string NombreProducto { get; set; }

        /// <summary>Gets or sets marca atributo a tener cada producto.</summary>
        string CategoriaProducto { get; set; }

        /// <summary>Gets or sets marca atributo a tener cada producto.</summary>
        int CantidadProducto { get; set; }

        /// <summary>Gets or sets marca atributo a tener cada producto.</summary>
        double PrecioProducto { get; set; }
    }
}
