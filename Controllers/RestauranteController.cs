using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    [ApiController]
    [Route("api/propina")]
    public class RestauranteController : Controller
    {
        [HttpGet("calcular")]
        public IActionResult Calcular(decimal monto, decimal porcentaje)
        {
            decimal propina = monto * porcentaje / 100;

            decimal total = monto + propina;

            return Ok(new
            {
                montoOriginal = monto,
                porcentajePropina = porcentaje,
                propina,
                totalPagar = total
            });
        }
    }
}
