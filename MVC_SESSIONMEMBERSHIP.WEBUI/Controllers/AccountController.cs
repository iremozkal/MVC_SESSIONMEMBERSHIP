using MVC_SESSIONMEMBERSHIP.WEBUI.Models.AccountVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SESSIONMEMBERSHIP.DATA.Model_Entity;
using MVC_SESSIONMEMBERSHIP.DAL.Context;

namespace MVC_SESSIONMEMBERSHIP.WEBUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly ECommerceContext DB;

        public AccountController()
        {
            DB = new ECommerceContext();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            // ModelState.IsValid indicates if it was possible to bind the incoming values from the request to the model correctly 
            // and whether any explicitly specified validation rules were broken during the model binding process.
            if (ModelState.IsValid)
            {
                WebUser comingUser = DB.UserTable.SingleOrDefault(x => x.Email == model.Email && x.Password == model.Password);

                if (comingUser != null)
                {
                    Session["UserInfo"] = comingUser;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Message"] = "There is no such  user.";    // temp data to any view, viewbag data only to this action's view
                    return View(model);
                }
            }
            else
            {
                return View(model);  // When the model is missing, it returns to the login page again, but with the model data on it.
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                WebUser insertedUser = new WebUser()
                {
                    NameSurname = model.FullName,
                    Email = model.Email,
                    Password = model.Password,
                    PasswordAgain = model.ConfirmPassword,
                    WebRolId = 2  // 2: user 
                };

                DB.UserTable.Add(insertedUser);
                DB.SaveChanges();

                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult LogOut()
        {
            Session["UserInfo"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}
