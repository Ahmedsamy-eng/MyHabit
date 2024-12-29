using Microsoft.AspNetCore.Mvc;

namespace Habit_Tracker.Controllers
{
    public class HabitController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
