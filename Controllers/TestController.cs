using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using TrabahoPH.Models;
using TrabahoPH.Services;

namespace TrabahoPH.Controllers
{
    public class TestController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { a = Accounts.GetAccounts() }, JsonRequestBehavior.AllowGet );
        }
    }
}