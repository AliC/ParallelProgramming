using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ParallelProgramming.WebB.Controllers
{

    [RoutePrefix("jobs")]
    public class ValuesController : ApiController
    {
        private Adapter _adapter;

        public ValuesController()
        {
            _adapter = new Adapter();
        }

        [Route("get/{waitFor:int}")]
        public async Task<string> Get(int waitFor)
        {
            //return "Hello from B";

            string foo = await _adapter.Get(waitFor);

            return foo;
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
