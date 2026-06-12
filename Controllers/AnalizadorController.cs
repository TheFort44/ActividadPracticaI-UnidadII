using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    [ApiController]
    [Route("api/numeros")]
    public class AnalizadorController : Controller
    {
        [HttpGet("analizar")]
        public IActionResult Analizar(int n)
        {
            bool esPar = n % 2 == 0;

            bool esPrimo = true;

            if (n <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            string tipo;

            if (n > 0)
                tipo = "Positivo";
            else if (n < 0)
                tipo = "Negativo";
            else
                tipo = "Cero";

            return Ok(new
            {
                numero = n,
                esPar,
                esPrimo,
                tipo
            });
        }
    }
}
