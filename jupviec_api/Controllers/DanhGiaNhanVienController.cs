using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace jupviec_api.Controllers
{
    public class DanhGiaNhanVienController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/jupviec/dsDanhGia")]
        public List<DANHGIANHANVIEN> dsDanhGia()
        {
            return db.DANHGIANHANVIENs.ToList();
        }
    }
}
