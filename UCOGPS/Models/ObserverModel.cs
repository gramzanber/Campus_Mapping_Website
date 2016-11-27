using Microsoft.AspNet.Http;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCOGPS.Models
{
    public class ObserverModel : DbContext
    {
        private string username;
        double lat;
        double lng;

        public ObserverModel()
        {

        }
        public void addHistory(double lat, double lng) { this.lat = lat;  this.lng = lng; }

        public string ToString()
        {
            return lat + "," + lng; 
        }
    }
}