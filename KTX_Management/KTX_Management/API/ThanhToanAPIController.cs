using KTX_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KTX_Management.API
{
    public class ThanhToanAPIController : ApiController
    {
        DatabaseDataContext data = new DatabaseDataContext();
        [HttpGet]
        public List<Room> GetListRoom()
        {
            List<Room> list = data.Rooms.ToList();
            return list;
        }

        [HttpGet]
        public List<Dien> GetGiaDien()
        {
            List<Dien> list = data.Diens.ToList();
            return list;
        }

        [HttpGet]
        public List<Nuoc> GetGiaNuoc()
        {
            List<Nuoc> list = data.Nuocs.ToList();
            return list;
        }

        [HttpGet]
        public List<NhanVien> GetNhanVien()
        {
            List<NhanVien> list = data.NhanViens.ToList();
            return list;
        }

        [HttpGet]
        public List<SinhVien> GetListSinhVienByRoom(int idRoom)
        {
            List<SinhVien> list = data.SinhViens.Where(s => s.IdRoom == idRoom).ToList();
            return list;
        }

        [HttpPost]
        public bool XacNhanThanhToan(HoaDon hd)
        {
            try
            {
                Dien dien = data.Diens.FirstOrDefault(d => d.Id == hd.IdDien);
                Nuoc nuoc = data.Nuocs.FirstOrDefault(d => d.Id == hd.IdNuoc);
                hd.NgayLap = DateTime.Now.ToString();
                hd.ThanhTien = ((hd.SoDienMoi - hd.SoDienCu) * dien.GiaDien) + (hd.SoNuocMoi - hd.SoDienCu) * nuoc.GiaNuoc;
                data.HoaDons.InsertOnSubmit(hd);
                data.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
