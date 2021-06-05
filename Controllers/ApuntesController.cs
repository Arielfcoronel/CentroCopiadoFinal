using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;

namespace Presentacion.Controllers
{
    public class ApuntesController : Controller
    {
        // GET: Apuntes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarApuntes()
        {
            List<VentaApunte> lsitadoApuntes = VentaApunte.ListarApuntes();
            return View(lsitadoApuntes);
        }

        public ActionResult VentasApuntes()
        {
            return View();
        }
    }
}