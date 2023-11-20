using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Encomenda
    {
        public Cliente cliente { get; set; }

        public Fornecedor fornecedor { get; set; }

        public Produto Produto { get; set; }

        public List<Produto> Produtos { get; set; }

        public Lote lote { get; set; }

        public List<Lote> lotes { get; set; }
    }
}
