using ApplicationLayer.Common;
using DomainLayer.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.SearchTerms.Queries.GetSearchterms
{
    public class GetSearchtermsQuery : IRequest<List<SearchTerm>>
    {

    }

    public class GetSearchtermsQueryHandler : IRequestHandler<GetSearchtermsQuery, List<SearchTerm>>
    {
    
        private readonly IWebAppDbContext context;
        public GetSearchtermsQueryHandler(IWebAppDbContext context)
        {
            this.context = context;
        }

        public  Task<List<SearchTerm>> Handle(GetSearchtermsQuery request, CancellationToken cancellationToken)
        {
            return context.getAllSearchTermsAsync();
        }

     
    }
}