using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class HomeController : Controller
    {
        // Home Page
        public ActionResult Index()
        {
            return View();
        }

        // Feedback Page - GET
        [HttpGet]
        public ActionResult Feedback()
        {
            return View();
        }

        // Feedback Page - POST
        [HttpPost]
        public ActionResult Feedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] =
                    "Thank you " + feedback.Name + "! Your feedback has been submitted successfully.";

                return RedirectToAction("Feedback");
            }

            return View(feedback);
        }
    }
}