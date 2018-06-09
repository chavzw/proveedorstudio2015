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
    public class EventoController : Controller
    {
        //objetos de solo lectura
        private readonly IEventoRepositorio _eventoRepositorio;

        //contructor de clase controllers

        public EventoController(IEventoRepositorio eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        public ViewResult ListaEvento()
        {
            ListaEventoViewModel listaeventoViewModel = new ListaEventoViewModel();
            listaeventoViewModel.Eventos = _eventoRepositorio.Eventos;
            listaeventoViewModel.eventoos = "eventoos";
            return View(listaeventoViewModel);
        }
    }
}
