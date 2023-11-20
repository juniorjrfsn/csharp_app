using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Produto
    {
        public int Pid { get; set; }

        public string Pnome { get; set; }

        public string Descricao { get; set; }

        public string Ppeso { get; set; }

        public string largura { get; set; }

        public string Comprimento { get; set; }

        public string Altura { get; set; }

        public string Preco { get; set; }
    }
}
