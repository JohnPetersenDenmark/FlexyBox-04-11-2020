using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ApplicationLayer.SearchTerms.Queries.GetSearchterms;
using DomainLayer.Entities;

namespace WebUILayer.Controllers
{
    public class SearchtermListController : Controller
    {
        private readonly IMediator mediator;
        public SearchtermListController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<SearchTerm>> GetSearchTerms()
        {
            return await mediator.Send(new GetSearchtermsQuery());
        }
    }
}
