using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBlog_teste.Models;

namespace WebBlog_teste.Controllers
{
    public class NoticiaController : Controller
    {
        // GET: Noticia
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult catalogo()
        {
            List<NoticiaModel> lista = new List<NoticiaModel>();

         for (var x = 0; x < 10; x++) ;
            NoticiaModel noticia = new NoticiaModel();
            noticia.titulo = "Titulo 1";
            noticia.resumo = "xxxxxxx";
            noticia.dataPublicacao = DateTime.Now;

            lista.Add(noticia);

            return Json(new { Data = noticia }, JsonRequestBehavior.AllowGet);
        }

    }
}