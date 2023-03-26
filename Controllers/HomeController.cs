using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ValidationsofAspNetcoreUserData.Models;

namespace ValidationsofAspNetcoreUserData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Prodact model)
        {
            if (!ModelState.IsValid) // validationa uygundurr mu ?
            {
                ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == ModelValidationState.Invalid).Errors[0].ErrorMessage;

                var message = ModelState.ToList();
                return View(model);
            }
            return View();
        }

        public IActionResult FluentValidationProdact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FluentValidationProdact(FluentProdact model)
        {
            if (!ModelState.IsValid) // validationa uygundurr mu ?
            {
                ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == ModelValidationState.Invalid).Errors[0].ErrorMessage;

                var message = ModelState.ToList();
                return View(model);
            }
            return View();
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