using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTX_Management.API;
using KTX_Management.Models;

namespace KTX_Management.Controllers
{
    public class ThanhToanController : Controller
    {
        //
        // GET: /ThanhToan/
        ThanhToanAPIController controller = new ThanhToanAPIController();


        public ActionResult Index()
        {
            return View();
        }

        public JsonResult InitThanhToan()
        {
            return Json(controller.GetListRoom(), JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetGiaDien()
        {
            return Json(controller.GetGiaDien(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetGiaNuoc()
        {
            return Json(controller.GetGiaNuoc(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetNhanVien()
        {
            return Json(controller.GetNhanVien(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetListSinhVienByRoom(int id)
        {
            return Json(controller.GetListSinhVienByRoom(id), JsonRequestBehavior.AllowGet);
        }  
        
        public JsonResult XacNhanThanhToan(HoaDon hd)
        {
            return Json(controller.XacNhanThanhToan(hd), JsonRequestBehavior.AllowGet);
        }
    }
}
