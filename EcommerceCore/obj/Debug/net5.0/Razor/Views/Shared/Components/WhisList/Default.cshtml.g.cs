#pragma checksum "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b2c82f5f1ff0fe61a46503826462f9ce4fa83d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WhisList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WhisList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b2c82f5f1ff0fe61a46503826462f9ce4fa83d", @"/Views/Shared/Components/WhisList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc391a4420396b5a8f0f6e3d3b90d61245b4390", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WhisList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.WhisList>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-12"">

    <table class=""table table-wishlist table-mobile"">
        <thead>
            <tr>
                <th>Ürün</th>
                <th>Fiyat</th>
                <th></th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 14 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
             foreach (var item in Model)
           {
                if (item.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"product-col\">\r\n                    <div class=\"product\">\r\n                        <figure class=\"product-media\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 628, "\"", 666, 2);
            WriteAttributeValue("", 635, "/Product/Detail/", 635, 16, true);
#nullable restore
#line 22 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
WriteAttributeValue("", 651, item.ProductId, 651, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 706, "\"", 740, 1);
#nullable restore
#line 23 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
WriteAttributeValue("", 712, item.Product.Image.ImageUrl, 712, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product image\">\r\n                            </a>\r\n                        </figure>\r\n\r\n                        <h3 class=\"product-title\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 917, "\"", 955, 2);
            WriteAttributeValue("", 924, "/Product/Detail/", 924, 16, true);
#nullable restore
#line 28 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
WriteAttributeValue("", 940, item.ProductId, 940, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
                                                                 Write(item.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h3>\r\n                    </div>\r\n                </td>\r\n                <td class=\"price-col\">");
#nullable restore
#line 32 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
                                 Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"remove-col\"><button class=\"btn-remove\"");
            BeginWriteAttribute("id", " id=\"", 1193, "\"", 1206, 1);
#nullable restore
#line 33 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
WriteAttributeValue("", 1198, item.Id, 1198, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-close\"");
            BeginWriteAttribute("id", "  id=\"", 1229, "\"", 1243, 1);
#nullable restore
#line 33 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
WriteAttributeValue("", 1235, item.Id, 1235, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></button></td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\WhisList\Default.cshtml"
            }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

</div>
<script>
    $("".btn-remove"").click((e)=>{
        e.preventDefault();
        let id = e.target.id;
        console.log(id);
          $.ajax({
            url:""/WishList/RemoveItem/"",
            method:""Post"",
            data:{id:id},
            success:((d)=>{
                 console.log(d);
          })
        })
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.WhisList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591