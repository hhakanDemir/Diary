using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
