using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.mocks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class FuncContr : Controller
    {
        private readonly IRandomValues _randomValues;

        private DataMock mock = new DataMock();
        public FuncContr(IRandomValues randomValues)
        {
            _randomValues = randomValues;
        }

        public IActionResult result()
        {
            return View(mock);
        }

        public IActionResult ViewDataResult()
        {
            

            ViewData["a"] = mock.a;
            ViewData["b"] = mock.b;
            ViewData["Add"] = mock.AddFunc;
            ViewData["Sub"] = mock.SubFunc;
            ViewData["Mult"] = mock.MultFunc;
            if (mock.b == 0)
            {
                ViewData["Div"] = "Divide by zero!";
            }
            else
            {
                ViewData["Div"] = mock.DivFunc;
            }
            
            return View();
        }
        public IActionResult ViewBagResult()
        {
            ViewBag.a = mock.a;
            ViewBag.b = mock.b;
            ViewBag.add = mock.AddFunc;
            ViewBag.sub = mock.SubFunc;
            ViewBag.mult = mock.MultFunc;
            if (mock.b == 0)
            {
                ViewBag.div = "Divide by zero!";
            }
            else
            {
                ViewBag.div = mock.DivFunc;
            }

            

            return View();
        }
        public IActionResult Injection()
        {
            return View(_randomValues);
        }
    }
}
