using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICA1WebApplication.Models;
using Microsoft.AspNet.Identity;

namespace ICA1WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //TODO figure out how to call Application user from outside of the Account Controller.
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}