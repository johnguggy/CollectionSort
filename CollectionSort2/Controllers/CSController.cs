using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollectionSort2.Controllers
{
    public class CSController : Controller
    {
        // GET: CS
        public ActionResult Index()
        {
            Random rand = new Random();
            List<int> rtnlist = new List<int>();

            for (int i = 1; i < 5; i++)
            {
                rtnlist.Add(rand.Next(100));
            }
            rtnlist.Sort();
            ViewBag.randnums = rtnlist;
            return View();
        }
    }
}