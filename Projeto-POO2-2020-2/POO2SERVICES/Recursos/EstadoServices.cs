using POO2DAL.DataModel;
using POO2EF.ModelData;
using POO2POCO.ModelData;
using POO2SERVICES.Ancestral;
using POO2SERVICES.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2SERVICES.Recursos
{
    public class EstadoServices : ServiceBase, IServiceBase<EstadoPoco>
    {
        private EstadoRepository repositorio;

        private EstadoMap map;

        public EstadoServices()
        {
            this.repositorio = new EstadoRepository(this.Contexto);
            this.map = new EstadoMap();
            this.Mapeado = this.map.Registrar(this.Configuracao);
        }

        public List<EstadoPoco> ObterTodos()
        {
            List<Estado> estados = this.repositorio.ListAll().ToList();
            List<EstadoPoco> estadoPoco = this.Mapeado.Map<List<EstadoPoco>>(estados);
            return estadoPoco;
        }

        public EstadoPoco Obter(int id)
        {
            try
            {
                if (id == 0)
                    throw new Exception("Chave primária informada não pode ser zero.");
                Estado estado = this.repositorio.Read(id);
                if (estado == null)
                    throw new Exception("Não foi possível encontrar registro com a chave primária informada.");
                EstadoPoco poco = this.Mapeado.Map<EstadoPoco>(estado);
                return poco;
            }
            catch
            {
                throw;
            }
        }

        public EstadoPoco Incluir(EstadoPoco poco)
        {
            Estado estado = this.Mapeado.Map<Estado>(poco);
            this.repositorio.Create(estado);
            this.repositorio.SaveChanges();
            Estado estadoRetorno = this.repositorio.Read(estado.IdEstado);
            EstadoPoco pocoRetorno = this.Mapeado.Map<EstadoPoco>(estadoRetorno);
            return pocoRetorno;
        }

        public EstadoPoco Alterar(EstadoPoco poco)
        {
            Estado estado = this.Mapeado.Map<Estado>(poco);
            this.repositorio.Update(estado);
            this.repositorio.SaveChanges();
            Estado estadoRetorno = this.repositorio.Read(estado.IdEstado);
            EstadoPoco pocoRetorno = this.Mapeado.Map<EstadoPoco>(estadoRetorno);
            return pocoRetorno;
        }

        public EstadoPoco Excluir(int id)
        {
            Estado estadoRetorno = this.repositorio.Read(id);
            this.repositorio.Delete(id);
            this.repositorio.SaveChanges();
            EstadoPoco pocoRetorno = this.Mapeado.Map<EstadoPoco>(estadoRetorno);
            return pocoRetorno;
        }
    }
}
