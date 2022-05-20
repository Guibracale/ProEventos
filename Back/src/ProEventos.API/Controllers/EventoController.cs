using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() { 
                    EventoId = 1,
                    Tema = "Dotnet 5 e Angular",
                    Local = "Curitiba",
                    Lote = "Primeiro Lote",
                    QtdPessoas = 20,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "Image.png"
                },

                new Evento() { 
                    EventoId = 2,
                    Tema = "Python e Angular",
                    Local = "Campinas",
                    Lote = "Segundo Lote",
                    QtdPessoas = 25,
                    DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                    ImagemURL = "Image1.png"
                }
            };

        public EventoController()
        {   
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

          [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId ==id);
        }

          [HttpPost]
        public string Post()
        {
            return "value1";
        }

          [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"value2 com id = {id}";
        }

           [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"value3 com id = {id}";
        }
    }
}
