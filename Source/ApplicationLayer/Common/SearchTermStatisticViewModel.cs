using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Common
{
    public class SearchTermStatisticViewModel
    {
        public SearchTermStatisticViewModel()
        {
            this.LetterSpec = new List<characterSpec>();
            this.DigitSpec = new List<characterSpec>();
            this.SymbolSpec = new List<characterSpec>();
        }
        public int SearchTermId { get; set; }
        public string  SearchTerm{ get; set; }
        public List<characterSpec> LetterSpec { get; set; }
        public List<characterSpec> DigitSpec { get; set; }
        public List<characterSpec> SymbolSpec { get; set; }

        public static implicit operator Task<object>(SearchTermStatisticViewModel v)
        {
            throw new NotImplementedException();
        }
    }

    public class characterSpec
    {
        public string Character { get; set; }
        public int CharacterCount { get; set; }
    }
}
