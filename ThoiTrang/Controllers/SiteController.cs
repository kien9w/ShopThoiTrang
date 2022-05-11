using MyClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThoiTrang.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            ThoiTrangDBContext db = new ThoiTrangDBContext();
            int somau = db.Products.Count();
            ViewBag.Somau = somau;
            return View();
        }
    }
}