using Microsoft.AspNetCore.Mvc;

namespace ActividadPracticaI_UnidadII.Controllers
{
    public class HolaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
