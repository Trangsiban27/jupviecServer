using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class DichVuChinhController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/DanhSachDichVuChinh")]
        public List<DICHVUCHINH> DanhSachDichVuChinh()
        {
            return db.DICHVUCHINHs.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/timDichVu")]
        public DICHVUCHINH GetDichVuChinhById(string MaDV)
        {
            var DichVu = db.DICHVUCHINHs.SingleOrDefault(dv => dv.MaDVChinh == MaDV);

            return DichVu;
        }
    }
}
