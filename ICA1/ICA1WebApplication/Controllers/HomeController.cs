using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICA1WebApplication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

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

            var store = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var userManager = new UserManager<ApplicationUser>(store);
            ApplicationUser user = userManager.FindByNameAsync(User.Identity.Name).Result;
            //use user.CreditCard to get the users creditcard it is passed as a string.

            Debug.WriteLine("Logged in Users Credit card is: " + user.CreditCard);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}