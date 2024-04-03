using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TOPZONE.App_Start;

namespace TOPZONE.Controllers
{
    public class HomeController : Controller
    {
        private TopzoneEntities db = new TopzoneEntities();
        public ActionResult Index()
        {
            var sanPham = db.SanPham.OrderBy(x => x.MaLoaiSP);
            return View(sanPham.ToList());
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        public ActionResult GioHang()
        {
            return View();
        }
    }
}