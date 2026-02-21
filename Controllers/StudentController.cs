using ERP_Demo_Core_MVC.Models;
using ERP_Demo_Core_MVC.Models.DATABASEFOLDER;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ERP_Demo_Core_MVC.Controllers
{
    public class StudentController : Controller
    {
        // Create a Object 
        private SchoolDB db;
        public StudentController(SchoolDB db)
        {
            this.db=db;
        }
        // display all students 
        public IActionResult Index()
        {
            var studentList = db.Students.ToList();
            return View(studentList);
            //return View();
        }

        //------------------------------------------
        //add students
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentModel s)
        {
            if (ModelState.IsValid)
            { 
                db.Students.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //----------------------------------

        //Edit students
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = db.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel s)
        {
            if (ModelState.IsValid)
            {
                db.Students.Update(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(s);
        }
        //-------------------------------------------------------



        //delete students
        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            var student = db.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpPost]
        public IActionResult DeleteStudent(StudentModel s)
        {
            var student = db.Students.Find(s.Student_Roll);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
