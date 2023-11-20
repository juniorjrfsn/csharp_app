using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razorandmvc.EscritorioContextNamespace;
using razorandmvc.Models;

namespace razorandmvc.Pages.Usuariocrud
{
    public class EditModel : PageModel
    {
        private readonly razorandmvc.EscritorioContextNamespace.EscritorioContext _context;

        public EditModel(razorandmvc.EscritorioContextNamespace.EscritorioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Usuario Usuario { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario =  await _context.Usuarios.FirstOrDefaultAsync(m => m.Uid == id);
            if (usuario == null)
            {
                return NotFound();
            }
            Usuario = usuario;
           ViewData["Emprid"] = new SelectList(_context.Empresas, "Emprid", "Emprid");
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

            _context.Attach(Usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(Usuario.Uid))
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

        private bool UsuarioExists(long id)
        {
          return _context.Usuarios.Any(e => e.Uid == id);
        }
    }
}
