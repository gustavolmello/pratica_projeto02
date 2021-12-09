using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto02.Entities
{
    public class Dependente
    {
        //prop + 2x[tab]
        public Guid IdDependente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
