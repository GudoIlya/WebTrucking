using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TruckingServer.Models
{
    [Table("Driver")]
    public class Driver
    {
        public int driverID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime birthday { get; set; }

        public Driver()
        { }
    }
}
