using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace razorandmvc.Models;

public partial class Usuario
{
    [Key]
    public long Uid { get; set; }

    public long? Emprid { get; set; }

    public string? Unome { get; set; }

    public string? Ucpf { get; set; }

    public DateTime? Udatanascimento { get; set; }

    public string? Uemail { get; set; }

    public string? Usenha { get; set; }

    public string? Uphone { get; set; }

    public string? Ucelular { get; set; }

    public string? Ufoto { get; set; }

    public byte? Uadmin { get; set; }

    public byte? Uativo { get; set; }

    public byte? Ulogon { get; set; }

    public byte? Usuporte { get; set; }

    public long? Uidinsert { get; set; }

    public DateTime Uiddtinsert { get; set; }

    public long? Uidupdate { get; set; }

    public DateTime? Uiddtupdate { get; set; }

    public virtual Empresa? Empr { get; set; }
}
