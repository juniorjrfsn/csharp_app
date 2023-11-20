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
    public class IndexModel : PageModel
    {
        private readonly razorandmvc.EscritorioContextNamespace.EscritorioContext _context;

        public IndexModel(razorandmvc.EscritorioContextNamespace.EscritorioContext context)
        {
            _context = context;
        }

        public IList<Empresa> Empresa { get;set; } = default!;
		public IList<MenuItem> Menu { get; set; } = default!;

		
		public async Task OnGetAsync()
        {
            if (_context.Empresas != null)
            {
                Empresa = await _context.Empresas.ToListAsync();
            }
            List<MenuItem> mens = new List<MenuItem>();
			MenuItem m1     = new MenuItem();
            m1.url      = "http";
			m1.pagina   = "sdfas";
			mens.Add(m1);

			MenuItem m2 = new MenuItem();
			m2.url = "http";
			m2.pagina = "sdfas";
			mens.Add(m2);

			Menu = mens;

		}
    }
}
