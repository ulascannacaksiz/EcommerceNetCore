#pragma checksum "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\ReviewList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2ff6f3e8711cbec6fa4c2183b4ffdd415c44286"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ReviewList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ReviewList/Default.cshtml")]
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
#line 1 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\_ViewImports.cshtml"
using EcommerceCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\_ViewImports.cshtml"
using EcommerceCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2ff6f3e8711cbec6fa4c2183b4ffdd415c44286", @"/Views/Shared/Components/ReviewList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc391a4420396b5a8f0f6e3d3b90d61245b4390", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ReviewList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Rating>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\ReviewList\Default.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"review\">\r\n        <div class=\"row no-gutters\">\r\n        <div class=\"col-auto\">\r\n            <h4><a href=\"#\">");
#nullable restore
#line 8 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\ReviewList\Default.cshtml"
                       Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n            <div class=\"ratings-container\">\r\n                <div class=\"ratings\">\r\n                    <div class=\"ratings-val\"");
            BeginWriteAttribute("style", " style=\"", 351, "\"", 384, 4);
            WriteAttributeValue("", 359, "width:", 359, 6, true);
#nullable restore
#line 11 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\ReviewList\Default.cshtml"
WriteAttributeValue(" ", 365, item.Vote*20, 366, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 381, "%;", 381, 2, true);
            WriteAttributeValue(" ", 383, "", 384, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div><!-- End .ratings-val -->
                </div><!-- End .ratings -->
            </div><!-- End .rating-container -->
            <span class=""review-date"">6 days ago</span>
        </div><!-- End .col -->
        <div class=""col"">

            <div class=""review-content"">
                <p>");
#nullable restore
#line 19 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\ReviewList\Default.cshtml"
              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div><!-- End .review-content -->\r\n        </div><!-- End .col-auto -->\r\n    </div><!-- End .row -->\r\n</div>\r\n");
#nullable restore
#line 24 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\ReviewList\Default.cshtml"
    
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Rating>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
