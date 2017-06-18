using System;
using System.Net;
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

        public async Task<string> Get(int waitFor, bool @throw)
        {
            HttpResponseMessage response = await _client.GetAsync($"/jobs/get/{waitFor}/{@throw}");

            response.EnsureSuccessStatusCode();  //TODO ADC: is this what we're not doing at this point?  Do we have serialization exceptions when Carl's endpoint returns 500?

            string bar = await response.Content.ReadAsStringAsync(); //Note ADC: just return the raw string to the client

            return bar;
        }
    }
}