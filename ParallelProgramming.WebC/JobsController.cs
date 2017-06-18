using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace ParallelProgramming.WebC.Controllers
{
    [RoutePrefix("jobs")]
    public class JobsController : ApiController
    {

        [Route("get/{waitFor:int}/{throw:bool}")]
        public async Task<Recommendations> Get(int waitFor, bool @throw)
        {
            if (@throw)
            {
                ThrowException(waitFor);
            }

            return await Task.FromResult(GetRecommendations(waitFor));
        }

        private void ThrowException(int waitFor)
        {
            Sleep(waitFor);

            HttpResponseMessage errorResponse = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, new Exception("Internal Server Error in Web C"));

            throw new HttpResponseException(errorResponse);
        }

        private Recommendations GetRecommendations(int waitFor)
        {
            Sleep(waitFor);

            int[] jobIds = new[] { waitFor + 100, waitFor + 101, waitFor + 102 };

            return new Recommendations { SiteId = 4, JobIds = jobIds };
        }

        private void Sleep(int waitFor)
        {
            Thread.Sleep(waitFor * 1000);
        }
    }
}