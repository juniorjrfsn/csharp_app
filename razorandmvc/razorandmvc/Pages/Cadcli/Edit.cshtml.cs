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

namespace razorandmvc.Pages.Cadcli
{
    public class EditModel : PageModel
    {
        private readonly EscritorioContext _context;

        public EditModel(EscritorioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Clientes == null)
            {
                return NotFound();
            }

            var cliente =  await _context.Clientes.FirstOrDefaultAsync(m => m.Cliid == id);
            if (cliente == null)
            {
                return NotFound();
            }
            Cliente = cliente;
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

            _context.Attach(Cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(Cliente.Cliid))
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

        private bool ClienteExists(long id)
        {
          return (_context.Clientes?.Any(e => e.Cliid == id)).GetValueOrDefault();
        }
    }
}
