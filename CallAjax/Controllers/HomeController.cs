using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JsonTeste(Teste teste)
        {
            var result = new ResultCall();
            result.Message = "Ok";

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult JsonTesteGetData()
        {
            var result = new Teste();
            result.Nome = "AAAA";
            result.Sobrenome = "BBBB";

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }

    public class Teste
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }
    }

    public class ResultCall
    {
        public string Message { get; set; }
    }
}