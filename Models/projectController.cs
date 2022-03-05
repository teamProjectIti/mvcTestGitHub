using Microsoft.AspNetCore.Mvc;

namespace mvcTestGitHub.Models
{
    public class projectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
