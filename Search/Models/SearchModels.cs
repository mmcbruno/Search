using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Search.Models
{
   
    public class SearchResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ExternalUrl { get; set; }
        public virtual IList<SearchRelatedArticles> RelatedArticles { get; set; }
    
    }

    public class SearchRelatedArticles
    {
        public int Id { get; set; }
        public int SearchResultId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}