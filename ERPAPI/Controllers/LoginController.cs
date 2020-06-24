using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using DataAccess.Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ERPAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IBaseBusiness _business;
        public LoginController(IBaseBusiness business)
        {
            _business = business;
        }
        [HttpPost]
        public int IsLogin(UserInfoModel model)
        {
            string sql = $"select * from UserInfo where UserName ='{model.UserName}' and UserPass='{model.UserPass}'";
            return DapperHelper<UserInfoModel>.GetId(sql);
        }
    }
}