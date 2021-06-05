using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class ProfesoreController : Controller
    {
        // GET: Profesores
        public ActionResult Index()
        {
            return View();
        }
    }
}