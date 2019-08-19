using JT_Guess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JT_Guess.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Number msg = new Number();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            //public string GetMessage(int guess)
            //{
            //    if (guess <= RandomNumber)
            //    {
            //        Msg = "Too Low";
            //    }
            //    else if (guess >= RandomNumber)
            //    {
            //        Msg = "Too High";
            //    }
            //    else
            //    {
            //        Msg = "Nailed It";
            //    }
            //    return Msg;
            //}

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}