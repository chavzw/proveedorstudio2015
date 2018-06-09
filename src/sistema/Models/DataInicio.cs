using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace sistema.Models
{
    public static class DataInicio
    {

        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

           
            if (!contexto.Proveedores.Any())
            {
                contexto.AddRange
                (
                    new Proveedor { nomproveedor = "Dell", desproveedor = "Ventas de Pc" },
                    new Proveedor { nomproveedor = "Asus", desproveedor = "Venta de CPU" },
                    new Proveedor { nomproveedor = "Baio", desproveedor = "Venta de Memorias Ram" },
                    new Proveedor { nomproveedor = "HP", desproveedor = "Venta de Discos Duro" },
                    new Proveedor { nomproveedor = "Core", desproveedor = "Venta de Ventiladores" }
                );
            }
            contexto.SaveChanges();
        }//fin de agregarData

    }
    }
