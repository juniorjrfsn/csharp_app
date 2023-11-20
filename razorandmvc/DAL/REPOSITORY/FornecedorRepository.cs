using Business.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.REPOSITORY
{
    public class FornecedorRepository
    {
        public List<Fornecedor> fornecedores = new List<Fornecedor>();

        public void GetFornecedors()
        {
            fornecedores.Add(new Fornecedor()
            {
                 FId = 1,
                 Fnome = "Xioami",
                endereco = new Endereco()
                {
                    City = "Xangai",
                    Country = "China",
                    Street = "xxx",
                    Number = "123",
                    State = null,
                    Mailbox = "123"
                }
            });

            fornecedores.Add(new Fornecedor()
            {
                FId = 2,
                Fnome = "Huawei",
                endereco = new Endereco()
                {
                    City = "Cantão",
                    Country = "China",
                    Street = "xxx",
                    Number = "234",
                    State = null,
                    Mailbox = "5784"
                }
            });



        }
    }
}
