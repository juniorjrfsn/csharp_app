using System;
using System.Collections.Generic;

namespace razorandmvc.Models;

public partial class MenuItem
{ 
    public string? url { get; set; }
	public string? pagina { get; set; }
	public virtual ICollection<MenuItem> Usuarios { get; } = new List<MenuItem>();
}
