using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Cinema.API.Data;
using Cinema.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cinema.API.Controllers
{
    [Route("[controller]")]
    public class SalaController : Controller
    {
        private readonly DataContext _context;
        public SalaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Sala> Get(){
            return _context.Salas;
        }
    }
}