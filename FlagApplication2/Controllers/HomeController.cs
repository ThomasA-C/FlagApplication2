using ClassLibrary;
using ClassLibrary3;
using FlagApplication2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace FlagApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<ReadingEntityContext>());
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult InsertReadingDetail()
        {
            try
            {
                for (var i = 0; i < 5; i++)
                {
                    var read = new Reading
                    {
                        ReadingId = i,
                        ReadingType = "Type" + i
                    };

                    using (ReadingEntityContext context = new ReadingEntityContext())
                    {
                        context.Readings.Add(read);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetReadingDetails()
        {
            
            var model = new List<ReadingModel>();
            
            try
            {
                using (var context = new ReadingEntityContext())
                {
                    var value = context.Readings.ToList();
                    model.AddRange(value.Select(read => new ReadingModel
                    {
                        ReadingId = read.ReadingId,
                        ReadingType = read.ReadingType
                    }));
                }
            }
            catch (Exception)
            {
                throw;
            } 
            return PartialView("_ReadingDetailView", model);
        }
    }
}