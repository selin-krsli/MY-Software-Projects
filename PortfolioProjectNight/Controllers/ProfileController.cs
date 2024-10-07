using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class ProfileController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult Index()
        {
            var values = context.Profile.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = context.Profile.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProfile(Profile profile)
        {
            var value = context.Profile.Find(profile.ProfileId);
            if(value != null)
            {
                value.Birthdate = profile.Birthdate;
                value.Email = profile.Email;
                value.Phone = profile.Phone;
                value.Github = profile.Github;
                value.Address = profile.Address;
                value.Title = profile.Title;
                value.Description = profile.Description;
                value.ImageUrl = profile.ImageUrl;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}