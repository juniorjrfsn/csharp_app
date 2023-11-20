using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace razorandmvc.Models;

public partial class Empresa
{
    [Key]
    public long Emprid { get; set; }

    public string? Emprnome { get; set; }

    public long? Uidinsert { get; set; }

    public DateTime Uiddtinsert { get; set; }

    public long? Uidupdate { get; set; }

    public DateTime? Uiddtupdate { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
