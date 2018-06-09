using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Models;

namespace sistema.Viewmodels
{
    public class ListaProveedorViewModel
    {
        public IEnumerable<Proveedor> Proveedor { get; set; }
        public string proveedores { get; set; }

    }
}
