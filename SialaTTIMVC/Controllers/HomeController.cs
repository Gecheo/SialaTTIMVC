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

        /************************* LOGIN ******************************************/

        public IActionResult Index()
        {
            var model = new LoginModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Please fill the form with correct details...");
                return View(model);
            }
            else
            {
                if(model.StudentNumber != null)
                {
                    HttpContext.Session.SetString("studentNo", model.StudentNumber);
                }
               
                return RedirectToAction("Dashboard", "Home");

            }
          
        }


        /***************************** Forgot Password *********************************/
        public IActionResult ForgotPassword()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

       
        /***************************** Change Password *********************************/
        public IActionResult ChangePassword()
        {
            var model = new ChangePassModel();
            if (HttpContext.Session.GetString("studentNo")== null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Please fill All the boxes");
                    return View();
                }

                return View(model);

            }
            
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePassModel passModel)
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (passModel == null)
                {
                    return View();
                }
                if (passModel.NewPassword != passModel.ConfirmPassword)
                {
                    ModelState.AddModelError(string.Empty, "The Passwords do Not Match!!");
                }

                return View();
            }
        }

        public IActionResult Privacy()
        {

            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        /***************************** Dashboard *********************************/
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
               return View();

            }

        }

        /***************************** Fee *********************************/
        public IActionResult Fee()
           
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        /***************************** Fee Statement *********************************/
        public IActionResult FeeStatement()
        {
            return View();
        }
        /***************************** Fee Structure *********************************/
        public IActionResult FeeStructure()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        /***************************** Lecturer Evaluation *********************************/
        public IActionResult LecturerEvaluation()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index)); ;
            }
            else
            {
                return View();
            }
        }

        /***************************** Proforma Invoice *********************************/
        public IActionResult ProformaInvoice()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        /***************************** Provisional results *********************************/
        public IActionResult ProvisionalResults()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        /***************************** Transcript *********************************/
        public IActionResult ProvisionalTranscript()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public IActionResult SemRegister() {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }
        public IActionResult SpecialExams()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public IActionResult UnitRegistration() {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public IActionResult UpdateProfile()
        {
            if (HttpContext.Session.GetString("studentNo") == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public IActionResult Logout(string session)
        {
            session = string.Empty;
            HttpContext.Session?.Clear();
            return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
