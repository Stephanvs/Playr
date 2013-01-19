using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace Play.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JToken> GetQueue()
        {
            var client = new HttpClient();
            //var request = CreateRequest(HttpMethod.Get,  Helpers.BuildApiUrl("/Queue"), Request.IsAuthenticated);

            var request = new HttpRequestMessage(HttpMethod.Get, Helpers.GetApiUrl() + "/Queue");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<JToken>();
        }
    }
}
