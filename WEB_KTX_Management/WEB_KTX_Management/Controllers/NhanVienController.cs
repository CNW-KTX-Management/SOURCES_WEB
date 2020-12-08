using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEB_KTX_Management.Models;
using WEB_KTX_Management.Response;

namespace WEB_KTX_Management.Controllers
{
    public class NhanVienController : Controller
    {
        public ActionResult ListNhanVien()
        {
            List<SinhVienResponse> list = new List<SinhVienResponse>();
            using (var client = new WebClient()) {
                var query = HttpUtility.ParseQueryString(string.Empty);
                var url = new UriBuilder("http://192.168.1.58:5000/api/sinhvien");
                url.Query = query.ToString();
                string json = client.DownloadString(url.ToString());
                SinhVienResponse sv = JsonConvert.DeserializeObject<SinhVienResponse>(json);
                return View(sv);
            }
        }
    }
}
