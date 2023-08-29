﻿using POO2RestAPI.Models.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POO2RestAPI.Controllers
{
    [RoutePrefix("api/Cadastro/PessoaFisica")]
    public class PessoaFisicaController : ApiController
    {
        public PessoaFisicaController()
        { }

        [HttpGet]
        [Route("Get")]
        public HttpResponseMessage Get()
        {
            List<PessoaFisica> lista = Models.FakeDB.Database.PessoasFisicas;
            return Request.CreateResponse(HttpStatusCode.OK, lista);
        }
    }
}
