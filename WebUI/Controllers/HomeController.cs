using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        ServisEntities db = new ServisEntities();

        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public ActionResult Login() {
        return View();
        }

        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            try
            {
                var result = db.Kullanici.Where(w => w.KullaniciAdi.Equals(kullanici.KullaniciAdi) && w.Sifre.Equals(kullanici.Sifre)).SingleOrDefault();
            
                if (result == null)
                {
                    ViewBag.Notification = "Kullanıcı adı veya şifre hatalı!";
                    return View();
                }
                else
                {
                    Session["idSS"] = result.ID.ToString();
                    Session["usernameSS"] = result.KullaniciAdi.ToString();
                    return RedirectToAction("metod", "controller", new { id = result.ID });
                }

            }
            catch(Exception exc) { 
            
                return View();
            }
            
        }
    }
}