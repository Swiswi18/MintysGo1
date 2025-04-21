using Microsoft.AspNetCore.Mvc;

namespace MintysGo1.Controllers
{
    public class MspController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
