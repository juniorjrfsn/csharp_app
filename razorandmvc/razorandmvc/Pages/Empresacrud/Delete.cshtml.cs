using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.Context;
using razorandmvc.Models;

namespace razorandmvc.Pages.Empresacrud
{
    public class DeleteModel : PageModel
    {
        private readonly EscritorioContext _context;

        public DeleteModel(EscritorioContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Empresas == null)
            {
                return NotFound();
            }
            var empresa = await _context.Empresas.FindAsync(id);

            if (empresa != null)
            {
                Empresa = empresa;
                _context.Empresas.Remove(Empresa);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
