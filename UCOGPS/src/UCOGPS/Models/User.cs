using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UCOGPS.Models
{
    public class User
    {
        [Key]
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int LastStartingBuilding{ get; set; }
        public int LastDestinationBuilding { get; set; }
    }
}
