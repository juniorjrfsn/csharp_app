using POO2SERVICES.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POO2RestAPICamadas.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/municipio")]
    public class MunicipioController : ApiController
    {
        private MunicipioServices servico;

        /// <summary>
        /// 
        /// </summary>
        public MunicipioController()
        {
            this.servico = new MunicipioServices();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obter")]
        public HttpResponseMessage ObterTodos()
        {
            var retorno = this.servico.ObterTodos();
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Obter/{id:int}")]
        public HttpResponseMessage ObterPorID(int id)
        {
            var retorno = this.servico.Obter(id);
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uf"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Obter/UF/{uf}")]
        public HttpResponseMessage ObterPorUF(string uf)
        {
            var retorno = this.servico.Obter(uf.ToUpper());
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }
    }
}
