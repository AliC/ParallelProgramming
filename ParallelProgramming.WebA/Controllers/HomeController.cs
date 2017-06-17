using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ParallelProgramming.WebA.Controllers
{
    public class HomeController : Controller
    {
        private Adapter _adapter;

        public HomeController()
        {
            _adapter = new Adapter();
        }

        public async Task<string> Index(int waitFor)
        {

            //string foo = "Hello from A";
            string foo = await _adapter.Get(waitFor);

            return foo;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}