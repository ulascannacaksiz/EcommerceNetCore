#pragma checksum "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8568f6324cb899c38568dd1efd92adbc95da8b7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Orders_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Orders/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8568f6324cb899c38568dd1efd92adbc95da8b7c", @"/Views/Shared/Components/Orders/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc391a4420396b5a8f0f6e3d3b90d61245b4390", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Orders_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-12 mt-2\">\r\n    <input  type=\"text\" class=\"form-control\" placeholder=\"Siparişlerimde Ara\"/>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"accordion accordion-rounded\" id=\"accordion-5\">\r\n");
#nullable restore
#line 7 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
         foreach (var item in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card card-box card-sm bg-light"">
            <div class=""card-header"" id=""heading5-1"">
                <h2 class=""card-title"">
                    <a role=""button"" data-toggle=""collapse"" href=""#collapse5-1"" aria-expanded=""true"" aria-controls=""collapse5-1"">
                        <div class=""row"">
                            <div class=""col-md-2""><img style=""border-radius: 60%; height:50px""");
            BeginWriteAttribute("src", " src=\"", 715, "\"", 749, 1);
#nullable restore
#line 14 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
WriteAttributeValue("", 721, item.Product.Image.ImageUrl, 721, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                            <div class=\"col-md-4\">Sipariş No ");
#nullable restore
#line 15 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
                                                        Write(item.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> <small>");
#nullable restore
#line 15 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
                                                                                       Write(item.OrderDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small> </div>\r\n                            <div class=\"col-md-4\"><i class=\"fa-solid fa-circle-check\" style=\"color:#5ad363\"></i> Sipariş Tamamlandı</div>\r\n                            <div class=\"col-md-2\">");
#nullable restore
#line 17 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL <br /> <small>");
#nullable restore
#line 17 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
                                                                          Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small></div>

                        </div>


                    </a>
                </h2>
            </div><!-- End .card-header -->
            <div id=""collapse5-1"" class=""collapse show"" aria-labelledby=""heading5-1"" data-parent=""#accordion-5"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-4""><img style=""border-radius: 60%; height:100px""");
            BeginWriteAttribute("src", " src=\"", 1559, "\"", 1593, 1);
#nullable restore
#line 28 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
WriteAttributeValue("", 1565, item.Product.Image.ImageUrl, 1565, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                        <div class=\"col-md-4\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-12\">");
#nullable restore
#line 31 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
                                                  Write(item.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"col-md-12\">Satıcı:Ulas Express</div>\r\n                                <div class=\"col-md-12\">");
#nullable restore
#line 33 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</div>
                                <div class=""col-md-12""><i class=""fa-solid fa-comments""></i> Ürünü değerlendir</div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <i class=""fa-solid fa-box fa-2x"" style=""border-radius: 40%; ""></i> Teslim Edildi
                                    <br />
                                    <small>Teslim tarihi: 17 Mart 2022</small>
                                    <hr />
                                    <div class=""row"">
                                        <div class=""col-md-12"">
                                            <i class=""fa-solid fa-box fa-2x""></i> Kargo Takibi
                                            <hr/>
                                        </div>
                                        
                                 ");
            WriteLiteral(@"       <div class=""col-md-12"">
                                            <i class=""fa-solid fa-file-invoice fa-2x""></i> Faturayı Görüntüle
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div><!-- End .card-body -->
            </div><!-- End .collapse -->
        </div><!-- End .card -->        
");
#nullable restore
#line 62 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Shared\Components\Orders\Default.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div><!-- End .accordion -->\r\n</div><!-- End .col-md-6 -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
