#pragma checksum "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "349333f9bd342726aadb4fa835098daec5f8cc07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Orders_Views_Shared_InvoicePdf), @"mvc.1.0.view", @"/Areas/Orders/Views/Shared/InvoicePdf.cshtml")]
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
#line 1 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"349333f9bd342726aadb4fa835098daec5f8cc07", @"/Areas/Orders/Views/Shared/InvoicePdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf3e0405f4495e5df7ddc371fbf1bfd277f4556", @"/Areas/Orders/Views/_ViewImports.cshtml")]
    public class Areas_Orders_Views_Shared_InvoicePdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Orders.Areas.Orders.ViewModels.OrderDetailVm>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "349333f9bd342726aadb4fa835098daec5f8cc074149", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Invoice - SimplCommerce</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" integrity=""sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB"" crossorigin=""anonymous"">
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "349333f9bd342726aadb4fa835098daec5f8cc075511", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-6 text-center"">
                <h2>SimplCommerce</h2>
                <p>Address: 364 Cong Hoa, Tan Binh, HCMC, Vietnam</p>
                <p>Phone: 000000000</p>
                <hr />
            </div>
            <div class=""col""></div>
        </div>
        <div class=""row mt-4"">
            <div class=""col text-center"">
                <h2>INVOICE</h2>
                <p>Date: ");
#nullable restore
#line 29 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                    Write(Model.CreatedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <p>Customer: ");
#nullable restore
#line 34 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                        Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>\r\n                    Address: ");
#nullable restore
#line 36 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                        Write(Model.ShippingAddress.AddressLine1);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 36 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                             Write(Model.ShippingAddress.DistrictName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 36 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                                                                 Write(Model.ShippingAddress.StateOrProvinceName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </p>
            </div>
        </div>
        <div class=""row mt-4"">
            <div class=""col"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>Product</th>
                            <th class=""text-right"">Quantity</th>
                            <th class=""text-right"">Price</th>
                            <th class=""text-right"">Amount</th>
                            <th class=""text-right"">VAT rate</th>
                            <th class=""text-right"">VAT Included Amount</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 54 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                         foreach (var item in Model.OrderItems)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                     foreach (var opt in item.VariationOptions)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span>");
#nullable restore
#line 61 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                         Write(opt.OptionName);

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 61 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                          Write(opt.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </td>\r\n                                <td class=\"text-right\">");
#nullable restore
#line 64 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                  Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
#nullable restore
#line 65 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                  Write(item.ProductPriceString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
#nullable restore
#line 66 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                  Write(item.TotalString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
#nullable restore
#line 67 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                  Write(item.TaxPercent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
#nullable restore
#line 68 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                  Write(item.TaxIncludedAmountString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class=""row justify-content-end"">
            <div class=""col-6"" style=""float:right"">
                <table class=""table"">
                    <tr>
                        <td>Subtotal</td>
                        <td class=""text-right"">");
#nullable restore
#line 80 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                          Write(Model.SubtotalString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Shipping</td>\r\n                        <td class=\"text-right\">");
#nullable restore
#line 84 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                          Write(Model.ShippingAmountString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tax</td>\r\n                        <td class=\"text-right\">");
#nullable restore
#line 88 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                          Write(Model.TaxAmountString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Discount</td>\r\n                        <td class=\"text-right\">");
#nullable restore
#line 92 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                          Write(Model.DiscountAmountString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Payment Fee</td>\r\n                        <td class=\"text-right\">");
#nullable restore
#line 96 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                          Write(Model.PaymentFeeAmountString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Order Total</td>\r\n                        <td class=\"text-right\"><strong>");
#nullable restore
#line 100 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\InvoicePdf.cshtml"
                                                  Write(Model.OrderTotalString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Orders.Areas.Orders.ViewModels.OrderDetailVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
