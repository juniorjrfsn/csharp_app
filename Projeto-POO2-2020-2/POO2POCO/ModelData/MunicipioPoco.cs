using System;

namespace POO2POCO.ModelData
{
    public class MunicipioPoco
    {
        public int IdMunicipio { get; set; }

        public int IdEstado { get; set; }

        public string Descricao { get; set; }

        public string SiglaUF { get; set; }

        public DateTime DataInsert { get; set; }

        public DateTime? DataUpdate { get; set; }

    }
}
