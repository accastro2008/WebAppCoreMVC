using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAppCoreMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*public string Index()
        {
            return View();
            //return "Controller HelloWorld - Método: Index";
        }*/

        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Msg"] = "Olá " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
