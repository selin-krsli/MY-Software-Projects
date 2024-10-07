using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNight.Models;

namespace PortfolioProjectNight.Controllers
{
    public class TraineeController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult TraineeList()
        {
            var values = context.Trainee.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTrainee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTrainee(Trainee trainee)
        {
            context.Trainee.Add(trainee);
            context.SaveChanges();
            return RedirectToAction("TraineeList");
        }
        public ActionResult DeleteTrainee(int id)
        {
            var value = context.Trainee.Find(id);
            context.Trainee.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TraineeList");
        }
        [HttpGet]
        public ActionResult UpdateTrainee(int id)
        {
            var value = context.Trainee.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTrainee(Trainee trainee)
        {
            var value = context.Trainee.Find(trainee.TraineeId);
            if(value!=null)
            {
                value.Title = trainee.Title;
                value.SubTitle = trainee.SubTitle;
                value.Description = trainee.Description;
                value.DateRange = trainee.DateRange;
                context.SaveChanges();
            }
            return RedirectToAction("TraineeList");
        }
    }
}