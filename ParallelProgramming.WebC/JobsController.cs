using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace ParallelProgramming.WebC.Controllers
{
    [RoutePrefix("jobs")]
    public class JobsController : ApiController
    {

        [Route("get/{waitFor:int}")]
        public string Get(int waitFor)
        {

            //Random random = new Random();
            //int nextRandom = random.Next(0, 11);
            //Thread.Sleep(nextRandom);

            Thread.Sleep(waitFor);

            return $"Hello from C.  Slept for {waitFor} seconds";
        }

    }
}