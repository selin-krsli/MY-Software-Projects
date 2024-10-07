using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class AboutController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult Index()
        {
            var values = context.About.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.About.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = context.About.Find(about.AboutId);
            if(value != null)
            {
                value.Title = about.Title;
                value.Description = about.Description;
                value.ImageUrl = about.ImageUrl;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}