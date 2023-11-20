using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DAL.REPOSITORY;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.EscritorioContextNamespace;
using razorandmvc.Models;

namespace razorandmvc.Pages.Clientes
{
    public class IndexModel : PageModel
    {

        private readonly IClienteService _clienteService;

        public IndexModel(IClienteService clienteService)
        {
            _clienteService =  clienteService;
        }


        Repository<Cliente> clienteRepo = new Repository<Cliente>();
        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {

            List<Cliente> cli = new List<Cliente>();
            string sql = string.Format(@"SELECT TOP 1000
                    Cliid  ,
                    Clinome  ,
                    Clicpf  ,
                    Clidatanascimento  ,
                    Cliendereco ,
                    Cliphone  ,
                    Climail  ,
                    Uidinsert ,
                    UiddtInsert  ,
                    Uidupdate  ,
                    Uiddtupdate  
             FROM  Cliente "); //  WHERE Clicpf = '{0}' ", cpf);

            var Resut = clienteRepo.ExecutarSQL(sql);

            foreach (DataRow item in Resut)
            {
                razorandmvc.Models.Cliente c = new razorandmvc.Models.Cliente();

                c.Cliid                     = Int32.Parse( item["Cliid"].ToString() );
                c.Clinome                   = item["Clinome"].ToString();
                c.Clicpf                    = item["Clicpf"].ToString();

                string d1                   = !String.IsNullOrEmpty(item["Clidatanascimento"].ToString()) ?  item["Clidatanascimento"].ToString() : null;
                DateTime Clidatanascimento  = DateTime.ParseExact(d1, @"dd/MM/yyyy HH:mm:ss",  System.Globalization.CultureInfo.InvariantCulture );
                c.Clidatanascimento         = Clidatanascimento;

                c.Cliendereco       = item["Cliendereco"].ToString();
                c.Cliphone          = item["Cliphone"].ToString();
                c.Climail           = item["Climail"].ToString();
                c.Uidinsert         = (!String.IsNullOrEmpty( item["Uidinsert"].ToString()) )?Int32.Parse(item["Uidinsert"].ToString()) : null ;

                string d2               = !String.IsNullOrEmpty(item["UiddtInsert"].ToString()) ? item["UiddtInsert"].ToString() : null;
                DateTime UiddtInsert    = DateTime.ParseExact(d2, @"dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                c.UiddtInsert           = UiddtInsert;

                c.Uidupdate     = (!String.IsNullOrEmpty(item["Uidupdate"].ToString())) ? Int32.Parse(item["Uidupdate"].ToString()) : null;
                c.Uiddtupdate   = item["Uiddtupdate"].ToString(); 
                cli.Add(c);
                
            }
            Cliente = cli;
        }
    }
}
