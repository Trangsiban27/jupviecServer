using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class DonDoiNhanVienController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsDonDoi")]
        public List<DONDOINHANVIEN> dsDonDoiNhanVien()
        {
            return db.DONDOINHANVIENs.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/TimDonDoi")]
        public DONDOINHANVIEN TimDonDoiNhanVien(string MaDonDoi)
        {
            return db.DONDOINHANVIENs.SingleOrDefault(d => d.MaDonDoi == MaDonDoi);
        }
    }
}
