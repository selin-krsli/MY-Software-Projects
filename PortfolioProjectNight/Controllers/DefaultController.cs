﻿using System;
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
            List<SelectListItem> values = (from x in context.Category.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.V = values; 
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            contact.SendDate = DateTime.Parse(DateTime.Now.ToString());
            contact.IsRead = false;

            context.Contact.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
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
            var values = context.SocialMedia.Where(s=>s.Durum==true).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            ViewBag.Title = context.About.Select(s=>s.Title).FirstOrDefault();
            ViewBag.Description = context.About.Select (s=>s.Description).FirstOrDefault();
            ViewBag.ImageUrl = context.About.Select(s => s.ImageUrl).FirstOrDefault();
            var values = context.SocialMedia.Where(s => s.Durum == true).ToList();
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
        public PartialViewResult PartialFooter()
        {
            var values = context.SocialMedia.Where(s => s.Durum == true).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = context.Education.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTrainee()
        {
            var values = context.Trainee.ToList();  
            return PartialView(values);
        }
        public ActionResult PartialService()
        {
            var values = context.Service.ToList();  
            return PartialView(values);
        }
        public ActionResult PartialPortfolio()
        {
            var values = context.Portfolio.ToList();
            return PartialView(values);
        }
        public ActionResult PartialTestimonial()
        {
            var values = context.Testimonial.ToList();
            return PartialView(values);
        }
    }
}