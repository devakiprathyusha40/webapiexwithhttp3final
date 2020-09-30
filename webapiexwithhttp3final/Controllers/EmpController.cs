using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapiexwithhttp3final.Models;

namespace webapiexwithhttp3final.Controllers
{
    public class EmpController : Controller
    {
      
        // GET: Emp
        public ActionResult Index()
        {
            EmpClient em = new EmpClient();
          TempData["li"] = em.FindAll();
            return View();
        }
    }
}