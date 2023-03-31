using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class MateriaController : Controller
    {
        [HttpGet] //Action VERB
        public ActionResult GetAll() //Action Method
        {
            ML.Materia materia = new ML.Materia();
            ML.Result result = BL.Materia.GetAll();

            materia.Materias = result.Objects;

            return View(materia);//Mandar a llamar a la vista, mostrar la vista(HTML)
        }

    }
}