namespace POO2EF.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aula.TipoLogradouro")]
    public partial class TipoLogradouro
    {
        [Key]
        public int IdTipoLogradouro { get; set; }

        public string Descricao { get; set; }
    }
}
