using Microsoft.AspNetCore.Mvc;
using razorandmvc.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace razorandmvc.Api
{
    [Produces("application/json")]
    [Route("api/Endereco/")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        // GET: api/<EnderecoController>
        [HttpGet]
        public  Object Get()
        {
            // IEnumerable
            IEnumerable<Endereco> ends = getEnderecos(); 
            return  new { enderecos = ends  };
        }

        // GET api/<EnderecoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value : " + id;
        }

        // POST api/<EnderecoController>
       /* [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
        
        // GET: api/<EnderecoController>
        [HttpPost]
        public Object Post()
        {
            // IEnumerable 
            IEnumerable<Endereco> ends = getEnderecos(); 
            return new { enderecos = ends };
        }
        public List<Endereco> getEnderecos()
        {
            List<Endereco> lista = new List<Endereco>();
            Endereco e1 = new Endereco();
            e1.id = 1;
            e1.Logradouro = "Avenida Afonso Pena";
            e1.Numero = "3456634";
            lista.Add(e1);

            Endereco e2 = new Endereco();
            e2.id = 2;
            e2.Logradouro = "Avenida Mato Grosso";
            e2.Numero = "74568888";
            lista.Add(e2);

            Endereco e3 = new Endereco();
            e3.id = 3;
            e3.Logradouro = "Avenida Ceará";
            e3.Numero = "457345";
            lista.Add(e3);

            Endereco e4 = new Endereco();
            e4.id = 4;
            e4.Logradouro = "Avenida Marques de Pombal";
            e4.Numero = "23452423";
            lista.Add(e4);
             
            return lista;
        }
        // PUT api/<EnderecoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EnderecoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
