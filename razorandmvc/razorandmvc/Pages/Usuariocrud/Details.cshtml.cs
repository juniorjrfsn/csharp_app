using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.EscritorioContextNamespace;
using razorandmvc.Models;

namespace razorandmvc.Pages.Usuariocrud
{
    public class DetailsModel : PageModel
    {
        private readonly razorandmvc.EscritorioContextNamespace.EscritorioContext _context;

        public DetailsModel(razorandmvc.EscritorioContextNamespace.EscritorioContext context)
        {
            _context = context;
        }

      public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(m => m.Uid == id);
            if (usuario == null)
            {
                return NotFound();
            }
            else 
            {
                Usuario = usuario;
            }
            return Page();
        }
    }
}
