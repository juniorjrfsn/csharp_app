using AutoMapper;
using POO2EF.ModelData;
using POO2POCO.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2SERVICES.Mapeamentos
{
    public class EstadoMap
    {
        public IMapper Registrar(MapperConfiguration config)
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Estado, EstadoPoco>();
                cfg.CreateMap<EstadoPoco, Estado>();
            });

            return config.CreateMapper();
        }
    }
}
