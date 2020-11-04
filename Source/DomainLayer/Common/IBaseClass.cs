using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Common
{
    interface IBaseClass
    {
         DateTime CreatedDate { get; set; }
        DateTime LastModifiedDate { get; set; }
        string CreatedBy { get; set; }
        string LastModifiedBy { get; set; }
    }
}
