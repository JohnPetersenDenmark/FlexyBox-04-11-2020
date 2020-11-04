using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Entities
{
    public class SearchTerm : IBaseClass
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
