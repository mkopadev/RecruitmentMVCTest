using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Applicita.RecruitmentTest.Service;

namespace Applicita.RecruitmentTest.Web.Controllers
{
    public class HomeController : Controller
    {
        private TaxRateService _taxRateService;

        public HomeController()
        {
        
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}