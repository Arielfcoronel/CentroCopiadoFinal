using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Inicio()
        //{
        //    N_Usuario usaurio = N_Usuario.ObtenerPorUsuario(Request.Form["Usuario"], Request.Form["Password"]);

        //    if (usaurio.IdUsuario != 0)
        //    {
        //        Session["Usuario"] = N_Usuario.Listar().Where(x => x.Email == usaurio.Email).FirstOrDefault();

        //        return RedirectToAction("Index", "Usuario");
        //    }
        //    else

        //    {
        //        return RedirectToAction("Error", "Home", new { message = " Usuario o Contraseña incorrecta" });

        //    }
        //}

        [HttpPost]
        public JsonResult Inicio()
        {
            Resultado resultado = new Resultado();

            try
            {
                Session["Usuario"] = N_Usuario.ObtenerPorUsuario(Request.Form["Usuario"].ToString(), Request.Form["Password"].ToString());

                resultado.EsCorrecto = true;
                resultado.Mensaje = "";

                return Json(resultado);

            }
            catch (Exception ex)
            {
                resultado.EsCorrecto = false;
                resultado.Mensaje = ex.Message;

                return Json(resultado);
            }

        }


        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }
    }
}