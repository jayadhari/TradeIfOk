using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeIfOk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.UnderConstruction = "http://www.ict-romeo.eu/images/Under-Construction.gif";
            ViewBag.MorningImage = "https://sites.google.com/a/tradeifok.com/resources/home/morning.PNG";
            ViewBag.NoonImage = "https://sites.google.com/a/tradeifok.com/resources/home/noon.PNG";
            ViewBag.EveningImage = "https://sites.google.com/a/tradeifok.com/resources/home/Evening.PNG";
            ViewBag.NightImage = "https://sites.google.com/a/tradeifok.com/resources/home/night.PNG";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
