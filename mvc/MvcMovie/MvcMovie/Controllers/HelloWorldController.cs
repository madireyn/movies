using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld.Welcome/

        public ActionResult Welcome(string name, int NumTimes = 1)
        {
            ViewBag.message = "Hello " + name;
            // ViewBag.mensaje = "Hola, como estas " + name + "?";
            ViewBag.NumTimes = NumTimes;

            return View();
        }
    }
}