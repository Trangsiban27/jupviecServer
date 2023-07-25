using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class DienTichController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsDienTich")]
        public List<DIENTICH> dsDienTich()
        {
            return db.DIENTICHes.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/TimDienTich")]
        public DIENTICH TimDienTich(string MaDienTich)
        {
            return db.DIENTICHes.SingleOrDefault(d => d.MaDienTich == MaDienTich);
        }
    }
}
