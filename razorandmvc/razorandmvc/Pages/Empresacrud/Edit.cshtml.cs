using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razorandmvc.Context;
using razorandmvc.Models;

namespace razorandmvc.Pages.Empresacrud
{
    public class EditModel : PageModel
    {
        private readonly EscritorioContext _context;

        public EditModel(EscritorioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Empresa Empresa { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Empresas == null)
            {
                return NotFound();
            }

            var empresa =  await _context.Empresas.FirstOrDefaultAsync(m => m.Emprid == id);
            if (empresa == null)
            {
                return NotFound();
            }
            Empresa = empresa;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Empresa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(Empresa.Emprid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmpresaExists(long id)
        {
          return _context.Empresas.Any(e => e.Emprid == id);
        }
    }
}
