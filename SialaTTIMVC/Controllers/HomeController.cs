using Microsoft.AspNetCore.Mvc;
using SialaTTIMVC.Models;
using System.Diagnostics;

namespace SialaTTIMVC.Controllers
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
            var model = new LoginModel();
            return View(model);
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Fee()
        {
            return View();
        }
        public IActionResult FeeStatement()
        {
            return View();
        }
        public IActionResult FeeStructure()
        {
            return View();
        }
        public IActionResult LecturerEvaluation()
        {
            return View();
        }
        public IActionResult ProformaInvoice()
        {
            return View();
        }
        public IActionResult ProvisionalResults()
        {
            return View();
        }
        public IActionResult ProvisionalTranscript()
        {
            return View();
        }
        public IActionResult SemRegister() {
            return View();

        }
        public IActionResult SpecialExams()
        {
            return View();
        }
        public IActionResult UnitRegistration() {
            return View();
        }
        public IActionResult UpdateProfile()
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
