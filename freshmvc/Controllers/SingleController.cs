using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freshmvc.Controllers
{
    public class SingleController : Controller
    {
        // GET: Single
        public ActionResult Index()
        {
            Database Database = Sitecore.Configuration.Factory.GetDatabase("master");

            Item item = Sitecore.Context.Database.Items["{0068464F-BD66-495A-9534-ABA45BF5D563}"];


            return View(item);
        }
    }
}