using Business.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.REPOSITORY
{
    public class ClienteRepository : Repository<Cliente>
    {
        Repository<Cliente> clienteRepo = new Repository<Cliente>();

        public float RetornarIdadeCliente(string cpf)
        {
            float idade = 0;
            string sql = string.Format(@"SELECT
                    Cliid  ,
                    Clinome  ,
                    Clicpf  ,
                    Clidatanascimento  ,
                    (DATEDIFF(DAY, Clidatanascimento, GETDATE() - (CASE WHEN DATEADD(DAY, DATEDIFF(DAY, Clidatanascimento, GETDATE()), Clidatanascimento) > GETDATE() THEN 1 ELSE 0 END) )/365.25) AS  IDADE ,
                    Cliendereco ,
                    Cliphone  ,
                    Climail  ,
                    Uidinsert ,
                    UIddtInsert  ,
                    Uidupdate  ,
                    Uiddtupdate  
             FROM  Cliente WHERE Clicpf = '{0}' ", cpf);

            var consulta = clienteRepo.ExecutarSQL(sql);

            foreach (DataRow item in consulta)
            {
                idade = float.Parse(item["IDADE"].ToString());
            }

            return idade;
        }

        public List<Cliente> clientes = new List<Cliente>();

        public void GetClientes()
        {
            clientes.Add(new Cliente() { 
                
            
            });    
        }
    }
}