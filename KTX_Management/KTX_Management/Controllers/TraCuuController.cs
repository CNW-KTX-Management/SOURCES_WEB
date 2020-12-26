using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KTX_Management.Controllers;
using KTX_Management.Models;
using KTX_Management.API ;
using KTX_Management.Mapper;

namespace KTX_Management.Controllers
{
    public class TraCuuController : Controller
    {
        //
        // GET: /TraCuu/
        TraCuuAPIController controller = new TraCuuAPIController();

        public ActionResult TraCuu()
        {
            return View();
        }

        public JsonResult InitTraCuu(){
            return Json(controller.GetListKhu(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetListRoomByArea(int id)
        {
            return Json(controller.GetListRoom(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult KetQuaTraCuu()
        {
            return View();
        }

        public ActionResult GoToChiTietHopDong(int id)
        {
            return RedirectToAction("GoToChiTietHopDong/" + id,"HopDong");
        }

        [HttpPost]
        public ActionResult KetQuaTraCuu(FormCollection form)
        {
            int idArea = -1;
            int idRoom = -1;
            string name = "";
            if (form["txtAreaId"] != null && form["txtAreaId"] != "")
            {
                idArea = int.Parse(form["txtAreaId"]);
            }

            if (form["txtRoomId"] != null && form["txtRoomId"] != "")
            {
                idRoom = int.Parse(form["txtRoomId"]);
            }

            name = form["txtTenSinhVien"];

            TraCuuMapper mapper = new TraCuuMapper();
            mapper.IdArea = idArea;
            mapper.IdRoom = idRoom;
            mapper.Name = name;
            return View(controller.GetChiTietHopDong(mapper));
        }

    }
}
