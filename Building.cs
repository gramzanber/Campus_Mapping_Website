using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UCOGPS.Models
{
   public class Building
   {
      [Key]
      public int BuildingId { get; set; }
      public string Name { get; set; }
      public string Latitude { get; set; }
      public int Longitude { get; set; }
   }
}
