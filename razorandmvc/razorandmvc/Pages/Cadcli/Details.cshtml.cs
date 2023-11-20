using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.Context;
using razorandmvc.Models;

namespace razorandmvc.Pages.Cadcli
{
    public class DetailsModel : PageModel
    {
        private readonly EscritorioContext _context;

        public DetailsModel(EscritorioContext context)
        {
            _context = context;
        }

      public Cliente Cliente { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Clientes == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Cliid == id);
            if (cliente == null)
            {
                return NotFound();
            }
            else 
            {
                Cliente = cliente;
            }
            return Page();
        }
    }
}
