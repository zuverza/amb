using AMB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMB.Controllers
{
    public class DisposalController : Controller
    {
        // GET: Disposal
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Disposal d)
        {
            Session["Disposal"] = d;
            return RedirectToAction("Success", "Notification");
        }
    }
}