using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorandmvc.Models;

namespace razorandmvc.Pages.Shared
{
    public class _Menu : PageModel
    {
 
        private readonly ILogger<_Menu> _logger;

        public _Menu(ILogger<_Menu> logger)
        {
            _logger = logger;
        }  
  
        public List<MenuLink> lista = new List<MenuLink>();
        public IList<MenuLink> Men { get; set; } = default!;
 

        public static List<MenuLink> getMenu()
        {
            string texto = " olá";
            List<MenuLink> m = new List<MenuLink>
            {
                  new MenuLink( "#", "C# (ASP.NET MVC)" )
                , new MenuLink( "#", "ABAP (Web Dynpro MVC)" )
                , new MenuLink( "#", "Ruby (Ruby on Rail)"  )
                , new MenuLink( "#", "Python (Django)"  )
                , new MenuLink( "#", "Java (Java EE MVC)"  )
                , new MenuLink( "#", "TypeScript (Super Conjunto JavaScript)" + texto  )
            }; 
            return m;
        }

        private static readonly List<MenuLink> menuLinks = getMenu();
        public static List<MenuLink> MenuLinks = menuLinks;
     
        public void OnGet()
        {

            //MenuLink m1 = new MenuLink("http1", "g  g sdfas");
            //MenuLinks.Add(m1);

            //MenuLink m2 = new MenuLink("http2", "l l l sdgdsffas");
            //MenuLinks.Add(m2); 
            //Men = MenuLinks; 
        }
        /**********************************************************/
    }
}
