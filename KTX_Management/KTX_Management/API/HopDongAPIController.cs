using KTX_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KTX_Management.Mapper;

namespace KTX_Management.API
{
    public class HopDongAPIController : ApiController
    {
        DatabaseDataContext data = new DatabaseDataContext();

        [HttpGet]
        public List<HopDongMapper> GetListHopDong()
        {
            List<HopDongMapper> listReturn = new List<HopDongMapper>();
            List<HopDong> list = data.HopDongs.ToList();
            int stt = 1;
            foreach (HopDong hd in list)
            {
                SinhVien sv = data.SinhViens.FirstOrDefault(s => s.Id == hd.IdSinhVien);
                HopDongMapper contractMapper = new HopDongMapper();
                contractMapper.Stt = stt;
                contractMapper.IdHopDong = hd.Id;
                contractMapper.IdSinhVien = hd.IdSinhVien;
                contractMapper.TenSinhVien = sv.Name;
                contractMapper.NgayLamDon = hd.NgayLamDon;
                if (hd.NgayBatDau == null || hd.NgayBatDau.Trim() == "")
                {
                    contractMapper.NgayBatDau = "--/--/----";
                }
                else
                {
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
            return listReturn;
        }

        [HttpGet]
        public HopDongMapper ChiTietHopDong(int id) {
            HopDong hd = data.HopDongs.FirstOrDefault(h => h.Id == id);
            HopDongMapper mapper = new HopDongMapper(hd.Id, hd.IdSinhVien, hd.NgayBatDau, hd.NgayKetThuc, hd.TinhTrang, getTenTinhTrang(hd.TinhTrang), hd.NgayLamDon);
            return mapper;
        }

        [HttpPost]
        public int CapNhatHopDong(HopDong hd) {
            HopDong hdUpdate = data.HopDongs.FirstOrDefault(h => h.Id == hd.Id);

            if (hd.NgayBatDau == null || hd.NgayKetThuc == null) {
                return 500;
            }

            if (DateTime.Parse(hd.NgayBatDau).Ticks >= DateTime.Parse(hd.NgayKetThuc).Ticks) {
                return 202;
            }

            if (hdUpdate != null) {
                try
                {
                    hdUpdate.NgayBatDau = hd.NgayBatDau;
                    hdUpdate.NgayKetThuc = hd.NgayKetThuc;
                    hdUpdate.TinhTrang = hd.TinhTrang;
                    data.SubmitChanges();
                    return 200;
                }
                catch {
                    return 404;
                }
            }
            return 404;
        }

        [HttpGet]
        public SinhVien GetSinhVienByHopDong(int idHopDong) {
            HopDong hd = data.HopDongs.FirstOrDefault(h => h.Id == idHopDong);
            if (hd != null) { 
                SinhVien sv = data.SinhViens.FirstOrDefault(s => s.Id == hd.IdSinhVien);
                return sv;
            }
            return new SinhVien();
        }

        [HttpGet]
        public NhanVien GetNhanVienByHopDong(int idHopDong)
        {
            HopDong hd = data.HopDongs.FirstOrDefault(h => h.Id == idHopDong);
            if (hd != null)
            {
                NhanVien nv = data.NhanViens.FirstOrDefault(s => s.Id == hd.IdNhanVien);
                return nv;
            }
            return new NhanVien();
        }

        [HttpGet]
        public Room GetRoomByHopDong(int idHopDong)
        {
            HopDong hd = data.HopDongs.FirstOrDefault(h => h.Id == idHopDong);
            if (hd != null)
            {
                Room r = data.Rooms.FirstOrDefault(s => s.Id == hd.IdRoom);
                return r;
            }
            return new Room();
        }

        [HttpGet]
        public List<HoaDon> GetListHoaDonBySinhVien(int idSinhVien)
        {
            List<HoaDon> list = data.HoaDons.Where(it => it.IdSinhVien == idSinhVien).ToList();
            return list;
        }

        [HttpPost]
        public bool createContact(SinhVien sv) {
            try
            {
                data.SinhViens.InsertOnSubmit(sv);
                data.SubmitChanges();
                HopDong hd = new HopDong();
                hd.IdSinhVien = sv.Id;
                hd.NgayLamDon = DateTime.Now.ToString();
                hd.TinhTrang = 1;
                data.HopDongs.InsertOnSubmit(hd);
                data.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }

        public string getTenTinhTrang(int id)
        {
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
                default: return "Hợp đồng đã kiểm duyệt";
            }
        }
    }
}
