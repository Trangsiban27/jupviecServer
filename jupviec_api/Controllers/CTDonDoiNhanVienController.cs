using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class CTDonDoiNhanVienController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsCTDonDoiNhanVien")]
        public List<CT_DONDOI_NHANGIUPVIEC> dsCTDonDoiNhanVien()
        {
            return db.CT_DONDOI_NHANGIUPVIEC.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/TimCTDonDoiNhanVien")]
        public CT_DONDOI_NHANGIUPVIEC TimCTDonDoiNhanVien(string MaDonDoi)
        {
            return db.CT_DONDOI_NHANGIUPVIEC.SingleOrDefault(d => d.MaDD == MaDonDoi);
        }
    }
}
