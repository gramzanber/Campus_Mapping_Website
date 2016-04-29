using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCOGPS.Models;

namespace UCOGPS.Controllers
{
    public class LoginSystemController : Controller
    {
        private AppDbContext _context;
        public LoginSystemController(AppDbContext context)
        {
            _context = context;
        }

        // /Register
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [Route("Register")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                var newUser = _context.User.Where(model => model.Username.Equals(user.Username)).FirstOrDefault();

                if(newUser == null)
                {
                    user.LastDestinationBuilding = 1;
                    user.LastStartingBuilding = 1;
                    _context.Add(user);
                    _context.SaveChanges();
                }
                return RedirectToAction("Login");
            }
            return View();
        }

        // /Login
        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(User user)
        {

            if(ModelState.IsValid)
            {
                var currentUser = _context.User.Where(model => model.Username.Equals(user.Username)
                    && model.Password.Equals(user.Password)).FirstOrDefault();

                if(currentUser != null)
                {
                    HttpContext.Session.SetString("Username", currentUser.Username.ToString());
                    ObserverModel observer = new ObserverModel();
                    HttpContext.Session.SetString("Observer", "");
                    return RedirectToAction("CampusMap", "MappingSystem");
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Username", "");
            return RedirectToAction("Index", "Home");
        }
    }
}
