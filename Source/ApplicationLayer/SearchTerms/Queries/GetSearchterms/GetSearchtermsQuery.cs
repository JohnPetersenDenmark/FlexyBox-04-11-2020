using ApplicationLayer.Common;
using DomainLayer.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.SearchTerms.Queries.GetSearchterms
{
    public class GetSearchtermsQuery : IRequest<SearchTermStatisticViewModel>
    {

    }

    public class GetSearchtermsQueryHandler : IRequestHandler<GetSearchtermsQuery, SearchTermStatisticViewModel>
    {
    
        private readonly IWebAppDbContext context;
        public GetSearchtermsQueryHandler(IWebAppDbContext context)
        {
            this.context = context;
        }

        public Task<SearchTermStatisticViewModel> Handle(GetSearchtermsQuery request, CancellationToken cancellationToken)
        {
            List<SearchTerm> searchTermList =  context.getAllSearchTermsAsync().Result;

            SearchTermStatisticViewModel searchTermStatisticModel = new SearchTermStatisticViewModel();
            

            foreach ( var searchTerm in searchTermList)
            {
                searchTermStatisticModel.SearchTermId = searchTerm.Id;
                searchTermStatisticModel.SearchTerm = searchTerm.Term;

                var letterCounter = searchTerm.Term.Where(char.IsLetter)               
                          .GroupBy(char.ToLower)
                          .Select(counter => new { Letter = counter.Key, Counter = counter.Count() }).ToList();

                foreach (var letter in letterCounter)
                {
                    characterSpec charSpec = new characterSpec();
                    charSpec.Character = Char.ToString(letter.Letter);
                    charSpec.CharacterCount = letter.Counter;
                    searchTermStatisticModel.LetterSpec.Add(charSpec);
                   
                }

               var digitCounter = searchTerm.Term.Where(char.IsDigit)
                          .GroupBy(char.ToLower)
                          .Select(counter => new { Letter = counter.Key, Counter = counter.Count() }).ToList();

                foreach (var digit in digitCounter)
                {
                    characterSpec charSpec = new characterSpec();
                    charSpec.Character = Char.ToString(digit.Letter);
                    charSpec.CharacterCount = digit.Counter;
                    searchTermStatisticModel.DigitSpec.Add(charSpec);

                }

                var symbolCounter = searchTerm.Term.Where(char.IsSymbol)
                         .GroupBy(char.ToLower)
                         .Select(counter => new { Letter = counter.Key, Counter = counter.Count() }).ToList();

                foreach (var symbol in symbolCounter)
                {
                    characterSpec charSpec = new characterSpec();
                    charSpec.Character = Char.ToString(symbol.Letter);
                    charSpec.CharacterCount = symbol.Counter;
                    searchTermStatisticModel.SymbolSpec.Add(charSpec);

                }
            }

            return Task.FromResult(searchTermStatisticModel);
        }

    }
}