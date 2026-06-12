using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    [ApiController]
    [Route("api/tiempo")]
    public class ConversorController : Controller
    {
        [HttpGet("formatear")]
        public IActionResult Formatear(int segundos)
        {
            TimeSpan tiempo = TimeSpan.FromSeconds(segundos);

            return Ok(new
            {
                horas = tiempo.Hours,
                minutos = tiempo.Minutes,
                segundosRestantes = tiempo.Seconds,
                formatoCompleto = tiempo.ToString(@"hh\:mm\:ss")
            });
        }
    }
}
