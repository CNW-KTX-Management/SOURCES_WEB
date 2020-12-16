using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_KTX_Management.Models;
using WEB_KTX_Management.Mapper;
using WEB_KTX_Management.Contants;

namespace WEB_KTX_Management.Controllers
{
    public class ContractController : Controller
    {
        //
        // GET: /Contract/

        DatabaseDataContext data = new DatabaseDataContext();

        public ActionResult List()
        {
            return View();
        }

        public JsonResult GetListContract()
        {
            List<ContractMapper> listReturn = new List<ContractMapper>();
            List<HopDong> list = data.HopDongs.ToList();
            int stt = 1;
            foreach (HopDong hd in list)
            {
                SinhVien sv = data.SinhViens.FirstOrDefault(s => s.Id == hd.IdSinhVien);
                ContractMapper contractMapper = new ContractMapper();
                contractMapper.Stt = stt;
                contractMapper.IdHopDong = hd.Id;
                contractMapper.IdSinhVien = hd.IdSinhVien;
                contractMapper.TenSinhVien = sv.Name;
                contractMapper.NgayLamDon = hd.NgayLamDon;
                if (hd.NgayBatDau == null || hd.NgayBatDau.Trim() == "")
                {
                    contractMapper.NgayBatDau = "--/--/----";
                }
                else {
                    contractMapper.NgayBatDau = hd.NgayBatDau;                    
                }

                if (hd.NgayKetThuc == null || hd.NgayKetThuc.Trim() == "")
                {
                    contractMapper.NgayKetThuc = "--/--/----";
                }
                else
                {
                    contractMapper.NgayKetThuc = hd.NgayKetThuc;
                }
                contractMapper.TenTinhTrang = getTenTinhTrang(hd.TinhTrang);
                stt++;
                listReturn.Add(contractMapper);
            }

            return Json(listReturn, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DetailContract(int Id)
        {
            HopDong hd = data.HopDongs.FirstOrDefault(h => h.Id == Id);
            ContractMapper mapper = new ContractMapper(hd.Id, hd.IdSinhVien, hd.NgayBatDau, hd.NgayKetThuc, hd.TinhTrang, getTenTinhTrang(hd.TinhTrang));
            return Json(mapper, JsonRequestBehavior.AllowGet);
        }

        public string getTenTinhTrang(int id){
            switch (id)
            {
                case Contants.Contants.HOPDONG_STATUS_MOI:
                    {
                        return "Hợp đồng mới";
                    }
                case Contants.Contants.HOPDONG_STATUS_HET_HAN:
                    {
                        return "Hợp đồng hết hạn";
                    }
                case Contants.Contants.HOPDONG_STATUS_HUY:
                    {
                        return "Hợp đồng bị hủy";
                    }
                default: return "";
            }
        }

    }
}
