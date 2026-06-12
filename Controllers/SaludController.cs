using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    public class SaludController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
