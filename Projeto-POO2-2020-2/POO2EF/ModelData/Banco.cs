namespace POO2EF.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aula.Banco")]
    public partial class Banco
    {
        [Key]
        public int IdBanco { get; set; }

        public int? CodigoBanco { get; set; }

        public string Descricao { get; set; }

        public string UrlSite { get; set; }
    }
}
