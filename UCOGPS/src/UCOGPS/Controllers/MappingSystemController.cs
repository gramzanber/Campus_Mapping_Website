using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using UCOGPS.Models;
using Microsoft.AspNet.Http;

namespace UCOGPS.Controllers
{
    public class MappingSystemController : Controller
    {
        private ObserverModel observer;
        private AppDbContext _context;

        public MappingSystemController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("CampusMAP")]
        public IActionResult CampusMap()
        {
            return View(_context.Building.ToList());
        }

        [HttpGet]
        [Route("AddBuilding")]
        public IActionResult AddBuilding()
        {
            return View();
        }

        [HttpPost]
        [Route("AddBuilding")]
        public IActionResult AddBuilding(Building newBuilding)
        {
            if(ModelState.IsValid)
            {
                var currentBuilding = _context.Building.Where(model => model.Name.Equals(newBuilding.Name)).FirstOrDefault();

                if (currentBuilding == null)
                {
                    observer = new ObserverModel();
                    observer.addHistory(newBuilding.Latitude, newBuilding.Longitude);
                    HttpContext.Session.SetString("Observer", observer.ToString());
                    observer.addHistory(newBuilding.Latitude, newBuilding.Longitude);
                    _context.Building.Add(newBuilding);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("CampusMap");
        }
    }
}
