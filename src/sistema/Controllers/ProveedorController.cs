using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistema.Models;
using sistema.Viewmodels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace sistema.Controllers
{
    public class ProveedorController : Controller
    {
        //objetos de solo lectura
        private readonly IProveedorRepositorio _proveedorRepositorio;

        //contructor de clase controllers

        public ProveedorController(IProveedorRepositorio proveedorRepositorio)
        {
            _proveedorRepositorio = proveedorRepositorio;
        }

        public ViewResult ListaProveedor()
        {
            ListaProveedorViewModel listaproveedorViewModel = new ListaProveedorViewModel();
            listaproveedorViewModel.Proveedor = _proveedorRepositorio.Proveedores;

            listaproveedorViewModel.proveedores = "Proveedores";
            
            return View(listaproveedorViewModel);
        }
    }
}
