using System;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class LoginController : ApiController
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        public BaseDataPackage<UserData> UserLogin(string account, string password)
        {
            //使用account和password验证用户

            UserData userData = new UserData();
            userData.UserGuid = Guid.NewGuid().ToString();
            userData.UserName = "测试用户";

            var result = new BaseDataPackage<UserData>();
            result.Data = userData;
            result.Status = ApiStatusCode.OK;
            result.Message = "登录成功";
            return result;
        }
    }
}