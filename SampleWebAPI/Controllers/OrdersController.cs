using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private RepositoryAccess repositoryAccess = new RepositoryAccess();

        // GET: api/Orders
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Orders
        [HttpPost]
        public ContentResult Post([FromBody] Order order)
        {
            //Persist order 
            //Return Tracking number
            return new ContentResult
            {
                Content = repositoryAccess.PostOrder(order),
                StatusCode = StatusCodes.Status200OK
            };
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
