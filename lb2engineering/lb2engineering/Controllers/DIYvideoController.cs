using lb2engineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lb2engineering.Controllers
{
    public class DIYvideoController : Controller
    {
        //
        // GET: /DIYvideo/

        public ActionResult Index()
        {
            var model =
             from r in _DIYvideo
             orderby r.Name
             select r;
            return View(model);
        }

        //
        // GET: /DIYvideo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DIYvideo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DIYvideo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DIYvideo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DIYvideo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DIYvideo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DIYvideo/Delete/5

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
        
        static List<DIYvideoDownloads> _DIYvideo = new List<DIYvideoDownloads> // Mdoels
       {
            /*new DIYvideoDownloads
            {
                Id=1,
                Name="TheFirsVideo",
                Details = "testing video 1",//there would be a comma here if there was a following variable after Name.
            },
            new DIYvideoDownloads
            {
                Id=2,
                Name= "NotTheLastBook",
                Details="Testing video 2 or last video"
            },
            new DIYvideoDownloads
            {
                Id=3,
                Name="Very Last video",
                Details= "Yep Last One"
            }*/

       };



    }
}
