using Microsoft.AspNetCore.Mvc;
using SimpleListMvcNet.Models;
using SimpleListMvcNet.Services;
using SimpleListMvcNet.Services.Interfaces;
using System.Diagnostics;

namespace SimpleListMvcNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPeopleService _peopleService;

        public HomeController(ILogger<HomeController> logger, IPeopleService peopleService)
        {
            _logger = logger;
            _peopleService = peopleService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var lista = await _peopleService.GetPeople();
                return View(lista);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new JsonResult(null);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}