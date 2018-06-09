using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Models
{
    public class MockEventoRepositorio: IEventoRepositorio
    {
        public IEnumerable<Eventos>Eventos
        {
            get
            {
                return new List<Eventos>
                {
                    new Eventos {codevento = 1, nomevento = "Venta", desevento = "La Venta de Algun Producto" },
                    new Eventos {codevento = 1, nomevento = "Alquiler", desevento = "Alquiler de los productos" }
                };
            }
        }
    }
}
