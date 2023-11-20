using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace razorandmvc.Models;

public partial class Funcao
{
    [Key]
    public int Funcid { get; set; }

    public string? Funcnome { get; set; }
}
