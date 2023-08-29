using AutoMapper;
using POO2EF.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2SERVICES.Ancestral
{
    public abstract class ServiceBase
    {
        private PrototipoDB contexto;

        private IMapper mapeado;

        private MapperConfiguration configuracao;

        protected PrototipoDB Contexto { get { return this.contexto; } }

        protected IMapper Mapeado 
        { 
            get { return this.mapeado; }
            set { this.mapeado = value; }
        }

        protected MapperConfiguration Configuracao 
        { 
            get { return this.configuracao; }
            set { this.configuracao = value; }
        }

        public ServiceBase()
        {
            this.contexto = new PrototipoDB();
        }
    }
}
