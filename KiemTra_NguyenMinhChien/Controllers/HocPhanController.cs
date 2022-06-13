using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KiemTra_NguyenMinhChien;
using KiemTra_NguyenMinhChien.Models;

namespace KiemTra_NguyenMinhChien.Controllers
{
    public class HocPhanController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: HocPhan
        public ActionResult Index()
        {
            var khoahoc = from sv in data.HocPhans select sv;
            return View(khoahoc);
        }
    }
}