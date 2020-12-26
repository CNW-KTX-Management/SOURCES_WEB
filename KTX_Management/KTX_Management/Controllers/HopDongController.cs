using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTX_Management.API;
using KTX_Management.Models;

namespace KTX_Management.Controllers
{
    public class HopDongController : Controller
    {
        //
        // GET: /HopDong/

        HopDongAPIController controller = new HopDongAPIController();

        public ActionResult HopDongMain()
        {
            return View();
        }

        public JsonResult GetListHopDong()
        {
            return Json(controller.GetListHopDong(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ChiTietHopDong(int id)
        {
            return Json(controller.ChiTietHopDong(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GoToChiTietHopDong(int id)
        {
            ViewBag.nhanVien = controller.GetNhanVienByHopDong(id);
            SinhVien sv = controller.GetSinhVienByHopDong(id);
            ViewBag.sinhVien = sv;
            ViewBag.room = controller.GetRoomByHopDong(id);
            ViewBag.listHoaDon = controller.GetListHoaDonBySinhVien(sv.Id);
            return View(controller.ChiTietHopDong(id));
        }

        public JsonResult CapNhatHopDong(HopDong hd)
        {
            return Json(controller.CapNhatHopDong(hd), JsonRequestBehavior.AllowGet);
        }
    }
}
