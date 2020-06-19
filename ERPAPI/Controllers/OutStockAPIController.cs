using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.OutModel;

namespace ERPAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class OutStockAPIController : ControllerBase
    {
        Allot_Business _Business = null;
        public OutStockAPIController()
        {
            _Business = new Allot_Business();
        }
        [Route("show")]
        [HttpGet]
        public List<OutStock> ShowPage()
        {
            var list = _Business.Select<OutStock>("select * from Clear a join Client b on a.ClientId=b.CLientId");
            
            return list;
        }
        [HttpPost]
        public void ADD()
        {



        }
        [HttpDelete]
        public void Delete()
        {

        }
        [HttpPut]
        public void Update()
        {

        }



    }
}