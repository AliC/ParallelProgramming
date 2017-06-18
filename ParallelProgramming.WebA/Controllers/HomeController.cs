using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ParallelProgramming.WebA.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        private Adapter _adapter;

        public HomeController()
        {
            _adapter = new Adapter();
        }

        [Route("index/{waitFor:int}/{throw:bool}")]
        public async Task<string> Index(int waitFor, bool @throw)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            string recommendations = await _adapter.Get(waitFor, @throw);

            stopwatch.Stop();

            return $"{recommendations}  Time elapsed is {stopwatch.Elapsed}.";
        }
    }
}