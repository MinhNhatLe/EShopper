#pragma checksum "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00df2138140ce67e30762a6bd1c7d839247ebdcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Cart), @"mvc.1.0.view", @"/Views/Cart/Cart.cshtml")]
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
#line 1 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\_ViewImports.cshtml"
using AdvancedEShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\_ViewImports.cshtml"
using AdvancedEShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00df2138140ce67e30762a6bd1c7d839247ebdcc", @"/Views/Cart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46298634653a976947a73d18a05c65b0023e47bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- Page Header Start -->
<div class=""container-fluid bg-secondary mb-5"">
    <div class=""d-flex flex-column align-items-center justify-content-center"" style=""min-height: 300px"">
        <h1 class=""font-weight-semi-bold text-uppercase mb-3"">Shopping Cart</h1>
        <div class=""d-inline-flex"">
            <p class=""m-0""><a");
            BeginWriteAttribute("href", " href=\"", 344, "\"", 351, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home</a></p>
            <p class=""m-0 px-2"">-</p>
            <p class=""m-0"">Shopping Cart</p>
        </div>
    </div>
</div>
<!-- Page Header End -->
<!-- Cart Start -->
<div class=""container-fluid pt-5"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-8 table-responsive mb-5"">
            <table class=""table table-bordered text-center mb-0"">
                <thead class=""bg-secondary text-dark"">
                    <tr>
                        <th>Products</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th>Remove</th>
                    </tr>
                </thead>
                <tbody class=""align-middle"">
");
#nullable restore
#line 29 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
                     foreach (var line in Model?.Lines ?? Enumerable.Empty<CartLine>())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"align-middle\"><img");
            BeginWriteAttribute("src", " src=\"", 1310, "\"", 1342, 1);
#nullable restore
#line 32 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 1316, line.Product.ProductPhoto, 1316, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1343, "\"", 1349, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 50px;\"> ");
#nullable restore
#line 32 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
                                                                                                                   Write(line.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\">$");
#nullable restore
#line 33 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
                                                  Write(line.Product.ProductPrice * (1 - line.Product.ProductDiscount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""align-middle"">
                                <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                    <div class=""input-group-btn"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1793, "\"", 1851, 2);
            WriteAttributeValue("", 1800, "/Cart/UpdateCart/?productId=", 1800, 28, true);
#nullable restore
#line 37 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 1828, line.Product.ProductId, 1828, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm btn-primary btn-minus"">
                                            <i class=""fa fa-minus""></i>
                                        </a>
                                    </div>
                                    <input type=""text"" class=""form-control form-control-sm bg-secondary text-center""");
            BeginWriteAttribute("value", " value=\"", 2175, "\"", 2197, 1);
#nullable restore
#line 41 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 2183, line.Quantity, 2183, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"input-group-btn\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2310, "\"", 2367, 2);
            WriteAttributeValue("", 2317, "/Cart/AddToCart/?productId=", 2317, 27, true);
#nullable restore
#line 43 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 2344, line.Product.ProductId, 2344, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm btn-primary btn-plus"">
                                            <i class=""fa fa-plus""></i>
                                        </a>
                                    </div>
                                </div>
                            </td>
                            <td class=""align-middle"">$");
#nullable restore
#line 49 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
                                                  Write(line.Product.ProductPrice * (1 - line.Product.ProductDiscount) * line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\"><a");
            BeginWriteAttribute("href", " href=\"", 2845, "\"", 2907, 2);
            WriteAttributeValue("", 2852, "/Cart/RemoveFromCart/?productId=", 2852, 32, true);
#nullable restore
#line 50 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 2884, line.Product.ProductId, 2884, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\"><i class=\"fa fa-times\"></i></a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-lg-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00df2138140ce67e30762a6bd1c7d839247ebdcc10474", async() => {
                WriteLiteral(@"
                <div class=""input-group"">
                    <input type=""text"" class=""form-control p-4"" placeholder=""Coupon Code"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-primary"">Apply Coupon</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""card border-secondary mb-5"">
                <div class=""card-header bg-secondary border-0"">
                    <h4 class=""font-weight-semi-bold m-0"">Cart Summary</h4>
                </div>
                <div class=""card-body"">
                    <div class=""d-flex justify-content-between mb-3 pt-1"">
                        <h6 class=""font-weight-medium"">Subtotal</h6>
                        <h6 class=""font-weight-medium"">$");
#nullable restore
#line 72 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
                                                   Write(Model.ComputeTotalValue());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    </div>
                    <div class=""d-flex justify-content-between"">
                        <h6 class=""font-weight-medium"">Shipping</h6>
                        <h6 class=""font-weight-medium"">$10</h6>
                    </div>
                </div>
                <div class=""card-footer border-secondary bg-transparent"">
                    <div class=""d-flex justify-content-between mt-2"">
                        <h5 class=""font-weight-bold"">Total</h5>
                        <h5 class=""font-weight-bold"">$");
#nullable restore
#line 82 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Cart\Cart.cshtml"
                                                  Write(Model.ComputeTotalValue() + 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <button class=\"btn btn-block btn-primary my-3 py-3\">Proceed To Checkout</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Cart End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
