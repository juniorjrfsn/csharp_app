using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.EscritorioContextNamespace;
using razorandmvc.Models;

namespace razorandmvc.Pages.Empresacrud
{
    public class DetailsModel : PageModel
    {
        private readonly razorandmvc.EscritorioContextNamespace.EscritorioContext _context;

        public DetailsModel(razorandmvc.EscritorioContextNamespace.EscritorioContext context)
        {
            _context = context;
        }

      public Empresa Empresa { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Empresas == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresas.FirstOrDefaultAsync(m => m.Emprid == id);
            if (empresa == null)
            {
                return NotFound();
            }
            else 
            {
                Empresa = empresa;
            }
            return Page();
        }
    }
}
