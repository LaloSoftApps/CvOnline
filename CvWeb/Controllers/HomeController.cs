using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CvWeb.Models;

namespace CvWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            if (id == null)
            {
                id = "28308948";
            }
            ViewData["id"] = id;

            // Obtenemos los datos del JSON
            var oJson = new JsonFileRead();
            // oJson.FilePath = Environment.CurrentDirectory + "/Data/cv_28308948.json";
            oJson.FilePath = $"{Environment.CurrentDirectory}/wwwroot/data/{id}/cv.json";

            try
            {
                var JsonData = oJson.Call();
                ViewData.Model = JsonData;
            } catch(ApplicationException ex)
            {
                ViewData["Error"] = ex.Message;
                return View("~/Views/Shared/Error.cshtml");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
