using DAL.Models;
using DAL.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Bussines
{
    /// <summary>
    /// Trata a lógica do negócio para Clientes
    /// </summary>
    public class ClienteBusiness : ClienteRepository
    {
        ClienteRepository clienteRepo = new ClienteRepository();
        Cliente cliModel = new Cliente();
        public Business.Models.Cliente clienteModel = new Business.Models.Cliente();

        public string VerificarIdade(string cpf)
        {
            if (ValidacoesBussines.validaCPF(cpf))
            {
                clienteModel.Idade = clienteRepo.RetornarIdadeCliente(cpf).ToString();

                if (float.Parse(clienteModel.Idade) > 18)
                {
                    return clienteModel.Idade;
                }
                else
                {
                    throw new Exception("CLIENTE MENOR DE 18 ANOS!");
                }

            }
            else
            {
                clienteModel.Idade = "0";
                throw new Exception("CPF inválido!");
            }
        }
    }
}