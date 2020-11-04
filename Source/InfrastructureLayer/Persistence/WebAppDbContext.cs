using ApplicationLayer.Common;
using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfrastructureLayer.Persistence
{

    public class WebAppDbContext : DbContext, IWebAppDbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {

        }

        public DbSet<SearchTerm> SearchTerms { get; set; }

        

        public async Task<List<SearchTerm>> getAllSearchTermsAsync()
        {
            return await this.SearchTerms.ToListAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}


