using POO2DAL.Ancient;
using POO2EF.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2DAL.DataModel
{
    public class MunicipioRepository : Repository<PrototipoDB, Municipio>
    {
        public MunicipioRepository(PrototipoDB contexto) : base(contexto)
        { }
    }
}
