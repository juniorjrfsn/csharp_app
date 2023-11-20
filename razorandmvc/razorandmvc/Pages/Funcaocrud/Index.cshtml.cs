using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorandmvc.EscritorioContextNamespace;
using razorandmvc.Models;

namespace razorandmvc.Pages.Funcaocrud
{
    public class IndexModel : PageModel
    {
        private readonly razorandmvc.EscritorioContextNamespace.EscritorioContext _context;

        public IndexModel(razorandmvc.EscritorioContextNamespace.EscritorioContext context)
        {
            _context = context;
        }

        public IList<Funcao> Funcao { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Funcaos != null)
            {
                Funcao = await _context.Funcaos.ToListAsync();
            }
        }
    }
}
