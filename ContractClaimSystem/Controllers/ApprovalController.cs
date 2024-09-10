using Microsoft.AspNetCore.Mvc;

//_______________________________________________START OF FILE______________________________________________//

namespace ContractClaimSystem.Controllers
{
    public class ApprovalController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Approve Claims";
            return View();
        }
    }
}

//___________________________________________________END OF FILE_______________________________________________//