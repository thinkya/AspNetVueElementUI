using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AspNetVueElementUI.Controller
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
        public BaseDataPackage<UserData> Login(string account, string password)
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

    public class BaseDataPackage<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    /// <summary>
    /// 状态码
    /// </summary>
    public class ApiStatusCode
    {
        /// <summary>
        /// OK
        /// </summary>
        public const int OK = 0;

        /// <summary>
        /// 失败
        /// </summary>
        public const int FAIL = 1;

        /// <summary>
        /// 异常
        /// </summary>
        public const int EXCEPTION = 2;
    }

    public class UserData
    {
        public string UserGuid { get; set; }

        public string UserName { get; set; }
    }
}