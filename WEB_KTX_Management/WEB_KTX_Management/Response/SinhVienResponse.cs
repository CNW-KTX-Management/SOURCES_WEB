using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_KTX_Management.Response
{
    public class SinhVienResponse
    {
        public List<SinhVien> list { get; set; }
    }

    public class SinhVien {
        public int id { get; set; }
        public string mssv { get; set; }
        public string name { get; set; }
        public string ngaySinh { get; set; }
        public string phone { get; set; }
        public string passport { get; set; }
        public int gioiTinh { get; set; }
    }
}