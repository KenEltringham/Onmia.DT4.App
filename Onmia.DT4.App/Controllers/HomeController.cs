using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Onmia.DT4.App.Models;
using Onmia.DT4.App.Services;
using System.Diagnostics;

namespace Onmia.DT4.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string _apiBaseURL;

        public HomeController(ILogger<HomeController> logger,IOptions<ApiSettings> apiSettings)
        {
            _logger = logger;
            _apiBaseURL = apiSettings.Value.BaseURL;

        }

        public async Task<IActionResult> Index()
        {
            var data = await GetProsodicsAsync();
            return View(data);

        }
        public async Task<ProsodicModel> GetProsodicsAsync()
        {
            ProsodicModel prosodic;
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_apiBaseURL);
                using (HttpResponseMessage response = await httpClient.GetAsync("/api/prosodic/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    prosodic = JsonConvert.DeserializeObject<ProsodicModel>(apiResponse);
                }
            }
            return prosodic;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
