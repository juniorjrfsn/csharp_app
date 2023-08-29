using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POO2RestAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/Cadastro/Estado")]
    public class EstadoController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        public EstadoController() : base()
        { }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Get")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented, "Método não implementado.");
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Get/{id:int}")]
        public HttpResponseMessage GetByID(int id)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented, "Método não implementado.");
        }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Post")]
        public HttpResponseMessage Create()
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented, "Método não implementado.");
        }





        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("Put")]
        public HttpResponseMessage Update()
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented, "Método não implementado.");
        }





        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete")]
        public HttpResponseMessage Exclude()
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented, "Método não implementado.");
        }
    }
}
