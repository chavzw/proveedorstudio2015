using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Models;

namespace sistema.Viewmodels
{
    public class ListaEventoViewModel
    {
        public IEnumerable<Eventos> Eventos { get; set; }
        public string eventoos { get; set; }
    }
}
