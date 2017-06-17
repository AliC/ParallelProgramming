using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ParallelProgramming.WebC.Controllers
{
    [RoutePrefix("jobs")]
    public class JobsController : ApiController
    {

        [Route("get")]
        public string Get()
        {
            return "Hello from C";
        }

    }
}