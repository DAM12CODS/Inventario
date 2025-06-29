using Capa_Entidad;

namespace Inventario
{
  
    // Clase Producto que implementa la interfaz IProducto
    public class Producto : IProducto
    {
        // Atributos privados que almacenan la información del producto
        private string _codigoProducto;
        private string _nombreProducto;
        private string _categoriaProducto;
        //private bool _estadoProducto;
        private int _cantidadProducto;
        private double _precioProducto;

        // Constructor que inicializa todos los atributos del producto
        public Producto(string codigoProducto, string nombreProducto, string categoriaProducto, int cantidadProducto, double precioProducto)
        {

            // Se asignan los valores mediante las propiedades (para aplicar validaciones)

            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            CategoriaProducto = categoriaProducto;
            //EstadoProducto = estadoProducto;
            CantidadProducto = cantidadProducto;
            PrecioProducto = precioProducto;
        }




        //Validaciones

        // Propiedad para el código del producto con validación
 
        public string CodigoProducto
        {
            get { return _codigoProducto; }
            set
            {
                // Validación: el código no puede estar vacío o en blanco
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Debe existir un número de código...");
                }
                _codigoProducto = value;
            }
        }

        // Propiedad para el nombre del producto con validación
        public string NombreProducto
        {
            get { return _nombreProducto; }
            set
            {
                // Validación: el nombre no puede estar vacío
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El nombre del producto no puede estar vacío.");
                }
                _nombreProducto = value;
            }
        }

        // Propiedad para la categoría del producto (sin validación)
        public string CategoriaProducto
        {
            get { return _categoriaProducto; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La categoría del producto no puede estar vacía.");
                }
                _categoriaProducto = value;
            }

      

        }

        // Propiedad para el estado del producto (activo o inactivo)
       /* public bool EstadoProducto
        {
            get { return _estadoProducto; }
            set { _estadoProducto = value; }
        }
       */

        // Propiedad para la cantidad del producto con validación
        public int CantidadProducto
        {
            get { return _cantidadProducto; }
            set
            {
                // Validación: la cantidad debe ser mayor que cero
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La cantidad debe ser mayor que cero.");
                }
                _cantidadProducto = value;
            }
        }

        // Propiedad para el precio del producto con validación
        public double PrecioProducto
        {
            get { return _precioProducto; }
            set
            {
                // Validación: el precio debe ser mayor que cero
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El precio debe ser mayor que cero.");
                }
                _precioProducto = value;
            }
        }
    }
        
}//Se agrego los getters y setters de los atributos 






