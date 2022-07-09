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
    public class SessaoController : Controller
    {
        private readonly DataContext _context;
        public SessaoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Sessao> Get(){
            return _context.Sessoes;
        }
    }
}