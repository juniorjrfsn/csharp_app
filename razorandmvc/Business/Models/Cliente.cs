using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Cliente
    {
        public string Idade { get; set; }
        public string Cpf { get; set; }

        public string ExceptionError { get; set;}

        public Endereco endereco { get; set; }
    }
}
