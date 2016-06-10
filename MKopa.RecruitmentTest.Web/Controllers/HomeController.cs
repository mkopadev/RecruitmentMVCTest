using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MKopa.RecruitmentTest.Service;

namespace MKopa.RecruitmentTest.Web.Controllers
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