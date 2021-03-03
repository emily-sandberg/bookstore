#pragma checksum "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df51f3877850245a639f2b44a1da190446286e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 1 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/_ViewImports.cshtml"
using BookstoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/_ViewImports.cshtml"
using BookstoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/_ViewImports.cshtml"
using BookstoreProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df51f3877850245a639f2b44a1da190446286e8b", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df89fade8ee99949b7e088d7e9609edaa48de17", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card card-outline-primary m-1 p-1 card bg-light mb-3\">\n    <br />\n    <h4>\n        ");
#nullable restore
#line 6 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h4>\n    <div class=\"text-muted\">\n        <p>Author: ");
#nullable restore
#line 9 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
              Write(Model.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
                                     Write(Model.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
                                                             Write(Model.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Publisher: ");
#nullable restore
#line 10 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
                 Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>ISBN: ");
#nullable restore
#line 11 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
            Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Page Count: ");
#nullable restore
#line 12 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
                  Write(Model.NumPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Price: $");
#nullable restore
#line 13 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Category: ");
#nullable restore
#line 14 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
                Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <span class=\"badge badge-pill badge-info\" style=\"float:right\">\n            <p>");
#nullable restore
#line 16 "/Users/esandberg/Projects/BookstoreProject/BookstoreProject/Views/Shared/BookSummary.cshtml"
          Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </span>\n    </div>\n    <br />\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591