using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UCOGPS.Controllers
{
    public class HomeController : Controller
    {
        //first page that loads
        public IActionResult Index()
        {
                return RedirectToAction("Login", "LoginSystem", null);
        }
    }
}
