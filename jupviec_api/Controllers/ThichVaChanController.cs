using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class ThichVaChanController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsThichVaChan")]
        public List<THICHVACHAN> dsThichVaChan()
        {
            return db.THICHVACHANs.ToList();
        }
    }
}
