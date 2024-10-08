using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class TestimonialController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult TestimonialList()
        {
            var values = context.Testimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonial.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonial.Find(id);
            context.Testimonial.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = context.Testimonial.Find(testimonial.TestimonialID);
            if(value != null)
            {
                value.NameSurname = testimonial.NameSurname;
                value.SubTitle = testimonial.SubTitle;
                value.Comment = testimonial.Comment;
                context.SaveChanges();
            }
            return RedirectToAction("TestimonialList");
        }
    }
}