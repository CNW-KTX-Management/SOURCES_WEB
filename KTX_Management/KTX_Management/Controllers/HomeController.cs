using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTX_Management.Mapper;
using KTX_Management.Models;

namespace KTX_Management.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DatabaseDataContext data = new DatabaseDataContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection col)
        {
            NhanVien kh = data.NhanViens.SingleOrDefault(k => k.User == col["txtUser"] && k.Password == col["txtPass"]);
            if (kh != null)
            {
                Session["kh"] = kh;
                return RedirectToAction("HopDongMain", "HopDong");
            }
            return View();
        }

        public ActionResult Index()
        {
            return RedirectToAction("HopDongMain", "HopDong");
        }



        public List<GetHoaDon> GetListHoaDon()
        {
            List<GetHoaDon> listReturn = new List<GetHoaDon>();
            List<HoaDon> dsHD = data.HoaDons.ToList();
            foreach (HoaDon hd in dsHD)
            {
                NhanVien nv = data.NhanViens.FirstOrDefault(n => n.Id == hd.IdNhanVien);
                Dien dien = data.Diens.FirstOrDefault(d => d.Id == hd.IdDien);
                Nuoc nuoc = data.Nuocs.FirstOrDefault(n => n.Id == hd.IdNuoc);
                Room room = data.Rooms.FirstOrDefault(r => r.Id == hd.IdRoom);
                GetHoaDon contact = new GetHoaDon();

                contact.Id = hd.Id;
                contact.TenRoom = room.TenPhong;
                contact.TenNhanVien = nv.Name;
                contact.GiaDien = (int)dien.GiaDien;
                contact.GiaNuoc = (int)nuoc.GiaNuoc;
                contact.SoDienCu = hd.SoDienCu;
                contact.SoDienMoi = hd.SoDienMoi;
                contact.SoNuocCu = hd.SoNuocCu;
                contact.SoNuocMoi = hd.SoNuocMoi;
                contact.NgayLap = hd.NgayLap;
                contact.ThanhTien = hd.ThanhTien;

                listReturn.Add(contact);
            }
            return listReturn;
        }


        public ActionResult HoaDon()
        {

            return View();
        }
        public ActionResult ListHoaDon()
        {
            List<GetHoaDon> listHD = GetListHoaDon();
            return Json(listHD, JsonRequestBehavior.AllowGet);
        }



    }
}
