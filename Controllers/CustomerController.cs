using Microsoft.AspNetCore.Mvc;

namespace helpdesk_tickets.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerDashboard()
        {
            return View();
        }
    }
}
