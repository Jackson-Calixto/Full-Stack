using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.API.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime Data { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set; }
        public double ValorIngresso { get; set; }
        public string Animacao { get; set; }
        public string Audio { get; set; }
        public int FilmeId { get; set; }
        public int SalaId { get; set; }
    }
}