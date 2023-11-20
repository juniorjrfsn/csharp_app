using System;
using System.Collections.Generic;
using static Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary;

namespace razorandmvc.Models
{
    public partial class MenuLink
    { 

        public string url { get; set; }
        public string Pagina { get; set; }
        public virtual ICollection<MenuLink> MenuLinks { get; set; } = new List<MenuLink>();

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
         
        public MenuLink(  string url, string pagina )
        {
           
            this.url = url;
            this.Pagina = pagina; 
        }
    }
}

