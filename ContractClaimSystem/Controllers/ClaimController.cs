using Microsoft.AspNetCore.Mvc;

//__________________________________START OF FILE______________________________________

namespace ContractClaimSystem.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Submit Claim";
            return View();
        }

        public IActionResult Upload()
        {
            ViewData["Title"] = "Upload Supporting Documents";
            return View();
        }
    }
}

//__________________________________END OF FILE________________________________________________