using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public interface IProducto // Interfaz respecto de los productos 
    {
        string CodigoProducto { get; set; }
        string NombreProducto { get; set; }
        string CategoriaProducto { get; set; }
        bool EstadoProducto { get; set; }
        int CantidadProducto { get; set; }
        double PrecioProducto { get; set; }
    }

}
