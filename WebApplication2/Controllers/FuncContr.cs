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

        //private DataMock mock = new DataMock();
        private DataPass dataPass = new DataPass();
        public FuncContr(IRandomValues randomValues)
        {
            _randomValues = randomValues;
        }

        public IActionResult result()
        {
            return View(dataPass);
        }

        public IActionResult ViewDataResult()
        {


            ViewData["model"] = dataPass;
           
            return View();
        }
        public IActionResult ViewBagResult()
        {
            ViewBag.model = dataPass;
            
            return View();
        }
        public IActionResult Injection()
        {
            return View(_randomValues);
        }
    }
}
