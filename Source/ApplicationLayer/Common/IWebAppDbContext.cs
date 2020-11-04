using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.Common
{

    public interface IWebAppDbContext
    {
        DbSet<SearchTerm> SearchTerms { get; set; }

        Task<List<SearchTerm>> getAllSearchTermsAsync();
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
