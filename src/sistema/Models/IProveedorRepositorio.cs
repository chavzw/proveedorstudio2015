using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Models
{
    public interface IProveedorRepositorio
    {
        IEnumerable<Proveedor> Proveedores { get; }
    }
}
