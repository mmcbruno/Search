using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Search.Models;
 


namespace Search.DAL
{
    public class SearchInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SearchContext>
    {
        protected override void Seed(SearchContext context)
        {
            var searchresult = new List<SearchResult>
            {
                new SearchResult{Title="Lily",Description="This si the description for Lily",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Holly",Description="This si the description for Holly",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Jasmine",Description="This si the description for Jasmine",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Jacaranda",Description="This si the description for Jasmine",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Daisy",Description="This si the description for Daisy",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Poppy",Description="This si the description for the Poppy",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Rose",Description="This si the description for Rose",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Ranunculus",Description="This si the description for Rose",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Rudbeckia",Description="This si the description for Rose",ExternalUrl="http://www.google.com"},
                new SearchResult{Title="Iris",Description="This si the description for Iris",ExternalUrl="http://www.google.com"}
            };
            searchresult.ForEach(s => context.SearchResult.Add(s));
            context.SaveChanges();

            var searchRelatedArticles = new List<SearchRelatedArticles>
            {
                new SearchRelatedArticles{ SearchResultId = 1, Title="Related article 1", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 1, Title="Related article 2", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 2, Title="Related article 1(2)", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 2, Title="Related article 2(2)", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 3, Title="Related article 1(3)", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 3, Title="Related article 2(3)", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 4, Title="Related article 1(4)", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 4, Title="Related article 2(4)", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 5, Title="Related article 1(5)", Url = "http://www.google.com"},
                new SearchRelatedArticles{ SearchResultId = 5, Title="Related article 2(5)", Url = "http://www.google.com"}
            };
            searchRelatedArticles.ForEach(s => context.SearchRelatedArticles.Add(s));
            context.SaveChanges();

        }

    }

}