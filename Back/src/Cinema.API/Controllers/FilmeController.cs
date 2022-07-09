using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        public Filme[] filme = {
                new Filme(){
                    FilmeId = 1,
                    Imagem = "Img.png",
                    Titulo = "API",
                    Descricao = "Minha primeira",
                    Duracao = TimeSpan.FromMinutes(148)
                },
                new Filme(){
                    FilmeId = 2,
                    Imagem = "Top.png",
                    Titulo = "Angular",
                    Descricao = "Frontend",
                    Duracao = TimeSpan.FromMinutes(175)
                }};
        private readonly ILogger<FilmeController> _logger;

        public FilmeController(ILogger<FilmeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return filme;
        }

        [HttpGet("{id}")]
        public IEnumerable<Filme> GetById(int id){
            return filme.Where(f => f.FilmeId == id);
        }
    }
}
