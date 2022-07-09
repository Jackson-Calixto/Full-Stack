using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.API.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        public string Nome { get; set; }
        public int QtdAssentos { get; set; }
    }
}