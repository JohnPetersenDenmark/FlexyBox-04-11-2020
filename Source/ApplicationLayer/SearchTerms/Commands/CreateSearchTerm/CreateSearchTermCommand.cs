using ApplicationLayer.Common;
using DomainLayer.Entities;
using System.Collections.Generic;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.SearchTerms.Commands.CreateSearchTerm
{
    public class CreateSearchTermCommand : IRequest<List<string>>
    {
        public string SearchTerm { get; set; }
        public string SearchType { get; set; }

    }

    public class CreateSearchTermCommandHandler : IRequestHandler<CreateSearchTermCommand, List<string>>
    {
        private readonly IWebAppDbContext context;
        private readonly IEnumerable<ISearch> searches;
        public CreateSearchTermCommandHandler(IWebAppDbContext context, IEnumerable<ISearch> searches)
        {
            this.context = context;
            this.searches = searches;
        }


        public  async Task<List<string>> Handle(CreateSearchTermCommand request, CancellationToken cancellationToken)
        {
            List<string> result = null;

            

            foreach (var search in searches)
            {
                if ( search.GetType().Name.Equals("LocalDirectorySearchFiles") && request.SearchType.Equals("Local"))
                    {
                    result = search.Search(request.SearchTerm);
                }

                if (search.GetType().Name.Equals("NewYorkTimesSearhArticles") && request.SearchType.Equals("NYTSeach"))
                {
                    result = search.Search(request.SearchTerm);
                }

            }
            

            SearchTerm entity = new SearchTerm { Term = request.SearchTerm };

            context.SearchTerms.Add(entity);

            await context.SaveChangesAsync(cancellationToken);


            return result;
        }

       
    }
}
