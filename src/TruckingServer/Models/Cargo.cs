using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TruckingServer.Models
{
    [Table("Cargo")]
    public class Cargo
    {
        public int cargoID { get; set; }

        public string name { get; set; }

        public bool isKeepUpTemperatures { get; set; }

        public double temperatures { get; set; }

        public Cargo()
        { }
    }
}
