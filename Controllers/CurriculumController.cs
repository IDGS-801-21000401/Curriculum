using Microsoft.AspNetCore.Mvc;
namespace Curriculum.Controllers
{
    public class Curriculum : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PreparacionAcademica()
        {
            return View();
        }

        public IActionResult ExperienciaLaboral()
        {
            return View();
        }
    }
}