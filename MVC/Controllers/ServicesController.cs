using Data.Entity;
using MVC.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ServicesController : Controller
    {
        IserviceServices ss = new ServiceServices();
        // GET: Services
        public ActionResult Index()
        {
            List<ServicesModels> list = new List<ServicesModels>();
            foreach (var s in ss.GetAll())
            {
                ServicesModels sm = new ServicesModels();
                sm.idService = s.idService;
                sm.TypeService = s.TypeService;
                sm.NbrEmployee = s.NbrEmployee;
                list.Add(sm);

            }
            return View(list);
        }

        // GET: Services/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Services/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        [HttpPost]
        public ActionResult Create(ServicesModels collection)
        {
            //try
            //{
                Service s = new Service();
                s.TypeService = collection.TypeService;
                s.NbrEmployee = collection.NbrEmployee;
                ss.Add(s);
                ss.Commit();
                return RedirectToAction("Index");
            //}
            //catch
            //{
                //return View();
            //}
        }

        // GET: Services/Edit/5
        public ActionResult Edit(int id)
        {
            Service s = ss.GetById(id);
            ServicesModels Service = new ServicesModels();
            Service.TypeService = s.TypeService;
            Service.NbrEmployee = s.NbrEmployee;
           

            return View(Service);
            
        }

        // POST: Services/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ServicesModels collection)
        {
            Service s = ss.GetById(id);
            s.TypeService = collection.TypeService;
            s.NbrEmployee = collection.NbrEmployee;
          
            ss.Update(s);
            ss.Commit();


            return RedirectToAction("Index");
        }

        // GET: Services/Delete/5
        public ActionResult Delete(int id)
        {
            Service c = ss.GetById(id);

            ss.Delete(c);
            ss.Commit();
            return RedirectToAction("Index");
        }

        // POST: Services/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
