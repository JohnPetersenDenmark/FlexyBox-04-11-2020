﻿using System.Threading.Tasks;
using ApplicationLayer.SearchTerms.Commands.CreateSearchTerm;
using ApplicationLayer.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class SearchController : Controller
    {
        private readonly IMediator mediator;
        public SearchController(IMediator mediator )
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Search(CreateSearchTermCommand command)
        {
            var result = await mediator.Send(command);
            return View("SearchResult", result);
        }

        

    }
}
