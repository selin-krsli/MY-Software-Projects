using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public PartialViewResult PartialContactSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialContactDetail()
        {
            ViewBag.Address = context.Profile.Select(s=>s.Address).FirstOrDefault();
            ViewBag.Description = context.Profile.Select(s=>s.Description).FirstOrDefault();
            ViewBag.Phone = context.Profile.Select(s=>s.Phone).FirstOrDefault();
            ViewBag.Email = context.Profile.Select(s=>s.Email).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialContactLocation()
        {
            return PartialView();
        }
    }
}