#pragma checksum "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\MyAccount\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9311b283df33a53fef53b4fe93095ef7f7f4d6bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyAccount_Index), @"mvc.1.0.view", @"/Views/MyAccount/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9311b283df33a53fef53b4fe93095ef7f7f4d6bb", @"/Views/MyAccount/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc391a4420396b5a8f0f6e3d3b90d61245b4390", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MyAccount_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\MyAccount\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-content"">
    <div class=""dashboard"">
        <div class=""container"">
            <div class=""row"">
                <aside class=""col-md-4 col-lg-3"">
                    <ul class=""nav nav-dashboard flex-column mb-3 mb-md-0"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active""  id=""tab-dashboard-link"" data-toggle=""tab"" href=""#tab-dashboard"" role=""tab"" aria-controls=""tab-dashboard"" aria-selected=""true"">Dashboard</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""tab-orders-link""   data-toggle=""tab"" href=""#tab-orders"" role=""tab"" aria-controls=""tab-orders"" aria-selected=""false"">Siparişlerim</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""tab-downloads-link"" data-toggle=""tab"" href=""#tab-downloads"" role=""tab"" aria-controls=""tab-downloads"" aria-selected=""fa");
            WriteLiteral(@"lse"">Değerlendirmelerim</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""tab-address-link"" data-toggle=""tab"" href=""#tab-address"" role=""tab"" aria-controls=""tab-address"" aria-selected=""false"">Adreslerim</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""tab-account-link"" data-toggle=""tab"" href=""#tab-account"" role=""tab"" aria-controls=""tab-account"" aria-selected=""false"">Hesabım</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Çıkış yap</a>
                        </li>
                    </ul>
                </aside><!-- End .col-lg-3 -->

                <div class=""col-md-8 col-lg-9"">
                    <div class=""tab-content"">
                        <div class=""tab-pane fade show active"" id=""tab-dashboard"" role=""tabpanel"" aria-labelledby=""tab");
            WriteLiteral("-dashboard-link\">\r\n                            \r\n                        </div><!-- .End .tab-pane -->\r\n\r\n                        <div class=\"tab-pane fade\" id=\"tab-orders\" role=\"tabpanel\" aria-labelledby=\"tab-orders-link\">\r\n                           ");
#nullable restore
#line 41 "C:\Users\UlasCan\source\repos\EcommerceCore\EcommerceCore\Views\MyAccount\Index.cshtml"
                      Write(await Component.InvokeAsync("Orders"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div><!-- .End .tab-pane -->

                        <div class=""tab-pane fade"" id=""tab-downloads"" role=""tabpanel"" aria-labelledby=""tab-downloads-link"">
                            <p>No downloads available yet.</p>
                            <a href=""category.html"" class=""btn btn-outline-primary-2""><span>GO SHOP</span><i class=""icon-long-arrow-right""></i></a>
                        </div><!-- .End .tab-pane -->

                        <div class=""tab-pane fade"" id=""tab-address"" role=""tabpanel"" aria-labelledby=""tab-address-link"">
                            <p>The following addresses will be used on the checkout page by default.</p>

                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""card card-dashboard"">
                                        <div class=""card-body"">
                                            <h3 class=""card-title"">Billing Address</h3><!-- End .card-");
            WriteLiteral(@"title -->

                                            <p>
                                                User Name<br>
                                                User Company<br>
                                                John str<br>
                                                New York, NY 10001<br>
                                                1-234-987-6543<br>
                                                yourmail@mail.com<br>
                                                <a href=""#"">Edit <i class=""icon-edit""></i></a>
                                            </p>
                                        </div><!-- End .card-body -->
                                    </div><!-- End .card-dashboard -->
                                </div><!-- End .col-lg-6 -->

                                <div class=""col-lg-6"">
                                    <div class=""card card-dashboard"">
                                        <div class=""card-body"">
               ");
            WriteLiteral(@"                             <h3 class=""card-title"">Shipping Address</h3><!-- End .card-title -->

                                            <p>
                                                You have not set up this type of address yet.<br>
                                                <a href=""#"">Edit <i class=""icon-edit""></i></a>
                                            </p>
                                        </div><!-- End .card-body -->
                                    </div><!-- End .card-dashboard -->
                                </div><!-- End .col-lg-6 -->
                            </div><!-- End .row -->
                        </div><!-- .End .tab-pane -->

                        <div class=""tab-pane fade"" id=""tab-account"" role=""tabpanel"" aria-labelledby=""tab-account-link"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9311b283df33a53fef53b4fe93095ef7f7f4d6bb9684", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <label>First Name *</label>
                                        <input type=""text"" class=""form-control"" required>
                                    </div><!-- End .col-sm-6 -->

                                    <div class=""col-sm-6"">
                                        <label>Last Name *</label>
                                        <input type=""text"" class=""form-control"" required>
                                    </div><!-- End .col-sm-6 -->
                                </div><!-- End .row -->

                                <label>Display Name *</label>
                                <input type=""text"" class=""form-control"" required>
                                <small class=""form-text"">This will be how your name will be displayed in the account section and in reviews</small>

                                <label>Ema");
                WriteLiteral(@"il address *</label>
                                <input type=""email"" class=""form-control"" required>

                                <label>Current password (leave blank to leave unchanged)</label>
                                <input type=""password"" class=""form-control"">

                                <label>New password (leave blank to leave unchanged)</label>
                                <input type=""password"" class=""form-control"">

                                <label>Confirm new password</label>
                                <input type=""password"" class=""form-control mb-2"">

                                <button type=""submit"" class=""btn btn-outline-primary-2"">
                                    <span>SAVE CHANGES</span>
                                    <i class=""icon-long-arrow-right""></i>
                                </button>
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
                        </div><!-- .End .tab-pane -->
                    </div>
                </div><!-- End .col-lg-9 -->
            </div><!-- End .row -->
        </div><!-- End .container -->
    </div><!-- End .dashboard -->
</div><!-- End .page-content -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591