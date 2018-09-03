using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebChat.Models;
using Newtonsoft.Json;

namespace WebChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["Name"]!=null)
            {
                string Name = Session["Name"].ToString();
                ViewBag.Name = Name;
                return View();
            }
            else
            {
                return Redirect("/Home/Login");
            }
        }

        public ActionResult Login(Users users)
        {
            Users info = new Users();
            if (string.IsNullOrEmpty(users.Username))
            {
                info.LoginInfo = "";
                return View(info);
            }
            else
            {
                string[] Users = { "Arvin", "Mark", "Sunny" };
                string[] Pass = { "111", "111", "111" };
                string Username = users.Username;
                string Password = users.Password;
                int index = Array.IndexOf(Users, Username);  //判断用户名在数组中是否存在，并取出索引值
                if (index >= 0)
                {
                    if (Pass[index] == Password)
                    {
                        info.LoginInfo = "登录成功";
                        Session.Add("Name", Username);
                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        info.LoginInfo = "密码错误";
                    }
                }
                else
                {
                    info.LoginInfo = "用户名错误";

                }
                return View(info);
            }



        }
    }
}