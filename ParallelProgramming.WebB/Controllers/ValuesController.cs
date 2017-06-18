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

        [Route("get/{waitFor:int}/{throw:bool}")]
        public async Task<JobContainer> Get(int waitFor, bool @throw)
        {
            JobContainer jobcontainer = await _adapter.Get(waitFor, @throw);

            return jobcontainer;
        }
    }
}
