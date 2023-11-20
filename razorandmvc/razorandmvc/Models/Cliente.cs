using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace razorandmvc.Models;

public partial class Cliente
{
    [Key]
    public long Cliid { get; set; }

    public string? Clinome { get; set; }

    public string? Clicpf { get; set; }

    public DateTime? Clidatanascimento { get; set; }

    public string? Cliendereco { get; set; }

    public string? Cliphone { get; set; }

    public string? Climail { get; set; }

    public long? Uidinsert { get; set; }

    public DateTime? UiddtInsert { get; set; }

    public long? Uidupdate { get; set; }

    public string? Uiddtupdate { get; set; }
}
