using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TruckingServer.Models
{
    [Table("Contract")]
    public class Contract
    {
        public int contractID { get; set; }

        public string num { get; set; }

        public DateTime date { get; set; }

        public decimal price { get; set; }

        public bool isOurCar { get; set; }

        public Driver Driver { get; set; }

        public Car Car { get; set; }

        public Company Company { get; set; }

        public Contract()
        { }
    }
}
