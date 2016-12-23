using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Search.DAL;
using Search.Models;

namespace Search.Controllers
{
    public class SearchResultsController : Controller
    {
        private SearchContext db = new SearchContext();

        // GET: SearchResults
        public ActionResult Index()
        {
            return View(db.SearchResult.ToList());
        }

        // GET: SearchResults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SearchResult searchResult = db.SearchResult.Find(id);
            if (searchResult == null)
            {
                return HttpNotFound();
            }
            return View(searchResult);
        }

        // GET: SearchResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SearchResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,ImageUrl,ExternalUrl")] SearchResult searchResult)
        {
            if (ModelState.IsValid)
            {
                db.SearchResult.Add(searchResult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(searchResult);
        }

        // GET: SearchResults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SearchResult searchResult = db.SearchResult.Find(id);
            if (searchResult == null)
            {
                return HttpNotFound();
            }
            return View(searchResult);
        }

        // POST: SearchResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,ImageUrl,ExternalUrl")] SearchResult searchResult)
        {
            if (ModelState.IsValid)
            {
                db.Entry(searchResult).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(searchResult);
        }

        // GET: SearchResults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SearchResult searchResult = db.SearchResult.Find(id);
            if (searchResult == null)
            {
                return HttpNotFound();
            }
            return View(searchResult);
        }

        // POST: SearchResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SearchResult searchResult = db.SearchResult.Find(id);
            db.SearchResult.Remove(searchResult);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
