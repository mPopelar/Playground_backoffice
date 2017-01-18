using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlatformApi.QueryHandlers;
using PlatformApi.Queries;
using System.Linq;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IGetClientsQueryHandler _clientsQueryHandler;

        public ValuesController(IGetClientsQueryHandler clientsQueryHandler)
        {
            _clientsQueryHandler = clientsQueryHandler;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var clients = _clientsQueryHandler.Execute(new GetClientsQuery());

            return clients.Select(x => x.Name).ToList();
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
