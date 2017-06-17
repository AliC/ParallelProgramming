﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParallelProgramming.WebB.Controllers
{
    public class Adapter
    {
        private HttpClient _client;
        private Uri _clientCBaseAddress = new Uri("http://localhost:9002");

        public Adapter()
        {
            _client = new HttpClient();
            _client.BaseAddress = _clientCBaseAddress;

        }
        public async Task<string> Get(int waitFor)
        {
            HttpResponseMessage response = await _client.GetAsync($"/jobs/get/{waitFor}");
            string bar = await response.Content.ReadAsAsync<string>();

            return bar;
        }
    }
}