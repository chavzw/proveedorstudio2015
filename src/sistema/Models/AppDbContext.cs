using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sistema.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
           
        }//fin del constructor

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Eventos>Eventos { get; set; }
    }
}
