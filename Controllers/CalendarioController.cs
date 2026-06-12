using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    [ApiController]
    [Route("api/fechas")]
    public class CalendarioController : Controller
    {
        [HttpGet("diferencia")]
        public IActionResult Diferencia(DateTime desde, DateTime hasta)
        {
            int dias = (hasta - desde).Days;

            return Ok(new
            {
                fechaInicial = desde.ToShortDateString(),
                fechaFinal = hasta.ToShortDateString(),
                diferenciaDias = dias
            });
        }

        [HttpGet("agregar")]
        public IActionResult Agregar(DateTime fecha, int dias)
        {
            DateTime nuevaFecha = fecha.AddDays(dias);

            return Ok(new
            {
                fechaOriginal = fecha.ToShortDateString(),
                diasAgregados = dias,
                nuevaFecha = nuevaFecha.ToShortDateString()
            });
        }
    }
}
