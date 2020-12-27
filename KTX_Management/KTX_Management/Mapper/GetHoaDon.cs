using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KTX_Management.Mapper
{
    public class GetHoaDon
    {
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public string TenRoom { get; set; }
        public int IdNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int IdDien { get; set; }
        public int GiaDien { get; set; }
        public int IdNuoc { get; set; }
        public int GiaNuoc { get; set; }
        public string NgayLap { get; set; }
        public int SoDienCu { get; set; }
        public int SoDienMoi { get; set; }
        public int SoNuocCu { get; set; }
        public int SoNuocMoi { get; set; }
        public double ThanhTien { get; set; }

        public GetHoaDon() { }
    }
}