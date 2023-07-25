using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class KhachHangController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsKhachHang")]
        public List<KHACHHANG> dsKhachHang()
        {
            return db.KHACHHANGs.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/TimKhachHang")]
        public KHACHHANG TimKhacHang(string MaKhachHang)
        {
            return db.KHACHHANGs.SingleOrDefault(k => k.MaKH == MaKhachHang);
        }
    }
}
