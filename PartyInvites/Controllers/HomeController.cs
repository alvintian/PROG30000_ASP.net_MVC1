using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;
namespace PartyInvites.Controllers
{
    // HomeController class inherits from the Controller base class and
    // is responsible for handling HTTP requests directed to the home page
    public class HomeController : Controller
    {
        // The Index method returns a view of the home page.
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }

        }
    }
}
