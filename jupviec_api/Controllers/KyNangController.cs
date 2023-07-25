using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class KyNangController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsKyNang")]
        public List<KYNANG> DsKyNang()
        {
            return db.KYNANGs.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/TimKyNang")]
        public KYNANG TimKyNang(string MaKyNang)
        {
            return db.KYNANGs.SingleOrDefault(k => k.MaKyNang == MaKyNang);
        }
    }
}
