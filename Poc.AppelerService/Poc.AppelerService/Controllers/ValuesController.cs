using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Poc.AppelerService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<string> Get()
        {
            //return new string[] { "value1", "value2" };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://helloworld-testservices.193b.starter-ca-central-1.openshiftapps.com");
            HttpResponseMessage reponse = await client.GetAsync("api/Values");
            return "Réponse du service : " + await reponse.Content.ReadAsStringAsync();
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
