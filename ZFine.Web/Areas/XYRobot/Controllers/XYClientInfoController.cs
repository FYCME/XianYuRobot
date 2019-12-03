using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZFine.Web.Areas.XYRobot.Controllers
{
    public class XYClientInfoController : Controller
    {
        //
        // GET: /XYRobot/ClientInfo/

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

    }
}
