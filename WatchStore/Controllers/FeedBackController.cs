using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchStore.Models;

namespace WatchStore.Controllers
{
    public class FeedBackController : Controller
    {
        dbQLBandhDataContext data = new dbQLBandhDataContext();
        // GET: FeedBack

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public ActionResult Lienhe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Lienhe(FormCollection collection, LIENHE lh)
        {
            var hoten = collection["HoTen"];
            var email = collection["Email"];
            var dienthoai = collection["DienthoaiKH"];
            var phanhoi = collection["Mess"];
            
                lh.HoTen = hoten;            
                lh.Email = email;           
                lh.DienthoaiKH = dienthoai;
                lh.Mess = phanhoi;
                data.LIENHEs.InsertOnSubmit(lh);
                data.SubmitChanges();
               
        

            return this.Lienhe();
        }
    }
    
}