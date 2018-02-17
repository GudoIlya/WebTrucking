using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TruckingServer.context;
using TruckingServer.Models;

namespace TruckingServer.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private TruckingContext db;

        public ValuesController (TruckingContext db)
        {
            this.db = db;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Car car = new Car();
            car.model = "foo";
            db.Cars.Add(car);
            db.SaveChanges();
                return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
