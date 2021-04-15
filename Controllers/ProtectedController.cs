using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcAuthVue.Controllers
{

    public class ProtectedController : Controller
    {

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

    }

}