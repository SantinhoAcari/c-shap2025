using apiDoZeroTwo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiDoZeroTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioController : ControllerBase
    {
        // GET: api/<usuarioController>
        [HttpGet]
        public IEnumerable<tarefaModel> Get()
        {
            List<tarefaModel> santoUsuario = new List<tarefaModel>();
            santoUsuario.Add(new tarefaModel() { Id = 1, Name = "Santinho", Email = "santinhoUnp@outlook.com" });
            return santoUsuario;
        }

        // GET api/<usuarioController>/5
        [HttpGet("{id}")]
        public tarefaModel Get(int id)
        {
            tarefaModel usuario = new tarefaModel();
            return usuario;
        }

        // POST api/<usuarioController>
        [HttpPost]
        public void Post([FromBody] tarefaModel usuario)
        {
        }

        // PUT api/<usuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] tarefaModel usuario)
        {
        }

        // DELETE api/<usuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
