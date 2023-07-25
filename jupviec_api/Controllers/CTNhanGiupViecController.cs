using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class CTNhanGiupViecController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsCTNhanVien")]
        public List<CT_NHANGIUPVIEC> dsCTNhanVien()
        {
            return db.CT_NHANGIUPVIEC.ToList();
        }

        //[HttpGet]
        //[Route("api/jupviec/TimCTNhanVien")]
        //public CT_NHANGIUPVIEC TimCTNhanVien(string MaNV, string MaDD)
        //{
        //    return db.CT_NHANGIUPVIEC.
        //}
    }
}
