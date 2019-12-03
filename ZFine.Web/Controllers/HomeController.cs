/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台  FROM http://xmwxgn.com
 *
*********************************************************************************/
using ZFine.Application.SystemManage;
using ZFine.Code;
using ZFine.Domain.Entity.SystemManage;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ZFine.Web.Controllers
{
    [HandlerLogin]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Default()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Developing()
        {
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
    }
}
