using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTX_Management.Models;

namespace KTX_Management.Controllers
{
    public class NhanVienController : Controller
    {
        //
        // GET: /NhanVien/
        DatabaseDataContext data = new DatabaseDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ListNhanVien()
        {
            List<NhanVien> list = data.NhanViens.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddNhanVien(NhanVien nv)
        {
            int kq = 1;
            try
            {
                data.NhanViens.InsertOnSubmit(nv);
                data.SubmitChanges();
            }
            catch
            {
                kq = 0;
            }

            return Json(kq, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult EditNhanVien(NhanVien nv)
        {
            int kq = 1;
            try
            {
                var f = data.NhanViens.FirstOrDefault(x => x.Id == nv.Id);
                f.Name = nv.Name;
                f.ChucVu = nv.ChucVu;
                f.Phone = nv.Phone;
                f.DiaChi = nv.DiaChi;
                f.GioiTinh = nv.GioiTinh;
                f.Status = nv.Status;
                f.User = nv.User;
                f.Password = nv.Password;
                data.SubmitChanges();
            }
            catch
            {
                kq = 0;
            }

            return Json(kq, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DetailNhanVien(int id)
        {
            var nhanVien = data.NhanViens.FirstOrDefault(x => x.Id == id);
            return Json(nhanVien, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteNhanVien(int id)
        {
            int kq = 1;
            try
            {
                var nv = data.NhanViens.FirstOrDefault(x => x.Id == id);
                data.NhanViens.DeleteOnSubmit(nv);
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
