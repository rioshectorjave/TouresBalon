#pragma checksum "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\EmailTemplate\AccountRegisteredConfirmationEmailModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e77cf1948276b86d572320752c4bcd02af39a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Core_Views_EmailTemplate_AccountRegisteredConfirmationEmailModel), @"mvc.1.0.view", @"/Areas/Core/Views/EmailTemplate/AccountRegisteredConfirmationEmailModel.cshtml")]
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
#line 1 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e77cf1948276b86d572320752c4bcd02af39a6a", @"/Areas/Core/Views/EmailTemplate/AccountRegisteredConfirmationEmailModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ae4a4c81275951e35f765ffa4071b0e7b3dc51", @"/Areas/Core/Views/_ViewImports.cshtml")]
    public class Areas_Core_Views_EmailTemplate_AccountRegisteredConfirmationEmailModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Core.Areas.Core.ViewModels.Account.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\EmailTemplate\AccountRegisteredConfirmationEmailModel.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""background:#ffffff;width:100%"">
    <tbody>
        <tr>
            <td align=""center"" valign=""top"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""width:800px;border-top:1px #cccccc"">
                    <tbody>
                        <tr>
                            <td align=""left"" style=""font-family:Arial,Helvetica,sans-serif;font-size:12px;color:#333333;background:#fff"" valign=""top"">
                                <h2>");
#nullable restore
#line 15 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\EmailTemplate\AccountRegisteredConfirmationEmailModel.cshtml"
                               Write(Localizer["Thank you for registering at simplcommerce.com."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>\r\n                                <p>");
#nullable restore
#line 20 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\EmailTemplate\AccountRegisteredConfirmationEmailModel.cshtml"
                              Write(Localizer["Please confirm your account by clicking this"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\'", 895, "\'", 920, 1);
#nullable restore
#line 20 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\EmailTemplate\AccountRegisteredConfirmationEmailModel.cshtml"
WriteAttributeValue("", 902, Model.CallbackUrl, 902, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Usuario\PICA\TouresBalon\ecommerce\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\EmailTemplate\AccountRegisteredConfirmationEmailModel.cshtml"
                                                                                                                      Write(Localizer["link"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</p><br />\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Core.Areas.Core.ViewModels.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
