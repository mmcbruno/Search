using Search.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Search.DAL
{
    public class SearchContext: DbContext
    {
        public SearchContext() : base("SearchContext")
        {
        }
        public DbSet<SearchResult> SearchResult { get; set; }
        public DbSet<SearchRelatedArticles> SearchRelatedArticles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}