using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEB_KTX_Management.Models;
using Newtonsoft.Json;

namespace WEB_KTX_Management.Controllers
{
    public class NhanVienController : Controller
    {
        //
        // GET: /NhanVien/

        private async Task<NhanVien> GetListNhanVien() {
            return null;
        }

        public ActionResult ListNhanVien()
        {
            return View();
        }

    }
}
