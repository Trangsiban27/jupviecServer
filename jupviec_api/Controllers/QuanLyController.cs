using jupviec_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jupviec_api.Controllers
{
    public class QuanLyController : ApiController
    {
        JupViecDBContex db = new JupViecDBContex();

        [HttpGet]
        [Route("api/jupviec/dsQuanLy")]
        public List<QUANLY> dsQuanLy()
        {
            return db.QUANLies.ToList();
        }

        [HttpGet]
        [Route("api/jupviec/timTaiKhoan")]
        public QUANLY TimTaiKhoan(string taikhoan)
        {
            return db.QUANLies.SingleOrDefault(t => t.TaiKhoan == taikhoan);    
        }
    }
}
