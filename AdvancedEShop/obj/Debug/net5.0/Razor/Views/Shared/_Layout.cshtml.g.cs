#pragma checksum "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64a28f275ee4fe8ae90c54d4c6bea7537fa011ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 123 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a28f275ee4fe8ae90c54d4c6bea7537fa011ef", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46298634653a976947a73d18a05c65b0023e47bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a28f275ee4fe8ae90c54d4c6bea7537fa011ef4709", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>EShopper - Bootstrap Shop Template</title>
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">
    <meta content=""Free HTML Templates"" name=""keywords"">
    <meta content=""Free HTML Templates"" name=""description"">

    <!-- Favicon -->
    <link href=""img/favicon.ico"" rel=""icon"">

    <!-- Google Web Fonts -->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap"" rel=""stylesheet"">

    <!-- Font Awesome -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css"" rel=""stylesheet"">

    <!-- Libraries Stylesheet -->
    <link href=""/lib/owlcarousel/assets/owl.carousel.min.css"" rel=""stylesheet"">

    <!-- Customized Bootstrap Stylesheet -->
    <link href=""/css/style.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a28f275ee4fe8ae90c54d4c6bea7537fa011ef6655", async() => {
                WriteLiteral(@"
    <!-- Topbar Start -->
    <div class=""container-fluid"">
        <div class=""row bg-secondary py-2 px-xl-5"">
            <div class=""col-lg-6 d-none d-lg-block"">
                <div class=""d-inline-flex align-items-center"">
                    <a class=""text-dark""");
                BeginWriteAttribute("href", " href=\"", 1276, "\"", 1283, 0);
                EndWriteAttribute();
                WriteLiteral(">FAQs</a>\r\n                    <span class=\"text-muted px-2\">|</span>\r\n                    <a class=\"text-dark\"");
                BeginWriteAttribute("href", " href=\"", 1395, "\"", 1402, 0);
                EndWriteAttribute();
                WriteLiteral(">Help</a>\r\n                    <span class=\"text-muted px-2\">|</span>\r\n                    <a class=\"text-dark\"");
                BeginWriteAttribute("href", " href=\"", 1514, "\"", 1521, 0);
                EndWriteAttribute();
                WriteLiteral(">Support</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 text-center text-lg-right\">\r\n                <div class=\"d-inline-flex align-items-center\">\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 1751, "\"", 1758, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-facebook-f\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 1892, "\"", 1899, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-twitter\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 2030, "\"", 2037, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-linkedin-in\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 2172, "\"", 2179, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-instagram\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark pl-2\"");
                BeginWriteAttribute("href", " href=\"", 2312, "\"", 2319, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <i class=""fab fa-youtube""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""row align-items-center py-3 px-xl-5"">
            <div class=""col-lg-3 d-none d-lg-block"">
                <a href=""/Home/Index"" class=""text-decoration-none"">
                    <h1 class=""m-0 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border px-3 mr-1"">E</span>Shopper</h1>
                </a>
            </div>
            <div class=""col-lg-6 col-6 text-left"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a28f275ee4fe8ae90c54d4c6bea7537fa011ef10068", async() => {
                    WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" name=""keywords"" class=""form-control"" placeholder=""Search for products"">
                        <div class=""input-group-append"">
                            <span class=""input-group-text bg-transparent text-primary"">
                                <button type=""submit"" class=""fa fa-search"" style="" border: none; background: none;""></button>
");
                    WriteLiteral("                            </span>\r\n                        </div>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 text-right\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 3678, "\"", 3685, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn border\">\r\n                    <i class=\"fas fa-heart text-primary\"></i>\r\n                    <span class=\"badge\">0</span>\r\n                </a>\r\n                ");
#nullable restore
#line 85 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml"
           Write(await Component.InvokeAsync("CartWidget"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Topbar End -->\r\n    <!-- Navbar Start -->\r\n    <div class=\"container-fluid mb-5\">\r\n        <div class=\"row border-top px-xl-5\">\r\n\r\n            ");
#nullable restore
#line 95 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml"
       Write(await Component.InvokeAsync("Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-lg-9\">\r\n                <nav class=\"navbar navbar-expand-lg bg-light navbar-light py-3 py-lg-0 px-0\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4300, "\"", 4307, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none d-block d-lg-none"">
                        <h1 class=""m-0 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border px-3 mr-1"">E</span>Shopper</h1>
                    </a>
                    <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarCollapse"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                        <div class=""navbar-nav mr-auto py-0"">
                            <a href=""/Home/Index"" class=""nav-item nav-link active"">Home</a>
                            <a href=""/Products/Index"" class=""nav-item nav-link"">Shop</a>
                            <a href=""detail.html"" class=""nav-item nav-link"">Shop Detail</a>
                            <div class=""nav-item dropdown"">
                                <a href=""#"" class=""nav-link dropdown-to");
                WriteLiteral(@"ggle"" data-toggle=""dropdown"">Pages</a>
                                <div class=""dropdown-menu rounded-0 m-0"">
                                    <a href=""/Cart"" class=""dropdown-item"">Shopping Cart</a>
                                    <a href=""/Cart/Checkout"" class=""dropdown-item"">Checkout</a>
                                </div>
                            </div>
                            <a href=""contact.html"" class=""nav-item nav-link"">Contact</a>
                        </div>
                        <div class=""navbar-nav ml-auto py-0"">
");
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 6252, "\"", 6259, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">\r\n                                <span>Hello ");
#nullable restore
#line 125 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml"
                                       Write(Context.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("!</span>\r\n\r\n                            </a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 6443, "\"", 6488, 1);
#nullable restore
#line 128 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6450, Url.Action("Logout", "Authorization"), 6450, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-item nav-link"">Log out</a>
                        </div>
                    </div>
                </nav>
                <div id=""header-carousel"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"" style=""height: 410px;"">
                            <img class=""img-fluid"" src=""/img/carousel-1.jpg"" alt=""Image"">
                            <div class=""carousel-caption d-flex flex-column align-items-center justify-content-center"">
                                <div class=""p-3"" style=""max-width: 700px;"">
                                    <h4 class=""text-light text-uppercase font-weight-medium mb-3"">10% Off Your First Order</h4>
                                    <h3 class=""display-4 text-white font-weight-semi-bold mb-4"">Fashionable Dress</h3>
                                    <a");
                BeginWriteAttribute("href", " href=\"", 7410, "\"", 7417, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-light py-2 px-3"">Shop Now</a>
                                </div>
                            </div>
                        </div>
                        <div class=""carousel-item"" style=""height: 410px;"">
                            <img class=""img-fluid"" src=""/img/carousel-2.jpg"" alt=""Image"">
                            <div class=""carousel-caption d-flex flex-column align-items-center justify-content-center"">
                                <div class=""p-3"" style=""max-width: 700px;"">
                                    <h4 class=""text-light text-uppercase font-weight-medium mb-3"">10% Off Your First Order</h4>
                                    <h3 class=""display-4 text-white font-weight-semi-bold mb-4"">Reasonable Price</h3>
                                    <a");
                BeginWriteAttribute("href", " href=\"", 8224, "\"", 8231, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-light py-2 px-3"">Shop Now</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#header-carousel"" data-slide=""prev"">
                        <div class=""btn btn-dark"" style=""width: 45px; height: 45px;"">
                            <span class=""carousel-control-prev-icon mb-n2""></span>
                        </div>
                    </a>
                    <a class=""carousel-control-next"" href=""#header-carousel"" data-slide=""next"">
                        <div class=""btn btn-dark"" style=""width: 45px; height: 45px;"">
                            <span class=""carousel-control-next-icon mb-n2""></span>
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <!-- Navbar End -->



    ");
#nullable restore
#line 173 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n    <!-- Footer Start -->\r\n    <div class=\"container-fluid bg-secondary text-dark mt-5 pt-5\">\r\n        <div class=\"row px-xl-5 pt-5\">\r\n            <div class=\"col-lg-4 col-md-12 mb-5 pr-3 pr-xl-5\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 9412, "\"", 9419, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <h1 class=""mb-4 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border border-white px-3 mr-1"">E</span>Shopper</h1>
                </a>
                <p>Dolore erat dolor sit lorem vero amet. Sed sit lorem magna, ipsum no sit erat lorem et magna ipsum dolore amet erat.</p>
                <p class=""mb-2""><i class=""fa fa-map-marker-alt text-primary mr-3""></i>123 Street, New York, USA</p>
                <p class=""mb-2""><i class=""fa fa-envelope text-primary mr-3""></i>info@example.com</p>
                <p class=""mb-0""><i class=""fa fa-phone-alt text-primary mr-3""></i>+012 345 67890</p>
            </div>
            <div class=""col-lg-8 col-md-12"">
                <div class=""row"">
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4"">Quick Links</h5>
                        <div class=""d-flex flex-column justify-content-start"">
                            ");
                WriteLiteral(@"<a class=""text-dark mb-2"" href=""index.html""><i class=""fa fa-angle-right mr-2""></i>Home</a>
                            <a class=""text-dark mb-2"" href=""shop.html""><i class=""fa fa-angle-right mr-2""></i>Our Shop</a>
                            <a class=""text-dark mb-2"" href=""detail.html""><i class=""fa fa-angle-right mr-2""></i>Shop Detail</a>
                            <a class=""text-dark mb-2"" href=""cart.html""><i class=""fa fa-angle-right mr-2""></i>Shopping Cart</a>
                            <a class=""text-dark mb-2"" href=""checkout.html""><i class=""fa fa-angle-right mr-2""></i>Checkout</a>
                            <a class=""text-dark"" href=""contact.html""><i class=""fa fa-angle-right mr-2""></i>Contact Us</a>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4"">Quick Links</h5>
                        <div class=""d-flex flex-column justify-content-start"">
                            ");
                WriteLiteral(@"<a class=""text-dark mb-2"" href=""index.html""><i class=""fa fa-angle-right mr-2""></i>Home</a>
                            <a class=""text-dark mb-2"" href=""shop.html""><i class=""fa fa-angle-right mr-2""></i>Our Shop</a>
                            <a class=""text-dark mb-2"" href=""detail.html""><i class=""fa fa-angle-right mr-2""></i>Shop Detail</a>
                            <a class=""text-dark mb-2"" href=""cart.html""><i class=""fa fa-angle-right mr-2""></i>Shopping Cart</a>
                            <a class=""text-dark mb-2"" href=""checkout.html""><i class=""fa fa-angle-right mr-2""></i>Checkout</a>
                            <a class=""text-dark"" href=""contact.html""><i class=""fa fa-angle-right mr-2""></i>Contact Us</a>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4"">Newsletter</h5>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a28f275ee4fe8ae90c54d4c6bea7537fa011ef23490", async() => {
                    WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control border-0 py-4"" placeholder=""Your Name"" required=""required"" />
                            </div>
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control border-0 py-4"" placeholder=""Your Email""
                                       required=""required"" />
                            </div>
                            <div>
                                <button class=""btn btn-primary btn-block border-0 py-3"" type=""submit"">Subscribe Now</button>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""row border-top border-light mx-xl-5 py-4"">
            <div class=""col-md-6 px-xl-0"">
                <p class=""mb-md-0 text-center text-md-left text-dark"">
                    &copy; <a class=""text-dark font-weight-semi-bold"" href=""#"">Your Site Name</a>. All Rights Reserved. Designed
                    by
                    <a class=""text-dark font-weight-semi-bold"" href=""https://htmlcodex.com"">HTML Codex</a>
                </p>
            </div>
            <div class=""col-md-6 px-xl-0 text-center text-md-right"">
                <img class=""img-fluid"" src=""img/payments.png""");
                BeginWriteAttribute("alt", " alt=\"", 13848, "\"", 13854, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>
        </div>
    </div>
    <!-- Footer End -->
    <!-- Back to Top -->
    <a href=""#"" class=""btn btn-primary back-to-top""><i class=""fa fa-angle-double-up""></i></a>


    <!-- JavaScript Libraries -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js""></script>
    <script src=""/lib/easing/easing.min.js""></script>
    <script src=""/lib/owlcarousel/owl.carousel.min.js""></script>

    <!-- Contact Javascript File -->
    <script src=""/mail/jqBootstrapValidation.min.js""></script>
    <script src=""/mail/contact.js""></script>

    <!-- Template Javascript -->
    <script src=""/js/main.js""></script>
    ");
#nullable restore
#line 261 "C:\Users\Minh Nhat\Desktop\AdvancedEShop\AdvancedEShop\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
