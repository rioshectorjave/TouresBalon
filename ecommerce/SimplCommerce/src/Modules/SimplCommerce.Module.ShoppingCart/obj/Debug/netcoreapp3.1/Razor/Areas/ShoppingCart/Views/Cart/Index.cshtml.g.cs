#pragma checksum "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045d951154949b62f8cbe40b5a27d53767a9468d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ShoppingCart_Views_Cart_Index), @"mvc.1.0.view", @"/Areas/ShoppingCart/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045d951154949b62f8cbe40b5a27d53767a9468d", @"/Areas/ShoppingCart/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252a5853f5646565b6d19f2f67b215e8a2ab4af3", @"/Areas/ShoppingCart/Views/_ViewImports.cshtml")]
    public class Areas_ShoppingCart_Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/checkout/shipping"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-class", new global::Microsoft.AspNetCore.Html.HtmlString("{disabled: !vm.cart.isValid}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_content/SimplCommerce.Module.ShoppingCart/shoppingcart-list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_content/SimplCommerce.Module.ShoppingCart/shoppingcart-service.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = Localizer["Shopping Cart"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row cart-list"" ng-app=""simpl.shoppingCart"" ng-controller=""shoppingCartListCtrl as vm"" ng-cloak>
    <div class=""col-md-8"">
        <table class=""table table-striped cart-items"">
            <thead>
                <tr>
                    <th colspan=""2"">");
#nullable restore
#line 10 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                               Write(Localizer["Product"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"text-right\">");
#nullable restore
#line 11 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                      Write(Localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"text-center\">");
#nullable restore
#line 12 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                       Write(Localizer["Quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr ng-if=""vm.cart.items.length"" ng-repeat=""cartItem in vm.cart.items"">
                    <td class=""product-image""><img ng-src=""{{cartItem.productImage}}"" /></td>
                    <td>
                        <h6>{{cartItem.productName}}</h6>
                        <ul class=""list-unstyled"">
                            <li ng-repeat=""opt in cartItem.variationOptions"">
                                <span>{{opt.optionName}}:</span> {{opt.value}}
                            </li>
                        </ul>
                        <span ng-if=""!cartItem.isProductAvailabeToOrder"" class=""badge badge-pill badge-danger"">");
#nullable restore
#line 26 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                                                                                          Write(Localizer["Not availabe any more"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span ng-if=\"cartItem.productStockTrackingIsEnabled && cartItem.productStockQuantity < cartItem.quantity\" class=\"badge badge-pill badge-danger\">");
#nullable restore
#line 27 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                                                                                                                                                   Write(Localizer["Not enough stock. Available:"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" {{cartItem.productStockQuantity}}</span>
                    </td>
                    <td class=""text-right"">{{cartItem.productPriceString}}</td>
                    <td class=""text-center"">
                        <button type=""button"" class=""quantity-button"" ng-click=""vm.decreaseQuantity(cartItem)"" name=""subtract"" value=""-"">-</button>
                        <input type=""text"" class=""quantity-field"" ng-model=""cartItem.quantity"" readonly=""readonly"" />
                        <button type=""button"" class=""quantity-button"" ng-click=""vm.increaseQuantity(cartItem)"" name=""subtract"" value=""+"">+</button>
                    </td>
                    <td class=""text-right""><button class=""btn btn-link"" ng-click=""vm.removeShoppingCartItem(cartItem)""><span class=""fa fa-remove"" aria-hidden=""true""></span></button></td>
                </tr>
                <tr ng-if=""!vm.cart.items.length"">
                    <td colspan=""5"" class=""text-center"">
                        ");
#nullable restore
#line 39 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                   Write(Localizer["There are no items in this cart."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045d951154949b62f8cbe40b5a27d53767a9468d11327", async() => {
#nullable restore
#line 39 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                                                               Write(Localizer["Go to shopping"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n        <div class=\"order-note-form\">\r\n            <h4>");
#nullable restore
#line 45 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
           Write(Localizer["Order note"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045d951154949b62f8cbe40b5a27d53767a9468d13187", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <textarea rows=\"3\" class=\"form-control\" name=\"orderNote\" ng-model=\"vm.cart.orderNote\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2935, "\"", 2979, 1);
#nullable restore
#line 48 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2949, Localizer["Enter order note"], 2949, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"btn btn-default pull-right\" ng-click=\"vm.saveOrderNote()\">");
#nullable restore
#line 51 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                                                                                      Write(Localizer["Save order note"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <div class=\"order-summary\" ng-if=\"vm.cart.items.length\">\r\n            <h4>");
#nullable restore
#line 58 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
           Write(Localizer["Order summary"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                   Write(Localizer["Subtotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>{{vm.cart.subTotalString}}</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                   Write(Localizer["Discount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" {{vm.cart.couponCode}}</td>\r\n                    <td>{{vm.cart.discountString}}</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                   Write(Localizer["Order Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>{{vm.cart.orderTotalString}}</strong></td>\r\n                </tr>\r\n            </table>\r\n            <p class=\"text-right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045d951154949b62f8cbe40b5a27d53767a9468d17668", async() => {
#nullable restore
#line 73 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                                                                                                           Write(Localizer["Process to Checkout"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n            <p ng-if=\"vm.cart.lockedOnCheckout\"><button type=\"button\" ng-click=\"vm.unlock()\" class=\"btn btn-secondary active\">");
#nullable restore
#line 74 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                                                                                                         Write(Localizer["Unlock cart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></p>\r\n        </div>\r\n        <div class=\"coupon-form\" ng-if=\"vm.cart.items.length\">\r\n            <h4>");
#nullable restore
#line 77 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
           Write(Localizer["Coupon code"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045d951154949b62f8cbe40b5a27d53767a9468d20260", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label>{{vm.cart.couponValidationErrorMessage}}</label>
                </div>
                <div class=""form-group"">
                    <input type=""text"" class=""form-control"" name=""couponCode"" ng-model=""vm.couponCode""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4783, "\"", 4823, 1);
#nullable restore
#line 83 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 4797, Localizer["Enter coupon"], 4797, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <button type=\"submit\" class=\"btn btn-default\" ng-click=\"vm.applyCoupon()\">");
#nullable restore
#line 84 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
                                                                                         Write(Localizer["Apply"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045d951154949b62f8cbe40b5a27d53767a9468d23020", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper = CreateTagHelper<global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper>();
                __tagHelperExecutionContext.Add(__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper);
#nullable restore
#line 92 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("simpl-append-version", __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045d951154949b62f8cbe40b5a27d53767a9468d25023", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper = CreateTagHelper<global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper>();
                __tagHelperExecutionContext.Add(__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper);
#nullable restore
#line 93 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\Index.cshtml"
__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("simpl-append-version", __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
