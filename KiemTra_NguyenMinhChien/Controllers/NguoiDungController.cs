using KiemTra_NguyenMinhChien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenMinhChien.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        MyDataDataContext data = new MyDataDataContext();
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var MaSV = collection["MaSV"];
            SinhVien sv = data.SinhViens.SingleOrDefault(n => n.MaSV == MaSV);
            if (sv != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TaiKhoan"] = sv;
            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return RedirectToAction("Index", "SinhVien");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}