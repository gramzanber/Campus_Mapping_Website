using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace UCOGPS.Controllers
{
    public class MappingSystemController : Controller
    {
        [Route("CampusMAP")]
        public IActionResult CampusMap()
        {
            return View();
        }
    }
}
