using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    [ApiController]
    [Route("api/texto")]
    public class TextoUtilidadesController : Controller
    {
        [HttpGet("contar")]
        public IActionResult Contar(string texto)
        {
            int palabras = texto
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Length;

            int caracteres = texto.Length;

            int vocales = texto.Count(x =>
                "aeiouAEIOUáéíóúÁÉÍÓÚ".Contains(x));

            return Ok(new
            {
                palabras,
                caracteres,
                vocales
            });
        }

        [HttpGet("invertir")]
        public IActionResult Invertir(string texto)
        {
            char[] letras = texto.ToCharArray();

            Array.Reverse(letras);

            return Ok(new
            {
                original = texto,
                invertido = new string(letras)
            });
        }
    }
}
