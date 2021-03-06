using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SESSIONMEMBERSHIP.DATA.Model_Entity;

namespace MVC_SESSIONMEMBERSHIP.WEBUI.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            WebUser user = Session["UserInfo"] as WebUser;

            if (user != null && user.WebRolId == 1)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
