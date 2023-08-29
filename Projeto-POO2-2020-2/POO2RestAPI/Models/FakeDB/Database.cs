using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.UI.WebControls;

namespace POO2RestAPI.Models.FakeDB
{
    public static class Database
    {
        private static List<PessoaFisica> pessoasFisicas;

        /// <summary>
        /// 
        /// </summary>
        public static List<PessoaFisica> PessoasFisicas
        {
            get 
            {
                if (pessoasFisicas == null)
                {
                    pessoasFisicas = new List<PessoaFisica>();
                    preencherPessoasFisicas();
                }
                return pessoasFisicas;
            }
        }

        private static void preencherPessoasFisicas()
        {
            pessoasFisicas.Add(CriarRegistro(1, "12345678932", DateTime.Now, new DateTime(1990, 04, 20),
                "Dino da Silva Sauro", "1123456789 SSP/MS", "123456789"));

            pessoasFisicas.Add(CriarRegistro(2, "12345678932", DateTime.Now, new DateTime(1990, 08, 4),
                "Fran da Silva Sauro", "1123456789 SSP/MS", "123456789"));

            pessoasFisicas.Add(CriarRegistro(3, "12345678932", DateTime.Now, new DateTime(2002, 01, 10),
                "Bobby da Silva Sauro", "1123456789 SSP/MS", "123456789"));

            pessoasFisicas.Add(CriarRegistro(4, "12345678932", DateTime.Now, new DateTime(2004, 03, 23),
                "Sharlene da Silva Sauro", "1123456789 SSP/MS", "123456789"));

            pessoasFisicas.Add(CriarRegistro(3, "12345678932", DateTime.Now, new DateTime(2010, 10, 18),
                "Baby da Silva Sauro", "1123456789 SSP/MS", "123456789"));
        }

        private static PessoaFisica CriarRegistro(int id, string cpf, DateTime dataDeInscricao, 
            DateTime dataDeNascimento, string nome, string rg, string tituloDeEleitor)
        {
            return new PessoaFisica(id)
            {
                CPF = cpf,
                DataDeInscricao = dataDeInscricao,
                DataDeNascimento = dataDeNascimento,
                Nome = nome,
                RG = rg,
                TituloDeEleitor = tituloDeEleitor
            };
        }
    }
}