#pragma checksum "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\Shared\404.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3fea8cb5262cb2ef594a867933d75dacf8f737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_404), @"mvc.1.0.view", @"/Views/Shared/404.cshtml")]
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
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3fea8cb5262cb2ef594a867933d75dacf8f737", @"/Views/Shared/404.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525c98e165cc60eff7b765acffca119c77f1bb93", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_404 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\Shared\404.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
#nullable restore
#line 5 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\Shared\404.cshtml"
                   Write(Localizer["We are sorry!"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2 class=\"text-danger\">");
#nullable restore
#line 6 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\Shared\404.cshtml"
                   Write(Localizer["The page you have requested cannot be found"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>");
#nullable restore
#line 7 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\Shared\404.cshtml"
Write(Localizer["Maybe the page was moved or deleted, or perhaps you just mistyped the address."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 8 "C:\Users\hecto\source\repos\SimplCommerce\src\SimplCommerce.WebHost\Views\Shared\404.cshtml"
Write(Localizer["Why not try and find your way using the navigation bar above or click on the logo to return our home page."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
