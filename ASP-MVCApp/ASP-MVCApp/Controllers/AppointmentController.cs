using Microsoft.AspNetCore.Mvc;

namespace ASP_MVCApp.Controllers {
    public class AppointmentController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
