using POO2POCO.ModelData;
using POO2SERVICES.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace POO2RestAPICamadas.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/Estado")]
    public class EstadoController : ApiController
    {
        private EstadoServices servico;

        /// <summary>
        /// 
        /// </summary>
        public EstadoController()
        {
            this.servico = new EstadoServices();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Obter")]
        public Task<HttpResponseMessage> ObterTodos()
        {
            try
            {
                var retorno = this.servico.ObterTodos();
                return Task.FromResult(Request.CreateResponse(HttpStatusCode.OK, retorno));
            }
            catch (Exception ex)
            {
                return Task.FromResult(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro durante o processamento da requisição.", ex));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Obter/{id:int}")]
        public Task<HttpResponseMessage> ObterPorID(int id)
        {
            try
            {
                var retorno = this.servico.Obter(id);
                return Task.FromResult(Request.CreateResponse(HttpStatusCode.OK, retorno));

            }
            catch (Exception ex)
            {
                return Task.FromResult(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message, ex));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Criar")]
        public Task<HttpResponseMessage> Criar([FromBody] EstadoPoco poco)
        {
            try
            {
                var retorno = this.servico.Incluir(poco);
                return Task.FromResult(Request.CreateResponse(HttpStatusCode.OK, retorno));

            }
            catch (Exception ex)
            {
                return Task.FromResult(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro durante o processamento da requisição.", ex));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Alterar")]
        public Task<HttpResponseMessage> Alterar([FromBody] EstadoPoco poco)
        {
            try
            {
                var retorno = this.servico.Alterar(poco);
                return Task.FromResult(Request.CreateResponse(HttpStatusCode.OK, retorno));
            }
            catch (Exception ex)
            {
                return Task.FromResult(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro durante o processamento da requisição.", ex));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Excluir/{id:int}")]
        public Task<HttpResponseMessage> Excluir(int id)
        {
            try
            {
                var retorno = this.servico.Excluir(id);
                return Task.FromResult(Request.CreateResponse(HttpStatusCode.OK, retorno));
            }
            catch (Exception ex)
            {
                return Task.FromResult(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro durante o processamento da requisição.", ex));
            }
        }

    }
}
