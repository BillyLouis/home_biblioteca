using lb2engineering.Models;
using System;
using System.IO;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace lb2engineering.Controllers
{
    public class FreePDFController : Controller
    {
           // GET: /FileProcess/  
  
       DownloadFiles obj;  
        
        public FreePDFController()
       {
           obj = new DownloadFiles();
       }
        public ActionResult Autocomplete(string term)
        {
            var model = obj.GetFiles()
                .Where(r => r.Name.StartsWith(term))
                .Select(r => new
                {
                    label = r.Name
                });
            return Json(model, JsonRequestBehavior.AllowGet);
        }
  
        public ActionResult Index(string searchTerm = null, int page = 1)  
        {
            var filesCollection =
                obj.GetFiles()
                .OrderBy(r => r.Name).ToList()
                .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                //.Take(20)
                .Select(r => new FreePDFdownloads
                {
                    Id = r.Id,
                    Name = r.Name,
                    FilePath = r.FilePath,
                    Details = r.Details
                }).ToPagedList(page, 10);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_FreePDFdownloads", filesCollection);
            }
            return View(filesCollection);  
        }  
  
        public FileResult Download(string Id)
        {
            int CurrentFileID = Convert.ToInt32(Id);  
            var filesCol = obj.GetFiles();  
            string CurrentFileName = (from fls in filesCol  
                                      where fls.Id == CurrentFileID  
                                      select fls.FilePath).FirstOrDefault();  //FirstOrDefault
  
            string contentType = string.Empty;  
  
            if (CurrentFileName.Contains(".pdf"))  
            {  
                contentType = "~/myPDF/pdf";  
            }  
  
            else if (CurrentFileName.Contains(".docx"))  
            {  
                contentType = "~/myPDF/docx";  
            }  
            return File(CurrentFileName, contentType, CurrentFileName);  
        }  
        //
        // GET: /FreePDF/

        // GET: /FreePDF/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /FreePDF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FreePDF/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
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
        // GET: /FreePDF/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /FreePDF/Edit/5

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
        // GET: /FreePDF/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /FreePDF/Delete/5

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

        protected override void Dispose(bool disposing)
        {
            //obj.Dispose(disposing);
            base.Dispose(disposing);
        }
    }
}

