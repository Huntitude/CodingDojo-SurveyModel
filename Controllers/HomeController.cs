using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;


namespace DojoSurvey
{

    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]
        public IActionResult Result(Survey mySurvey)
        {
            // string name, string location, string language, string textarea
            // ViewBag.name = name;
            // ViewBag.location = location;
            // ViewBag.language = language;
            // ViewBag.textarea = textarea;
            return View("Result", mySurvey);
        }

        [HttpGet("result")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}

       



