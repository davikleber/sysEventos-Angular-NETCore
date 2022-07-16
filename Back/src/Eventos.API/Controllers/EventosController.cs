using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Eventos.API.Models;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento(){

                EventoId = 1,
                Tema = "Angular .NET 5 EF",
                Local = "Fortaleza",
                Lote = "Lote 1°",
                QntPessoa = 5663,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto1.png"
            },

             new Evento(){

                EventoId = 2,
                Tema = "EntityframeWork Core",
                Local = "Recife",
                Lote = "Lote 2°",
                QntPessoa = 78963,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto2.png"
            }            

           };
         
        public EventosController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
           
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByid(int id)
        {
           return _evento.Where(evento=>evento.EventoId == id);;
           
        }

        
    }
}
