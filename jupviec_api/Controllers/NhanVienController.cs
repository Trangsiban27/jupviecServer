using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class NhanVienController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsNhanVien")]
        public List<NHANVIENGIUPVIEC> dsNhanVien()
        {
            return db.NHANVIENGIUPVIECs.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/TimNhanVien")]
        public NHANVIENGIUPVIEC TimNhanVien(string MaNV)
        {
            return db.NHANVIENGIUPVIECs.SingleOrDefault(n => n.MaNV == MaNV);
        }
    }
}
