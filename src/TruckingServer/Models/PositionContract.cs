using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TruckingServer.Models
{
    [Table("PositionContract")]
    public class PositionContract
    {
        public int positionContractID { get; set; }

        public double weignt { get; set; }

        public Cargo Cargo { get; set; }
    }
}
