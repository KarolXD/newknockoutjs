using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Knockoutjs.Controllers
{
    public class HomeController : Controller
    {
        NEGOCIO.Negocio_Persona metodos = new NEGOCIO.Negocio_Persona();
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Registrar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       

        // POST: Home/Create
        [System.Web.Mvc.HttpPost]
        public string Create(Persona persona)
        {
            if (!ModelState.IsValid) return "Model is invalid";
            else
            {
                
                metodos.registrar(persona);
                return " Persona registrada";
            }
        }



        public ActionResult Leer()
        {
            return View();
        }
        //GET All Courses
        public JsonResult Listar()
        {
            return Json(metodos.listado(), JsonRequestBehavior.AllowGet);
        }


    }
}