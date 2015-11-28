using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financaas.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Este é um site de financas";
            return View();

        }

    }
}
