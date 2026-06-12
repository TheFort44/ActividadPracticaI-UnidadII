using ActividadPracticaI_UnidadII.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    [ApiController]
    [Route("api/notas")]
    public class NotasController : Controller
    {
        [HttpPost("estadisticas")]
        public IActionResult Estadisticas([FromBody] EstadisticasNotasRequest request)
        {
            if (request.Notas == null || request.Notas.Count == 0)
            {
                return BadRequest("Debe enviar al menos una nota.");
            }

            double promedio = request.Notas.Average();

            int notaMayor = request.Notas.Max();

            int notaMenor = request.Notas.Min();

            int aprobados = request.Notas.Count(n => n >= 70);

            int reprobados = request.Notas.Count(n => n < 70);

            return Ok(new
            {
                promedio,
                notaMayor,
                notaMenor,
                aprobados,
                reprobados
            });
        }
    }
}
