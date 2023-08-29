namespace POO2EF.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aula.Idioma")]
    public partial class Idioma
    {
        [Key]
        public int IdIdioma { get; set; }

        [StringLength(2)]
        public string Abreviado { get; set; }

        public string Descricao { get; set; }
    }
}
