using Microsoft.AspNetCore.Mvc;

//___________________________________________________START OF FILE__________________________________________________//

namespace ContractClaimSystem.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Track Claim Status";
            return View();
        }
    }
}

//____________________________________________________END OF FILE_____________________________________//