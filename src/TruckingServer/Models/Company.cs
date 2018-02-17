using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TruckingServer.Models
{
    [Table("Company")]
    public class Company
    {
        public int companyID { get; set; }

        public string name { get; set; }

        public string adress { get; set; }

        public Company()
        { }
    }
}
