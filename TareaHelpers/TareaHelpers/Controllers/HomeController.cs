using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TareaHelpers.Models;

namespace TareaHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            TDatos datos = control();

            return View(datos);
        }

        [HttpPost]
        public ActionResult Formulario(TDatos user)
        {


            if (ModelState.IsValid)
            {
                StringBuilder dato = new StringBuilder();
                foreach (var kategori in user.Hobbys)
                {
                    if (kategori.Valor)
                    {
                        dato.Append(kategori.NombreHobbysId + ", ");

                    }
                }
                TempData["hobbys"] = dato;
                return RedirectToAction("MostrarDatos", user);
            }
            return View(user);
        }

        public ActionResult MostrarDatos(TDatos user)
        {


            if (TempData["hobbys"] != null)
            {
                ViewBag.hobbys = TempData["hobbys"].ToString();
            }

            return View(user);
        }

        private TDatos control()
        {
            TDatos model = new TDatos();
            model.Hobbys = new List<ControlIds>
            {
                new ControlIds{HobbysId=1, NombreHobbysId="Baloncesto"},
                new ControlIds{HobbysId=2, NombreHobbysId="Cocinar"},
                new ControlIds{HobbysId=3, NombreHobbysId="Montar Bicicleta"},
                new ControlIds{HobbysId=4, NombreHobbysId="Programar"},
            };
            return model;
        }


    }
}
