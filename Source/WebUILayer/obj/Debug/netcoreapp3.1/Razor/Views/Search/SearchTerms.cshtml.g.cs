#pragma checksum "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25239552604b13f0eabfaedc40596b64bf7557e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchTerms), @"mvc.1.0.view", @"/Views/Search/SearchTerms.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\_ViewImports.cshtml"
using WebUILayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\_ViewImports.cshtml"
using WebUILayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\_ViewImports.cshtml"
using ApplicationLayer.SearchTerms.Commands.CreateSearchTerm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\_ViewImports.cshtml"
using ApplicationLayer.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\_ViewImports.cshtml"
using DomainLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25239552604b13f0eabfaedc40596b64bf7557e4", @"/Views/Search/SearchTerms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a38d893c378e5630966d9d78cf9c43335a04850", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_SearchTerms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SearchTermStatisticViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Statistik</h1>\r\n\r\n\r\n<div class=\"formcontainer\">\r\n");
#nullable restore
#line 7 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
     foreach (var searchStatisticTerm in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group row\">\r\n            <div class=\"form-group col-md-4\">\r\n                Søgetekst: ");
#nullable restore
#line 11 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
                      Write(searchStatisticTerm.SearchTerm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
         foreach (var letterSpec in searchStatisticTerm.LetterSpec)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group row\">\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
               Write(letterSpec.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
               Write(letterSpec.CharacterCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
         foreach (var digitSpec in searchStatisticTerm.DigitSpec)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group row\">\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
               Write(digitSpec.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
               Write(digitSpec.CharacterCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
         foreach (var symbolSpec in searchStatisticTerm.SymbolSpec)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group row\">\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
               Write(symbolSpec.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
               Write(symbolSpec.CharacterCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\jp\source\repos\FlexyBox-04-11-2020\Source\WebUILayer\Views\Search\SearchTerms.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SearchTermStatisticViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
