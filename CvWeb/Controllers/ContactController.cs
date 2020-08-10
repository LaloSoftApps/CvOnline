using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CvWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            string email = "gsantilli@gmail.com";

            ViewData["EMail"] = email;

            return View();
        }
    }
}
