using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCproject.Models;
using System.Web;

namespace MVCproject.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Calculate(string x, string y, string action)
        {
            if (Request.HttpContext.Request.Method == "POST")
            {
                int a = int.Parse(x);
                int b = int.Parse(y);
                switch (action)
                {
                    case "Add": int sum = a + b;
                                ViewBag.res = sum;
                                break;
                    case "Sub": int diff = a - b;
                                ViewBag.res = diff;
                                break;
                    case "Mul": int product = a * b;
                                ViewBag.res = product;
                                break;
                    case "Div": int div = a / b;
                                ViewBag.res = div;
                                break;
                }
                // to retain the input values in the textbox
                ViewBag.first = a;
                ViewBag.second = b;
            }
            return View();
        }
    }
}
