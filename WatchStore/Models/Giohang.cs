using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchStore.Models;

namespace WatchStore.Models
{
    public class Giohang
    {
        dbQLBandhDataContext data = new dbQLBandhDataContext();
        public int iMaDH { set; get; }
        public string sTenDH { set; get; }
        public string sAnhbia { set; get; }
        public Double dDongia { set; get; }
        public int iSoluong { set; get; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
          
        }

        public Giohang(int MaDH)
        {
            iMaDH = MaDH;
            DONGHO dongho = data.DONGHOs.Single(n => n.MaDH == iMaDH);
            sTenDH = dongho.TenDH;
            sAnhbia = dongho.Anhbia;
            dDongia = double.Parse(dongho.Giaban.ToString());
         
            iSoluong = 1;
        }
    }
}