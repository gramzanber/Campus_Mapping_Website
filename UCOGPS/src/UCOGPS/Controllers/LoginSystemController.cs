using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCOGPS.Controllers
{
    public class LoginSystemController : Controller
    {
        // /Register
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // /Login
        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
