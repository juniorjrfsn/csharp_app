﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Fornecedor
    {
        public int FId { get; set; }

        public string Fnome { get; set; }

        public Endereco endereco { get; set; }
    }
}
