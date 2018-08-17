using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjPages.Models
{
    public class Alunos
    {
        public int id { get; set; }
        public string nome { get; set; }

        public DateTime cadastro { get; set; }

        public bool aprovado { get; set; }

    }
}
