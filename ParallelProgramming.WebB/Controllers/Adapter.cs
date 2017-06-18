using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<JobContainer> Get(int waitFor, bool @throw)
        {
            HttpResponseMessage response = await _client.GetAsync($"/jobs/get/{waitFor}/{@throw}");

            response.EnsureSuccessStatusCode();

            RecommendedJobs recommendedJobs = await response.Content.ReadAsAsync<RecommendedJobs>();

            List<Job> jobs = new List<Job>();
            foreach(int jobId in recommendedJobs.JobIds)
            {
                jobs.Add(new Job { JobId = jobId, JobTitle = "Adding this job title" });
            }

            return new JobContainer { SiteId = recommendedJobs.SiteId, jobs = jobs };

        }
    }
}