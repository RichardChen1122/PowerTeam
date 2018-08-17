using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerTeam.Service.Interface;

namespace PowerTeam.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IDeliveryService _deliveryService;
        public ValuesController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _deliveryService.TestMethod();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
