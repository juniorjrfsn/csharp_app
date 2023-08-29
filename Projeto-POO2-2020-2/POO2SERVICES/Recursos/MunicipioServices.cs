using POO2DAL.DataModel;
using POO2EF.ModelData;
using POO2POCO.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2SERVICES.Recursos
{
    public class MunicipioServices
    {
        private PrototipoDB contexto;

        private MunicipioRepository repositorio;

        public MunicipioServices()
        {
            this.contexto = new PrototipoDB();
            this.repositorio = new MunicipioRepository(this.contexto);
        }

        public List<MunicipioPoco> ObterTodos()
        {
            List<Municipio> municipios = this.repositorio.ListAll().ToList();
            List<MunicipioPoco> municipiosPoco = municipios.Select(mun => new MunicipioPoco()
            {
                DataInsert = mun.DataInsert,
                DataUpdate = mun.DataUpdate,
                Descricao = mun.Descricao,
                IdEstado = mun.IdEstado,
                IdMunicipio = mun.IdMunicipio,
                SiglaUF = mun.SiglaUF
            }).ToList();
            return municipiosPoco;
        }

        public MunicipioPoco Obter(int id)
        {
            Municipio municipio = this.repositorio.Read(id);
            MunicipioPoco municipioPoco = new MunicipioPoco() 
            {
                DataInsert = municipio.DataInsert,
                DataUpdate = municipio.DataUpdate,
                Descricao = municipio.Descricao,
                IdEstado = municipio.IdEstado,
                IdMunicipio = municipio.IdMunicipio,
                SiglaUF = municipio.SiglaUF
            };
            return municipioPoco;
        }

        public List<MunicipioPoco> Obter(string uf)
        {
            List<Municipio> municipios = this.repositorio.ReadAll().Where(mun => mun.SiglaUF.Contains(uf)).ToList();
            List<MunicipioPoco> municipiosPoco = municipios.Select(mun => new MunicipioPoco()
            {
                DataInsert = mun.DataInsert,
                DataUpdate = mun.DataUpdate,
                Descricao = mun.Descricao,
                IdEstado = mun.IdEstado,
                IdMunicipio = mun.IdMunicipio,
                SiglaUF = mun.SiglaUF
            }).ToList();
            return municipiosPoco;
        }
    }
}
