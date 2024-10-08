using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class SocialMediaController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult SocialMediaList()
        {
            var values = context.SocialMedia.Where(s=>s.Durum==true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            ViewBag.StatusList = new List<SelectListItem>
            {
                new SelectListItem{ Text = "Seçim Yapınız..", Value = ""},
                new SelectListItem{ Text = "Aktif", Value = "True"},
                new SelectListItem{ Text = "Pasif", Value = "False"}
            };
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedia.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedia.Find(id);
            context.SocialMedia.Remove(value);  
            return RedirectToAction("SocialMediaList");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedia.Find(id);
            ViewBag.StatusList = new List<SelectListItem>
            {
                new SelectListItem{ Text = "Aktif", Value = "True"},
                new SelectListItem{ Text = "Pasif", Value = "False"}
            };
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var value = context.SocialMedia.Find(socialMedia.SocialMediaID);
            if(value!=null)
            {
                value.Title = socialMedia.Title;
                value.Url = socialMedia.Url;
                value.Icon = socialMedia.Icon;
                value.Durum = socialMedia.Durum;
                context.SaveChanges();
            }
            return RedirectToAction("SocialMediaList");
        }
    }
}