using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sistema.Models
{
    public class Proveedor
    {
        [Key]

        public int codproveedor { get; set; }
        public string nomproveedor { get; set; }
        public string desproveedor { get; set; }
        }
    }


    