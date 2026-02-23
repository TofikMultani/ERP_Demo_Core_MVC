using ERP_Demo_Core_MVC.Models;
using ERP_Demo_Core_MVC.Models.DATABASEFOLDER;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Demo_Core_MVC.Controllers
{
    public class TeacherController : Controller
    {
        // Create a Object 
        private SchoolDB db;
        public TeacherController(SchoolDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var TeacherList = db.Teachers.ToList();
            return View(TeacherList);
        }

        //add Teachers
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(TeacherModel t)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(t);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        

        // Edit Teachers
        [HttpGet]
        public IActionResult EditTeacher(int id)
        {
            var teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }
        [HttpPost]
        public IActionResult EditTeacher(TeacherModel t)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Update(t);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // Delete Teachers
        [HttpGet]
        public IActionResult DeleteTeacher(int id)
        {
            var teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }
        [HttpPost, ActionName("DeleteTeacher")]
        public IActionResult DeleteTeacherConfirmed(int id)
        {
            var teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            db.Teachers.Remove(teacher);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
