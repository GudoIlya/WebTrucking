using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TruckingServer.Models
{
    [Table("Car")]
    public class Car
    {
        public int carID { get; set; }

        public string model { get; set; }

        public string civicNumber { get; set; }

        public DateTime birthday { get; set; }

        public double carryCapacity { get; set; }
    }
}
