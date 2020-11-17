using MyMVCDemo1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCDemo1.Controllers
{
    public class FirstPageController : Controller
    {
        // GET: FirstPage
        public ActionResult Index()
        {

            Student stu = new Student()
            {
                Id = 1,
                Age = 16,
                Name="张三",
            };


            return View(stu);
        }

        public ActionResult Page1(string para)
        {
            return View();
        }

        public ActionResult Page2(string para)
        {
            return View();
        }
    }
}