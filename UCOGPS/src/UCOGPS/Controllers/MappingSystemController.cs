using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using UCOGPS.Models;

namespace UCOGPS.Controllers
{
    public class MappingSystemController : Controller
    {
        private AppDbContext _context;

        public MappingSystemController(AppDbContext context)
        {
            _context = context;
        }

        [Route("CampusMAP")]
        public IActionResult CampusMap()
        {
            return View(_context.Building.ToList());
        }

        [HttpPost]
        public IActionResult getDirections()
        {
            return RedirectToAction("CampusMap");
        }

        public IActionResult fromLocation(string buildingName)
        {
            return getLocation(buildingName);
        } 

        public IActionResult toLocation(string buildingName)
        {
            return getLocation(buildingName);
        }

        public IActionResult getLocation(string buildingName)
        {
            var building = _context.Building.Where(model => model.Name.Equals(buildingName)).FirstOrDefault();

            if (building != null)
                return Json(new { lat = building.Latitude, lng = building.Longitude });
                
            //else
                //notify user of invalid startBuilding
                return HttpNotFound(building);
        }
    }
}
