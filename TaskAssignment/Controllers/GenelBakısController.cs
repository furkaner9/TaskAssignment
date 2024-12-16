using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskAssignment.Models.DateContext;

namespace TaskAssignment.Controllers
{
    public class GenelBakısController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();
        // GET: GenelBakıs
        public ActionResult Index()
        {
            int projesayisi =db.PersonelProjeleri.Count();
            ViewBag.Projesayisi = projesayisi;




            int tamamlanmisProje=db.PersonelProjeleri.Where(p=>p.TamamlanmaDurumu==true).Count();
            ViewBag.TamamlanmisProje=tamamlanmisProje;



            var yuksekoncelikliProjeler = db.PersonelProjeleri.Where(p => p.OncelıkDurumu == "Yüksek Öncelikli").Count();
            ViewBag.YüksekOncelikliProje=yuksekoncelikliProjeler;

            var dusukoncelikliProje = db.PersonelProjeleri.Where(p => p.OncelıkDurumu == "Düşük Öncelikli").Count();
            ViewBag.DusukOncelikliProje = dusukoncelikliProje;



            var ortaoncelikliProje = db.PersonelProjeleri.Where(p => p.OncelıkDurumu == "Orta Öncelikli").Count();
            ViewBag.OrtaOncelikliProje = ortaoncelikliProje;






            return View();
        }
    }
}