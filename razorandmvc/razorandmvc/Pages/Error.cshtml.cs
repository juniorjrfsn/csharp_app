using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
 
using razorandmvc.Models;

namespace razorandmvc.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public string? RequestId { get; set; }
		public string? CodeError { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public object ErrorMessage { get;  set; }
        public object ViewBag { get; set; }

        private readonly ILogger<ErrorModel> _logger;

 

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        { 
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
 /*
        public void OnGet(int statusCode)
        {
            var statusCodeData = HttpContext.Features.Get<Microsoft.AspNetCore.Diagnostics.IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ErrorMessage = "Pagina não encontrada"; 
                    break;
                case 500:
                    ErrorMessage = "Erro no servidor"; 
                    break;

            } 
        }
        */

    }
}