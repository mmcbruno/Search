using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Search.DAL;
using Search.Models;

namespace Search.Controllers
{
    public class SearchController : Controller
    {
        private SearchContext db = new SearchContext();


        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search(string searchString)
        {
            IEnumerable<SearchResult> myresult =
                db.SearchResult.Where(m => m.Title.ToLower().Contains(searchString.ToLower())
                                           || m.Description.ToLower().Contains(searchString.ToLower())).ToList();
            return View(myresult);
        }


        [HttpPost]
        public JsonResult Autocomplete(string prefix)
        {
         
            //Searching records from list using LINQ query  
            var titles = (from n in db.SearchResult
                            where n.Title.StartsWith(prefix)
                            select new { n.Title });
            return Json(titles, JsonRequestBehavior.AllowGet);
        }
    }
}