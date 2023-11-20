using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorandmvc.Models;
using System.ComponentModel;
using Business.Bussines;
using Business.Models;

namespace razorandmvc.Pages.Clientes
{
    public class ConsultaModel : PageModel
    {
        ClienteBusiness clienteBusiness = new ClienteBusiness();

        public  Business.Models.Cliente clienteModel = new Business.Models.Cliente();

        public ConsultaModel()
        {
            clienteModel.Cpf = "";
            clienteModel.Idade = "0";
        }

        public async Task<IActionResult> OnPostAsync(string? cpf)
        {
            clienteModel.Cpf = cpf;
            try
            {
                clienteModel.Idade = clienteBusiness.VerificarIdade(cpf);

                return Page();
            }
            catch (Exception ex)
            {
                clienteModel = clienteBusiness.clienteModel;
                clienteModel.ExceptionError = ex.Message;
                return Page();
                //return NotFound();
            }
        }
    }
}
