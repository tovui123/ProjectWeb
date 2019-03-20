using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchStore.Models;
namespace WatchStore.Controllers
{
    public class WatchStoreController : Controller
    {
        dbQLBandhDataContext data = new dbQLBandhDataContext();
        private List<DONGHO> Laydonghomoi(int count) => data.DONGHOs.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        // GET: WatchStore
        public ActionResult Index()
        {
            var donghomoi = Laydonghomoi(8);
            return View(donghomoi);
        }
        public ActionResult Chude()
        {
            var chude = from cd in data.CHUDEs select cd;
            return PartialView(chude);
        }
        public ActionResult SPtheochude(int id)
        {
            var dongho = from dh in data.DONGHOs where dh.MaCD == id select dh;
            return View(dongho);
        }
        public ActionResult Details(int id)
        {
            var dongho = from dh in data.DONGHOs where dh.MaDH == id select dh;
            return View(dongho.Single());
        }
        public ActionResult AboutUS()
        {
            return View();
        }
        public ActionResult Shop()
        {
            var donghomoi = Laydonghomoi(16);
            return View(donghomoi);
        }

    }
}
