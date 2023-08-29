using System;

namespace POO2POCO.ModelData
{
    public class EstadoPoco
    {
        public int IdEstado { get; set; }

        public int IdRegiao { get; set; }

        public string Descricao { get; set; }

        public string SiglaUF { get; set; }

        public string RegiaoBrasil { get; set; }

        public DateTime DataInsert { get; set; }

        public DateTime? DataUpdate { get; set; }
    }
}
