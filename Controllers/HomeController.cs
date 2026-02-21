using ERP_Demo_Core_MVC.Models;
using ERP_Demo_Core_MVC.Models.DATABASEFOLDER;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ERP_Demo_Core_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly SchoolDB _db;

        public HomeController(SchoolDB db)
        {
            _db = db;
        }

        // GET: /Home/Index
        public async Task<IActionResult> Index()
        {
                    var totalStudents = await _db.Students.CountAsync();
            ViewBag.TotalStudents = totalStudents;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
