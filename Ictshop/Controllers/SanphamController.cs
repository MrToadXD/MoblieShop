using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();

        // GET: Sanpham
        public ActionResult dtiphonepartial()
        {
            var ip = db.Sanphams.Where(n=>n.Mahang==2).Take(4).ToList();
           return PartialView(ip);
        }
        public ActionResult dtsamsungpartial()
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 1).Take(4).ToList();
            return PartialView(ss);
        }
        public ActionResult dtxiaomipartial()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();
            return PartialView(mi);
        }
        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

        public ActionResult timkiem(string searchTerm)
        {
            // Kiểm tra xem searchTerm có tồn tại không
            if (string.IsNullOrEmpty(searchTerm))
            {
                // Nếu không, trả về tất cả các dữ liệu (hoặc bạn có thể trả về một trang tìm kiếm trống)
                var allData = db.Sanphams.ToList(); // Thay thế "YourModel" bằng tên thực tế của mô hình của bạn
                return View(allData);
            }

            // Nếu có searchTerm, thực hiện tìm kiếm trong cơ sở dữ liệu
            var searchResults = db.Sanphams.Where(x => x.Tensp.ToLower().Contains(searchTerm.ToLower())).ToList();

            return View(searchResults);
        }

    }

}