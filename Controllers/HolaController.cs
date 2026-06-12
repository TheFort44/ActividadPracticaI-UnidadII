using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    [ApiController]
    [Route("api/hola")]
    public class HolaController : Controller
    {
        [HttpGet("saludo")]
        public IActionResult Saludo(string nombre)
        {
            return Ok(new
            {
                mensaje = $"Bienvenido {nombre}"
            });
        }
    }
}
