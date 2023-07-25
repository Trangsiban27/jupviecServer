using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class DichVuDinhKemController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsDichVuDinhKem")]
        public List<DICHVUDINHKEM> dsDichVuDinhKem()
        {
            return db.DICHVUDINHKEMs.ToList();
        }
    }
}
