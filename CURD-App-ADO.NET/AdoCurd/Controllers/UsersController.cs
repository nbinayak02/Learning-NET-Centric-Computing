using AdoCurd.Data;
using AdoCurd.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdoCurd.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserDbOperations _operations;

        public UsersController(UserDbOperations operations)
        {
            _operations = operations;
        }

        public IActionResult Index()
        {
            var users = _operations.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User userdata)
        {
            if (ModelState.IsValid)
            {
                _operations.InsertUser(userdata);
                return RedirectToAction("Index");
            }

            return View(userdata);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _operations.GetUser(id);
            if(user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(User users)
        {
            if (ModelState.IsValid)
            {
                _operations.UpdateUser(users);
                return RedirectToAction("Index");
            }

            return View(users);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _operations.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
