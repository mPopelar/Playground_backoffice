using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlatformApi.QueryHandlers;
using PlatformApi.Queries;
using System.Linq;
using System.Diagnostics;

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
            Debug.WriteLine($"Debug message...this is value: {value}");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            Debug.WriteLine($"Debug message...this is id: {id} and this is value: {value}");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
