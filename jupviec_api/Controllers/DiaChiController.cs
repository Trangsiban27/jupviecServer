using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class DiaChiController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsDiaChi")]
        public List<DIACHI> dsDiaChi()
        {
            return db.DIACHIs.ToList();
        }

        [HttpGet]
        [Route("api/dsDiaChi/TimDiaChi")]
        public DIACHI TimDiaChi(string MaDiaChi)
        {
            return db.DIACHIs.SingleOrDefault(d => d.MaDiaChi == MaDiaChi);
        }
    }
}
