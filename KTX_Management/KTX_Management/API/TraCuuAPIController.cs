using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KTX_Management.Models;
using KTX_Management.Mapper;

namespace KTX_Management.API
{
    public class TraCuuAPIController : ApiController
    {
        DatabaseDataContext data = new DatabaseDataContext();

        [HttpGet]
        public List<Khu> GetListKhu() {
            return data.Khus.ToList();
        }

        [HttpGet]
        public List<Room> GetListRoom(int idKhu)
        {
            List<Room> list = data.Rooms.Where(r => r.IdKhu == idKhu).ToList();
            return list;
        }

        [HttpPost]
        public List<HopDongMapper> GetChiTietHopDong(TraCuuMapper mapper) {
            List<HopDong> listReturn = new List<HopDong>();
            if (mapper.IdArea != -1)
            {
                List<Room> listRoom = data.Rooms.Where(r => r.IdKhu == mapper.IdArea).ToList();
                if (mapper.IdRoom != -1)
                {
                    Room room = listRoom.FirstOrDefault(r => r.Id == mapper.IdRoom);
                    List<HopDong> listHopDong = data.HopDongs.Where(h => h.IdRoom == room.Id).ToList();
                    if (mapper.Name != null && mapper.Name != "")
                    {
                        List<SinhVien> listSinhVien = data.SinhViens.Where(s => s.Name.Contains(mapper.Name)).ToList();
                        foreach (SinhVien sv in listSinhVien)
                        {
                            foreach (HopDong hd in listHopDong)
                            {
                                if (sv.Id == hd.IdSinhVien)
                                {
                                    listReturn.Add(hd);
                                }
                            }
                        }
                    }
                    else
                    {
                        listReturn.AddRange(listHopDong);
                    }
                }
            }
            else {
                List<HopDong> listHopDong = data.HopDongs.ToList();
                if (mapper.Name != null && mapper.Name != "")
                {
                    List<SinhVien> listSinhVien = data.SinhViens.Where(s => s.Name.Contains(mapper.Name)).ToList();
                    foreach (SinhVien sv in listSinhVien)
                    {
                        foreach (HopDong hd in listHopDong)
                        {
                            if (sv.Id == hd.IdSinhVien)
                            {
                                listReturn.Add(hd);
                            }
                        }
                    }
                }
                else
                {
                    listReturn.AddRange(listHopDong);
                }
            }

            List<HopDongMapper> listMapper = new List<HopDongMapper>();
            int stt = 1;
            foreach (HopDong hd in listReturn) {
                HopDongMapper mp = new HopDongMapper();
                Room r = data.Rooms.FirstOrDefault(find => find.Id == hd.IdRoom);
                SinhVien s = data.SinhViens.FirstOrDefault(find => find.Id == hd.IdSinhVien);
                mp.Stt = stt;
                mp.IdHopDong = hd.Id;
                mp.IdSinhVien = hd.IdSinhVien;
                mp.TenSinhVien = s.Name;
                mp.TenPhong = r.TenPhong;
                mp.NgayLamDon = hd.NgayLamDon;
                mp.IdTinhTrang = hd.TinhTrang;
                mp.TenTinhTrang = getTenTinhTrang(hd.TinhTrang);
                mp.NgayBatDau = hd.NgayBatDau;
                mp.NgayKetThuc = hd.NgayKetThuc;
                listMapper.Add(mp);
                stt++;
            }

            return listMapper;
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
