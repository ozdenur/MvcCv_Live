using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;  

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DBCvEntities3 db=new DBCvEntities3();
        public ActionResult Index()
        {
            var degerler= db.TblHakkimda.ToList();
            return View(degerler);
        }  
        public PartialViewResult Deneyim()
        {
            return PartialView();
        }
    }
} 