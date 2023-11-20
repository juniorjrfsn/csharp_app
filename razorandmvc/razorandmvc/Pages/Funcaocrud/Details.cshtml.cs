using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.Context;
using razorandmvc.Models;

namespace razorandmvc.Pages.Funcaocrud
{
    public class DetailsModel : PageModel
    {
        private readonly EscritorioContext _context;

        public DetailsModel(EscritorioContext context)
        {
            _context = context;
        }

      public Funcao Funcao { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Funcaos == null)
            {
                return NotFound();
            }

            var funcao = await _context.Funcaos.FirstOrDefaultAsync(m => m.Funcid == id);
            if (funcao == null)
            {
                return NotFound();
            }
            else 
            {
                Funcao = funcao;
            }
            return Page();
        }
    }
}
