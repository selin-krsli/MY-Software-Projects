using PortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class SkillController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult SkillList(int page = 1)
        {
            var values = context.Skill.ToList().ToPagedList(page,5);
            return View(values);
        }
        [HttpGet]//attribute
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(Skill skill)//parametre
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            context.Skill.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skill.Find(id);
            context.Skill.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = context.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var value = context.Skill.Find(skill.SkillId);
            if(value != null)
            {
                value.SkillName = skill.SkillName;
                value.Rate = skill.Rate;
                value.Icon = skill.Icon;
                context.SaveChanges();
            }
            return RedirectToAction("SkillList");
        }
        public ActionResult SkillChart()
        {
            var values = context.Skill.ToList();
            return View(values);
        }
    }
}