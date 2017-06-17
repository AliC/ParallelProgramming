using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using ParallelProgramming.WebA.Controllers;

namespace Acceptance.WebATests
{
    public class UnitTest1
    {
        private HttpClient _client;

        [SetUp]
        public void SetUp()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost");
        }

        [Test]
        public void TestMethod1()
        {
            //var controller = new HomeController();
            //ContentResult result = controller.Index() as ContentResult;

            //Assert.IsNotNull(result);
        }

        [Test]
        public async Task call_homeindex_via_http()
        {
            Uri uri = new Uri("/jobs/get", UriKind.Relative);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri);
            HttpResponseMessage response = await _client.SendAsync(request);

            Assert.IsNotNull(response);

        }
    }
}
