using apidozerotwo.models;
using apiDoZeroTwo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiDoZeroTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioTwo : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<TarefaModel>> todosUsuariosCadastrados()
        {
            return Ok();
        }
    }
}
