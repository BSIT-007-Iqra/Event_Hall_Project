using Event_Hall_Project.Models;
using Event_Hall_Project.Utills;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Event_Hall_Project.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {

            return View();
        }

        public ActionResult Contact_Us()
        {
            return View();
        }

        public ActionResult About_Us()
        {
            return View();
        }
        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Menus()
        {
            return View();
        }

        public ActionResult Venues()
        {

            return View();
        }

        public ActionResult Upcoming_Events()
        {

            return View();
        }
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin a)
        {

            var check = db.Admins.Where(x => x.Admin_Email == a.Admin_Email && x.Admin_Password == a.Admin_Password).FirstOrDefault();
            if (check != null)
            {
                if (check.Status == "Active")
                {

                    Session["Admin"] = check;
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    ViewBag.Message = "Your Account have not been active anymore.\n Please contact Admin";
                    return View();
                }
            }

            else
            {
                ViewBag.Message = "Invalid Email & Password";
                return View();
            }


        }
        public ActionResult Newpassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Newpassword(string newPassword)
        {
            var pass = (Admin)Session["ForgetPassword"];
            var v = db.Admins.Where(x => x.Admin_Email == pass.Admin_Email).FirstOrDefault();
            v.Admin_Password  = newPassword;
            db.Entry(v).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Message"] = "Password has Updated Successfully";
            return RedirectToAction("Login");

        }
        public ActionResult CodeVerify()
        {
            return View();
        }
        public ActionResult Confirmation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CodeVerify(int? code)
        {
            int sendCode = (int)Session["code"];
            if (code == sendCode)
            {
                return RedirectToAction("Newpassword");
            }
            TempData["message"] = "Invalid Email";
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPassword(string email)
        {
            var pass = db.Admins.Where(x => x.Admin_Email == email).FirstOrDefault();

            if (pass == null)
            {
                TempData["Error"] = "Invalid Email, Please!\n Enter Valid Email";
                return RedirectToAction("Login");
            }

            Random random = new Random();
            int Code = random.Next(1001, 9999);
            Session["code"] = Code;
            Session["ForgetPassword"] = pass;
            Email.SendEmail(pass.Admin_Email , Code);

            return RedirectToAction("CodeVerify");
        }
    }
}