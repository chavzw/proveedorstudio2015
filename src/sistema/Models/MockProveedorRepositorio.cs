using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Models
{
    public class MockProveedorRepositorio: IProveedorRepositorio
    {
        public IEnumerable<Proveedor> Proveedores
        {
            get
            {
                return new List<Proveedor>
                {
                    new Proveedor {codproveedor = 1, nomproveedor = "ASUS", desproveedor = "Venta de cpu" },
                    new Proveedor {codproveedor = 2, nomproveedor = "ACER", desproveedor = "Venta de CPU" }

                };
            }
        }
    }
}
