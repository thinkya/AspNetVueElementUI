using System;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

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