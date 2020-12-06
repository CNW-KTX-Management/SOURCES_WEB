using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_KTX_Management.Models
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChucVu { get; set; }
        public string Phone { get; set; }
        public string DiaChi { get; set; }
        public int GioiTinh { get; set; }
        public int Status { get; set; }
    }
}