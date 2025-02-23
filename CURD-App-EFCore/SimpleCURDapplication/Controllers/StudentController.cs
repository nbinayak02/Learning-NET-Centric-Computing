using Microsoft.AspNetCore.Mvc;
using SimpleCURDapplication.Data;
using SimpleCURDapplication.Models;

namespace SimpleCURDapplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult AddStudents()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudents(Student students)
        {
            if (ModelState.IsValid)
            {
                //if there are no any validation errors
                _context.Students.Add(students);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(students);
            //returns View with validation errors
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            var existingStudent = _context.Students.Find(student.Id);
            if(existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Semester = student.Semester;
                existingStudent.Faculty = student.Faculty;
                _context.Students.Update(existingStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if(student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
