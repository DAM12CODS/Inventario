// <copyright file="Producto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Inventario
{
    using Capa_Entidad;

    /// <summary>
    /// Es el objeto producto que se genera en base a un contrato llamado IProducto.
    /// </summary>
    public class Producto : IProducto
    {
        // Atributos privados que almacenan la información del producto
        private string codigoProducto;
        private string nombreProducto;
        private string categoriaProducto;
        private int cantidadProducto;
        private double precioProducto;

        /// <summary>
        /// Initializes a new instance of the <see cref="Producto"/> class.
        /// Inicializa una nueva instancia de la clase <see cref="Producto"/>.
        /// </summary>
        /// <param name="codigoProducto">Código único del producto.</param>
        /// <param name="nombreProducto">Nombre descriptivo del producto.</param>
        /// <param name="categoriaProducto">Categoría a la que pertenece el producto.</param>
        /// <param name="cantidadProducto">Cantidad disponible en inventario.</param>
        /// <param name="precioProducto">Precio unitario del producto.</param>
        /// <exception cref="ArgumentNullException">Se lanza si <paramref name="codigoProducto"/> es nulo.</exception>
        public Producto(
            string codigoProducto,
            string nombreProducto,
            string categoriaProducto,
            int cantidadProducto,
            double precioProducto)
        {
            this.codigoProducto = codigoProducto ?? throw new ArgumentNullException(nameof(codigoProducto));
            this.nombreProducto = nombreProducto;
            this.categoriaProducto = categoriaProducto;
            this.cantidadProducto = cantidadProducto;
            this.precioProducto = precioProducto;
        }

        // Validaciones

        // Propiedad para el código del producto con validación

        /// <summary>Gets or sets codigo del producto.</summary>
        public string CodigoProducto
        {
            get
            {
                return this.codigoProducto;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Debe existir un número de código...");
                }

                this.codigoProducto = value;
            }
        }

        // Propiedad para el nombre del producto con validación

        /// <summary>Gets or sets nombre del producto.</summary>
        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El nombre del producto no puede estar vacío.");
                }

                this.nombreProducto = value;
            }
        }

        // Propiedad para la categoría del producto (sin validación)

        /// <summary>Gets or sets nombre del producto.</summary>
        public string CategoriaProducto
        {
            get
            {
                return this.categoriaProducto;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La categoría del producto no puede estar vacía.");
                }

                this.categoriaProducto = value;
            }
        }

        // Propiedad para la cantidad del producto con validación

        /// <summary>Gets or sets nombre del producto.</summary>
        public int CantidadProducto
        {
            get
            {
                return this.cantidadProducto;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La cantidad debe ser mayor que cero.");
                }

                this.cantidadProducto = value;
            }
        }

        // Propiedad para el precio del producto con validación

        /// <summary>Gets or sets nombre del producto.</summary>
        public double PrecioProducto
        {
            get
            {
                return this.precioProducto;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El precio debe ser mayor que cero.");
                }

                this.precioProducto = value;
            }
        }
    }
}// Se agrego los getters y setters de los atributos
