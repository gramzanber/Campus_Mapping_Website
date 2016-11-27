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
      public int Buildingid { get; set; }
      public string Name { get; set; }
      public double Latitude { get; set; }
      public double Longitude { get; set; }
   }
}
