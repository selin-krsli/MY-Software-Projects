using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1 ();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            ViewBag.Title = context.Profile.Select(s=>s.Title).FirstOrDefault();
            ViewBag.Description = context.Profile.Select (s=>s.Description).FirstOrDefault();
            ViewBag.Address = context.Profile.Select (s=>s.Address).FirstOrDefault();
            ViewBag.Email = context.Profile.Select (s=>s.Email).FirstOrDefault();
            ViewBag.Phone = context.Profile.Select (s=>s.Phone).FirstOrDefault();
            ViewBag.Github = context.Profile.Select (s=>s.Github).FirstOrDefault();
            ViewBag.ImageUrl = context.Profile.Select (s=>s.ImageUrl).FirstOrDefault();

            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = context.About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialExperience()
        {
            var values = context.Experience.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = context.Skill.Where(s=>s.Status==true).ToList();
            return PartialView(values);
        }
    }
}