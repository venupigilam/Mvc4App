using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Ref : https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-aspnet-mvc4/adding-a-controller
namespace Mvc4App.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //} 

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Name : " + name + ", No.of Times : " + numTimes);
        }
    }
}
