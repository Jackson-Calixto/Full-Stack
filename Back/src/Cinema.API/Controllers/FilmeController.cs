using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.API.Data;
using Cinema.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly DataContext _context;
        public FilmeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return _context.Filmes;
        }

        [HttpGet("{id}")]
        public IEnumerable<Filme> GetById(int id){
            return _context.Filmes.Where(f => f.FilmeId == id);
        }
    }
}
