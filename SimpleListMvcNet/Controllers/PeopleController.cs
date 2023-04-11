using Microsoft.AspNetCore.Mvc;
using SimpleListMvcNet.Services;
using SimpleListMvcNet.Services.Interfaces;

namespace SimpleListMvcNet.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPeopleService _peopleService;

        public PeopleController(ILogger<HomeController> logger , IPeopleService peopleService)
        {
            _peopleService= peopleService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task <JsonResult> GetPeople()
        {
            try
            {
                return new JsonResult(await _peopleService.GetPeople());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new JsonResult(null);
            }
        }
    }
}
