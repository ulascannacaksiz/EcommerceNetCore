#pragma checksum "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e334346b702191128e5050753aa6367df7998428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e334346b702191128e5050753aa6367df7998428", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc391a4420396b5a8f0f6e3d3b90d61245b4390", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "popularity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
  
    var category = 0;
    var categoryId = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9"">
                <div class=""toolbox"">
                    <div class=""toolbox-left"">
                        <div class=""toolbox-info"">
                            Showing <span>9 of 56</span> Products
                        </div><!-- End .toolbox-info -->
                    </div><!-- End .toolbox-left -->

                    <div class=""toolbox-right"">
                        <div class=""toolbox-sort"">
                            <label for=""sortby"">Sıralama:</label>
                            <div class=""select-custom"">
                                <select name=""sortby"" id=""sortby"" class=""form-control"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e334346b702191128e5050753aa6367df79984285745", async() => {
                WriteLiteral("Çok satanlar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e334346b702191128e5050753aa6367df79984287029", async() => {
                WriteLiteral("Artan fiyat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e334346b702191128e5050753aa6367df79984288229", async() => {
                WriteLiteral("Azalan fiyat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e334346b702191128e5050753aa6367df79984289430", async() => {
                WriteLiteral("Çok değerlendirilenler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e334346b702191128e5050753aa6367df799842810641", async() => {
                WriteLiteral("Yeni Eklenenler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                        </div><!-- End .toolbox-sort -->

                    </div><!-- End .toolbox-right -->
                </div><!-- End .toolbox -->

                <div class=""products mb-3"">
                    <div class=""row justify-content-center"" id=""productalani"">

");
#nullable restore
#line 43 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                         foreach (var item in Model)
                        {
                            categoryId = item.CategoryId;
                            category = item.Category.ParentId;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-6 col-md-4 col-lg-4 col-xl-3"">
                                <div class=""product product-7 text-center"">
                                    <figure class=""product-media"">
                                        <span class=""product-label label-new"">New</span>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2324, "\"", 2355, 2);
            WriteAttributeValue("", 2331, "/Product/Detail/", 2331, 16, true);
#nullable restore
#line 51 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 2347, item.Id, 2347, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2407, "\"", 2433, 1);
#nullable restore
#line 52 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 2413, item.Image.ImageUrl, 2413, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Product image"" class=""product-image"">
                                        </a>

                                        <div class=""product-action-vertical"">
                                            <a href=""#"" class=""btn-product-icon btn-wishlist btn-expandable""><span>İstek listeme ekle</span></a>
                                            <a href=""#"" class=""btn-product-icon btn-compare"" title=""Compare""><span>Karşılaştır</span></a>
                                        </div><!-- End .product-action-vertical -->

                                    <div class=""product-action"">
                                            <a href=""#"" class=""btn-product btn-cart""");
            BeginWriteAttribute("id", " id=\"", 3128, "\"", 3141, 1);
#nullable restore
#line 61 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 3133, item.Id, 3133, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""btn-cart"" style=""font-size:15px;"">Sepete Ekle</a>
                                        </div><!-- End .product-action -->
                                </figure><!-- End .product-media -->

                                <div class=""product-body"">
                                        <div class=""product-cat"">
                                            <a href=""#"">");
#nullable restore
#line 67 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div><!-- End .product-cat -->\r\n                                    <h3 class=\"product-title\"><a");
            BeginWriteAttribute("href", " href=\"", 3701, "\"", 3732, 2);
            WriteAttributeValue("", 3708, "/Product/Detail/", 3708, 16, true);
#nullable restore
#line 69 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 3724, item.Id, 3724, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                                                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3><!-- End .product-title -->\r\n                                    <div class=\"product-price\">\r\n                                            ");
#nullable restore
#line 71 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL
                                        </div><!-- End .product-price -->
                                    <div class=""ratings-container"">
                                            <div class=""ratings"">
                                                <div class=""ratings-val"" style=""width: 50%;""></div><!-- End .ratings-val -->
                                        </div><!-- End .ratings -->
                                        <span class=""ratings-text"">(2)</span>
                                        </div><!-- End .rating-container -->

                                </div><!-- End .product-body -->
                            </div><!-- End .product -->
                        </div>
");
            WriteLiteral("                            <!-- End .col-sm-6 col-lg-4 col-xl-3 -->\r\n");
#nullable restore
#line 85 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div><!-- End .row -->
                </div><!-- End .products -->


                <nav aria-label=""Page navigation"">
                    <ul class=""pagination justify-content-center"">
                        <li class=""page-item disabled"">
                            <a class=""page-link page-link-prev"" href=""#"" aria-label=""Previous"" tabindex=""-1"" aria-disabled=""true"">
                                <span aria-hidden=""true""><i class=""icon-long-arrow-left""></i></span>Prev
                            </a>
                        </li>
                        <li class=""page-item active"" aria-current=""page""><a class=""page-link"" href=""#"">1</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                        <li class=""page-item-total"">of 6</li>
                        <li class=""page-item"">
                            <a class=""page-link");
            WriteLiteral(@" page-link-next"" href=""#"" aria-label=""Next"">
                                Next <span aria-hidden=""true""><i class=""icon-long-arrow-right""></i></span>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div><!-- End .col-lg-9 -->
            <aside class=""col-lg-3 order-lg-first"">
                <div class=""sidebar sidebar-shop"">
                    <div class=""widget widget-clean"">
                        <label>Filitreler:</label>
                        <a href=""#"" class=""sidebar-filter-clear"">Tümünü temizle</a>
                    </div><!-- End .widget widget-clean -->
");
#nullable restore
#line 115 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                     if (category == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""widget widget-collapsible"">
                            <h3 class=""widget-title"">
                                <a data-toggle=""collapse"" href=""#widget-2"" role=""button"" aria-expanded=""true"" aria-controls=""widget-2"">
                                    Beden
                                </a>
                            </h3><!-- End .widget-title -->

                        <div class=""collapse show"" id=""widget-2"">
                                <div class=""widget-body"">
                                    <div class=""filter-items"">
                                        <div class=""filter-item"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""size-1"">
                                                <label class=""custom-control-label"" for=""size-1"">XS</label>
                                            </div><!-");
            WriteLiteral(@"- End .custom-checkbox -->
                                    </div><!-- End .filter-item -->

                                    <div class=""filter-item"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""size-2"">
                                                <label class=""custom-control-label"" for=""size-2"">S</label>
                                            </div><!-- End .custom-checkbox -->
                                    </div><!-- End .filter-item -->

                                    <div class=""filter-item"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" checked id=""size-3"">
                                                <label class=""custom-control-label"" for=""size-3"">M</label>
               ");
            WriteLiteral(@"                             </div><!-- End .custom-checkbox -->
                                    </div><!-- End .filter-item -->

                                    <div class=""filter-item"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" checked id=""size-4"">
                                                <label class=""custom-control-label"" for=""size-4"">L</label>
                                            </div><!-- End .custom-checkbox -->
                                    </div><!-- End .filter-item -->

                                    <div class=""filter-item"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""size-5"">
                                                <label class=""custom-control-label"" f");
            WriteLiteral(@"or=""size-5"">XL</label>
                                            </div><!-- End .custom-checkbox -->
                                    </div><!-- End .filter-item -->

                                    <div class=""filter-item"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""size-6"">
                                                <label class=""custom-control-label"" for=""size-6"">XXL</label>
                                            </div><!-- End .custom-checkbox -->
                                    </div><!-- End .filter-item -->
                                </div><!-- End .filter-items -->
                            </div><!-- End .widget-body -->
                        </div><!-- End .collapse -->
                        </div>
");
            WriteLiteral("                        <!-- End .widget -->\r\n");
#nullable restore
#line 174 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""widget widget-collapsible"">
                        <h3 class=""widget-title"">
                            <a data-toggle=""collapse"" href=""#widget-3"" role=""button"" aria-expanded=""true"" aria-controls=""widget-3"">
                                Renk
                            </a>
                        </h3><!-- End .widget-title -->

                        <div class=""collapse show"" id=""widget-3"">
                            <div class=""widget-body"">
                                <div class=""filter-colors"">
                                    <a href=""#"" style=""background: #b87145;""><span class=""sr-only"">Color Name</span></a>
                                    <a href=""#"" style=""background: #f0c04a;""><span class=""sr-only"">Color Name</span></a>
                                    <a href=""#"" style=""background: #333333;""><span class=""sr-only"">Color Name</span></a>
                                    <a href=""#"" class=""selected"" style=""background: #cc3333;""><span");
            WriteLiteral(@" class=""sr-only"">Color Name</span></a>
                                    <a href=""#"" style=""background: #3399cc;""><span class=""sr-only"">Color Name</span></a>
                                    <a href=""#"" style=""background: #669933;""><span class=""sr-only"">Color Name</span></a>
                                    <a href=""#"" style=""background: #f2719c;""><span class=""sr-only"">Color Name</span></a>
                                    <a href=""#"" style=""background: #ebebeb;""><span class=""sr-only"">Color Name</span></a>
                                </div><!-- End .filter-colors -->
                            </div><!-- End .widget-body -->
                        </div><!-- End .collapse -->
                    </div><!-- End .widget -->

                    <div class=""widget widget-collapsible"">
                        <h3 class=""widget-title"">
                            <a data-toggle=""collapse"" href=""#widget-4"" role=""button"" aria-expanded=""true"" aria-controls=""widget-4"">
                   ");
            WriteLiteral(@"             Marka
                            </a>
                        </h3><!-- End .widget-title -->

                        <div class=""collapse show"" id=""widget-4"">
                            <div class=""widget-body"">
                                <div class=""filter-items"">
");
#nullable restore
#line 208 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                                     foreach (var brand in ViewBag.Brands)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""filter-item"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" name=""brand"" class=""custom-control-input""");
            BeginWriteAttribute("value", " value=\"", 13271, "\"", 13285, 1);
#nullable restore
#line 212 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 13279, brand, 13279, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 13286, "\"", 13297, 1);
#nullable restore
#line 212 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 13291, brand, 13291, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 13384, "\"", 13396, 1);
#nullable restore
#line 213 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 13390, brand, 13390, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 213 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                                                                                            Write(brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            </div><!-- End .custom-checkbox -->\r\n                                    </div>\r\n");
#nullable restore
#line 216 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div><!-- End .filter-items -->
                            </div><!-- End .widget-body -->
                        </div><!-- End .collapse -->
                    </div><!-- End .widget -->

                    <div class=""widget widget-collapsible"">
                        <h3 class=""widget-title"">
                            <a data-toggle=""collapse"" href=""#widget-5"" role=""button"" aria-expanded=""true"" aria-controls=""widget-5"">
                                Fiyat
                            </a>
                        </h3><!-- End .widget-title -->

                        <div class=""collapse show"" id=""widget-5"">
                            <div class=""widget-body"">
                                <div class=""filter-price"">
                                    <div class=""filter-price-text"">
                                        Price Range:
                                        <span id=""filter-price-range""></span>
                              ");
            WriteLiteral(@"      </div><!-- End .filter-price-text -->

                                    <div id=""price-slider""></div><!-- End #price-slider -->
                                </div><!-- End .filter-price -->
                            </div><!-- End .widget-body -->
                        </div><!-- End .collapse -->
                    </div><!-- End .widget -->
                </div><!-- End .sidebar sidebar-shop -->
            </aside><!-- End .col-lg-3 -->
        </div><!-- End .row -->
    </div><!-- End .container -->
</div>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script>
     var selectedbrands = [];
           
    $('.custom-control-input').click((e)=>{
         if(e.target.checked == true){
             selectedbr");
            WriteLiteral("ands.push(e.target.value);\r\n        }\r\n        \r\n         var data = { id:");
#nullable restore
#line 258 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\Category\Index.cshtml"
                    Write(categoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" , brands:selectedbrands };
        $.ajax({
            url:""/Category/Index/"",
            method:""post"",
            data:data,
            success:((returneddata)=>{
               
                 let convertdata = JSON.parse(returneddata);
                 let deger="""";
                  $.each(convertdata,(index,value)=>{

                         deger+=   `<div class=""col-6 col-md-4 col-lg-4 col-xl-3"">
                                 <div class=""product product-7 text-center"">
                                     <figure class=""product-media"">
                                         <span class=""product-label label-new"">New</span>
                                         <a href=""${value.Id}"">
                                             <img src=""${value.Image.ImageUrl}"" alt=""Product image"" class=""product-image"">
                                         </a>

                                         <div class=""product-action-vertical"">
                                        ");
            WriteLiteral(@"     <a href=""#"" class=""btn-product-icon btn-wishlist btn-expandable""><span>add to wishlist</span></a>
                                             <a href=""popup/quickView.html"" class=""btn-product-icon btn-quickview"" title=""Quick view""><span>Quick view</span></a>
                                             <a href=""#"" class=""btn-product-icon btn-compare"" title=""Compare""><span>Compare</span></a>
                                         </div>

                                     <div class=""product-action"">
                                             <a href=""#"" class=""btn-product btn-cart""><span>Sepete Ekle</span></a>
                                         </div>
                                 </figure>

                                 <div class=""product-body"">
                                         <div class=""product-cat"">
                                             <a href=""#""> ${value.Category.CategoryName}</a>
                                         </div>
                    ");
            WriteLiteral(@"                 <h3 class=""product-title""><a href=""product.html"">${value.Title}</a></h3>>
                                     <div class=""product-price"">
                                             ${value.Price} TL
                                         </div>
                                     <div class=""ratings-container"">
                                             <div class=""ratings"">
                                                 <div class=""ratings-val"" style=""width: 50%;""></div>
                                         </div>
                                         <span class=""ratings-text"">(2)</span>
                                         </div>
                                 </div>
                             </div>
                         </div>`
                  });
                  $(""#productalani"").html(deger);

            })
        });
    })


        $(""[name='btn-cart']"").click((e)=>{
        e.preventDefault();
         let id = e.target.id;
");
            WriteLiteral(@"         console.log(id)
         let qty = 1;
         //console.log(qty);
         $.ajax({
             url:""/Cart/AddToChart/"",
             method:""Post"",
             data: {productId:id,q:qty},
             success: (()=>{
                    Swal.fire(
                    'Başarılı!',
                    'Ürün sepetine eklendi',
                    'success'
                    );
             })
         })
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
