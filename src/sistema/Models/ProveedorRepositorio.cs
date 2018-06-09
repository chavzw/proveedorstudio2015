using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //operaciones de conexiones

namespace sistema.Models
{
    public class ProveedorRepositorio: IProveedorRepositorio
    {
        private readonly AppDbContext _appDbContext;

        //metodo contructor
        public ProveedorRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Proveedor> Proveedores => _appDbContext.Proveedores;
    }
}
