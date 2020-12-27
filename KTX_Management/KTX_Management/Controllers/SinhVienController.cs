using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTX_Management.Models;

namespace KTX_Management.Controllers
{
        public class SinhVienController : Controller
        {
            //
            // GET: /SinhVien/
            DatabaseDataContext data = new DatabaseDataContext();
            public ActionResult Index()
            {
                return View();
            }
            public JsonResult ListSinhVien()
            {
                List<SinhVien> list = data.SinhViens.ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            [HttpPost]
            public JsonResult AddSinhVien(SinhVien sv)
            {
                int kq = 1;
                try
                {
                    data.SinhViens.InsertOnSubmit(sv);
                    data.SubmitChanges();
                }
                catch
                {
                    kq = 0;
                }

                return Json(kq, JsonRequestBehavior.AllowGet);
            }
            [HttpPost]
            public JsonResult EditSinhVien(SinhVien sv)
            {
                int kq = 1;
                try
                {
                    var f = data.SinhViens.FirstOrDefault(x => x.Id == sv.Id);
                    f.MSSV = sv.MSSV;
                    f.Name = sv.Name;
                    f.NgaySinh = sv.NgaySinh;
                    f.Phone = sv.Phone;
                    f.Passport = sv.Passport;
                    f.GioiTinh = sv.GioiTinh;
                    data.SubmitChanges();
                }
                catch
                {
                    kq = 0;
                }
                return Json(kq, JsonRequestBehavior.AllowGet);
            }
            public JsonResult DetailSinhVien(int id)
            {
                var sinhvien = data.SinhViens.FirstOrDefault(x => x.Id == id);
                return Json(sinhvien, JsonRequestBehavior.AllowGet);
            }
            public JsonResult DeleteSinhVien(int id)
            {
                int kq = 1;
                try
                {
                    var nv = data.SinhViens.FirstOrDefault(x => x.Id == id);
                    data.SinhViens.DeleteOnSubmit(nv);
                    data.SubmitChanges();
                }
                catch
                {
                    kq = 0;
                }

                return Json(kq, JsonRequestBehavior.AllowGet);
            }
        }
}
