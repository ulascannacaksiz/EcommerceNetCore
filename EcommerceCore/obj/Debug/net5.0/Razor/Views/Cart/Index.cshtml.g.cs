#pragma checksum "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4722d93db6bb5f682a34d0be7607a5f82e8f67a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4722d93db6bb5f682a34d0be7607a5f82e8f67a8", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc391a4420396b5a8f0f6e3d3b90d61245b4390", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
  
    int index = 0;
    int toplam = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-content\">\r\n    <div class=\"cart\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 15 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
             if (Model != null)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-lg-9"">
                        <table class=""table table-cart table-mobile"">
                            <thead>
                                <tr>
                                    <th>Ürün</th>
                                    <th>Fiyat</th>
                                    <th>Adet</th>
                                    <th>Toplam</th>
                                    <th></th>
                                </tr>
                            </thead>

                            <tbody>

");
#nullable restore
#line 33 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td class=""product-col"">
                                            <div class=""product"">
                                                <figure class=""product-media"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 1325, "\"", 1356, 2);
            WriteAttributeValue("", 1332, "/Product/Detail/", 1332, 16, true);
#nullable restore
#line 39 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1348, item.Id, 1348, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 1420, "\"", 1446, 1);
#nullable restore
#line 40 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1426, item.Image.ImageUrl, 1426, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Product image"">
                                                    </a>
                                                </figure>

                                                <h3 class=""product-title"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 1719, "\"", 1750, 2);
            WriteAttributeValue("", 1726, "/Product/Detail/", 1726, 16, true);
#nullable restore
#line 45 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1742, item.Id, 1742, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </h3><!-- End .product-title -->\r\n                                    </div><!-- End .product -->\r\n                                </td>\r\n                                        <td class=\"price-col\">");
#nullable restore
#line 49 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n");
#nullable restore
#line 50 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                         foreach (var viewb in ViewBag.v1)
                                        {
                                            if (viewb.Id == item.Id)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td class=\"quantity-col\">\r\n                                                    <div class=\"cart-product-quantity\">\r\n                                                        <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 2514, "\"", 2527, 1);
#nullable restore
#line 56 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2519, item.Id, 2519, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2528, "\"", 2544, 1);
#nullable restore
#line 56 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2536, item.Id, 2536, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                        <input type=\"number\" id=\"cnt\" class=\"form-control cnt\"");
            BeginWriteAttribute("value", " value=\"", 2660, "\"", 2680, 1);
#nullable restore
#line 57 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2668, viewb.Total, 2668, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\" max=\"10\" step=\"1\" data-decimals=\"0\" required>\r\n\r\n                                                    </div><!-- End .cart-product-quantity -->\r\n                                </td>\r\n");
#nullable restore
#line 61 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"

                                                toplam += item.Price * viewb.Total;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td class=\"total-col\">");
#nullable restore
#line 64 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                                                  Write(item.Price * viewb.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n                                                <td class=\"remove-col\"><button class=\"btn-remove\"");
            BeginWriteAttribute("id", " id=\"", 3166, "\"", 3179, 1);
#nullable restore
#line 65 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3171, item.Id, 3171, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-close\"");
            BeginWriteAttribute("id", " id=\"", 3202, "\"", 3215, 1);
#nullable restore
#line 65 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3207, item.Id, 3207, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></button></td>\r\n");
#nullable restore
#line 66 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 69 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"

                                    index++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                            </tbody>\r\n                        </table><!-- End .table table-wishlist -->\r\n\r\n                    <div class=\"cart-bottom\">\r\n                            <div class=\"cart-discount\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4722d93db6bb5f682a34d0be7607a5f82e8f67a812559", async() => {
                WriteLiteral(@"
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control"" required placeholder=""coupon code"">
                                        <div class=""input-group-append"">
                                            <button class=""btn btn-outline-primary-2"" type=""submit""><i class=""icon-long-arrow-right""></i></button>
                                        </div><!-- .End .input-group-append -->
                                </div><!-- End .input-group -->
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div><!-- End .cart-discount -->

                        <a href=""#"" class=""btn btn-outline-dark-2""><span>SEPETİ GÜNCELLE</span><i class=""icon-refresh""></i></a>
                        </div><!-- End .cart-bottom -->
                </div><!-- End .col-lg-9 -->
                <aside class=""col-lg-3"">
                        <div class=""summary summary-cart"">
                            <h3 class=""summary-title"">Sepet</h3><!-- End .summary-title -->

                        <table class=""table table-summary"">
                                <tbody>
                                    <tr class=""summary-subtotal"">
                                        <td>Ara Toplam:</td>
                                        <td>");
#nullable restore
#line 102 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                       Write(toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</td>
                                    </tr><!-- End .summary-subtotal -->
                                <tr class=""summary-shipping"">
                                        <td>Kargo:</td>
                                        <td>&nbsp;</td>
                                    </tr>

                                    <tr class=""summary-shipping-row"">
                                        <td>
                                            <div class=""custom-control custom-radio"">
                                                <input type=""radio"" id=""free-shipping"" name=""shipping"" class=""custom-control-input"">
                                                <label class=""custom-control-label"" for=""free-shipping"">Bedava Kargo</label>
                                            </div><!-- End .custom-control -->
                                    </td>
                                        <td>$0.00</td>
                                    </tr><!-- End .summary-shipping-row -->");
            WriteLiteral(@"

                                <tr class=""summary-shipping-row"">
                                        <td>
                                            <div class=""custom-control custom-radio"">
                                                <input type=""radio"" id=""standart-shipping"" name=""shipping"" class=""custom-control-input"">
                                                <label class=""custom-control-label"" for=""standart-shipping"">Standart:</label>
                                            </div><!-- End .custom-control -->
                                    </td>
                                        <td>$10.00</td>
                                    </tr><!-- End .summary-shipping-row -->

                                <tr class=""summary-shipping-row"">
                                        <td>
                                            <div class=""custom-control custom-radio"">
                                                <input type=""radio"" id=""express-shipping"" name=""s");
            WriteLiteral(@"hipping"" class=""custom-control-input"">
                                                <label class=""custom-control-label"" for=""express-shipping"">Express:</label>
                                            </div><!-- End .custom-control -->
                                    </td>
                                        <td>$20.00</td>
                                    </tr><!-- End .summary-shipping-row -->



                                <tr class=""summary-total"">
                                        <td>Toplam:</td>
                                        <td>");
#nullable restore
#line 143 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
                                       Write(toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</td>
                                    </tr><!-- End .summary-total -->
                            </tbody>
                            </table><!-- End .table table-summary -->

                        <a href=""checkout.html"" class=""btn btn-outline-primary-2 btn-order btn-block"">ÖDEME ADIMINA GEÇ</a>
                        </div><!-- End .summary -->

                    <a href=""category.html"" class=""btn btn-outline-dark-2 btn-block mb-3""><span>ALIŞVERİŞE DEVAM ET</span><i class=""icon-refresh""></i></a>
                    </aside><!-- End .col-lg-3 -->
            </div>
");
#nullable restore
#line 154 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"



            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 159 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
             if (Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""text-center mt-5"">
                    <i class=""fa-solid fa-cart-shopping fa-5x""></i>
                    <h4>Sepetin şu an boş</h4>
                    <h5>
                        Sepetini UlasShopun fırsatlarla dolu dünyasından doldurmak için
                        aşağıdaki ürünleri incelemeye başlayabilirsin.
                    </h5>
                </div>
");
#nullable restore
#line 169 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div><!-- End .container -->
    </div><!-- End .cart -->
</div>

<script>
    $("".cart-product-quantity"").on('change',(e)=>{
        let count = e.target.value;
        let id  = e.target.previousSibling.previousSibling.value;
        $.ajax({
            url:""/Cart/UpdateCart/"",
            method:""Post"",
            data:{productId:id,q:count},
            success:((d)=>{
                 location.reload(); 
            })
        })
    })
    $("".btn-remove"").click((e)=>{
        let id = e.target.id;
          $.ajax({
            url:""/Cart/UpdateCart/"",
            method:""Post"",
            data:{productId:id,q:0},
            success:((d)=>{
                 location.reload(); 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
