using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParqueaderoMatt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Administración del parqueadero de Mattelsa sede central.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Información de contacto.";

            return View();
        }
    }
}