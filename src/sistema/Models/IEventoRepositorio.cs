using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Models
{
    public interface IEventoRepositorio
    {
        IEnumerable<Eventos> Eventos { get; }
    }
}
