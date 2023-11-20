using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.Context;
using razorandmvc.Models;

namespace razorandmvc.Pages.Usuariocrud
{
    public class IndexModel : PageModel
    {
        private readonly EscritorioContext _context;

        public IndexModel(EscritorioContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Usuarios != null)
            {
                Usuario = await _context.Usuarios
                .Include(u => u.Empr).ToListAsync();
            }
        }
    }
}
