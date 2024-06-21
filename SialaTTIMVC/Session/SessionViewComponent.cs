using Microsoft.AspNetCore.Mvc;

    namespace SialaTTIMVC.Session
{
    public class SessionViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            var username = HttpContext.Session.GetString("studentNo");
            return View("Default",username);
        }
    }
}
