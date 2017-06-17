using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParallelProgramming.WebA.Controllers
{
    public class Adapter
    {
        private HttpClient _client;
        private Uri _clientBBaseAddress = new Uri("http://localhost:9001");

        public Adapter()
        {
            _client = new HttpClient();
            _client.BaseAddress = _clientBBaseAddress;

        }
        public string Get()
        {
            var foo = _client.GetAsync("/").Result;
            var bar = foo.Content.ReadAsStringAsync().Result;

            return bar;
        }
    }
}