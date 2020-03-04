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
    public class SiteController : Controller
    {
        ISeviceSite ss = new ServiceSite();

        // GET: Site
        public ActionResult Index()
        {
            List<SiteModels> list = new List<SiteModels>();
            foreach (var s in ss.GetAll())
            {
                SiteModels sm = new SiteModels();
                sm.idSite = s.idSite;
                sm.Nom = s.Nom;
               
                list.Add(sm);

            }
            return View(list);
        }

        // GET: Site/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Site/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Site/Create
        [HttpPost]
        public ActionResult Create(SiteModels collection)
        {
          
                Site s = new Site();
                s.Nom = collection.Nom;
                ss.Add(s);
                ss.Commit();

                return RedirectToAction("Index");
          
        }

        // GET: Site/Edit/5
        public ActionResult Edit(int id)
        {
            Site s = ss.GetById(id);
            SiteModels Site = new SiteModels();
            Site.Nom = s.Nom;


            return View(Site);
        }

        // POST: Site/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SiteModels collection)
        {
            Site s = ss.GetById(id);
            s.Nom = collection.Nom;

            ss.Update(s);
            ss.Commit();


            return RedirectToAction("Index");
        }

        // GET: Site/Delete/5
        public ActionResult Delete(int id)
        {
            Site c = ss.GetById(id);

            ss.Delete(c);
            ss.Commit();
            return RedirectToAction("Index");
        }

        // POST: Site/Delete/5
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
