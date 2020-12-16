using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_KTX_Management.Mapper
{
    public class ContractMapper
    {
        public int Stt { get; set; }
        public int IdHopDong { get; set; }
        public int IdSinhVien { get; set; }
        public int IdTinhTrang { get; set; }
        public string TenSinhVien { get; set; }
        public string TenTinhTrang { get; set; }
        public string NgayLamDon { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }

        public ContractMapper() { 
            
        }

        public ContractMapper(int id, int idSV, string ngayBatDau, string ngayKetThuc, int tinhTrang, string tenTinhTrang) {
            IdSinhVien = idSV;
            IdHopDong = id;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            IdTinhTrang = tinhTrang;
            TenTinhTrang = tenTinhTrang;
        }
    }
}