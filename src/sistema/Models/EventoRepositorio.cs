using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //operaciones de conexiones

namespace sistema.Models
{
    public class EventoRepositio : IEventoRepositorio
    {
        private readonly AppDbContext _appDbContext;

        //metodo contructor
        public EventoRepositio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Eventos> Eventos => _appDbContext.Eventos;
    }
}

