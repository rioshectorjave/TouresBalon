#pragma checksum "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e170eeed9f2b7960242cce4c592c2ca73e29ca74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cms_Views_Shared_Components_CarouselWidget_Default), @"mvc.1.0.view", @"/Areas/Cms/Views/Shared/Components/CarouselWidget/Default.cshtml")]
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
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e170eeed9f2b7960242cce4c592c2ca73e29ca74", @"/Areas/Cms/Views/Shared/Components/CarouselWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b78f39d77f59319d109ccd8a079aed7a26e54b", @"/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Areas_Cms_Views_Shared_Components_CarouselWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.CarouselWidgetViewComponentVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("id", " id=\"", 90, "\"", 114, 2);
            WriteAttributeValue("", 95, "carousel", 95, 8, true);
#nullable restore
#line 3 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 103, Model.Id, 103, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"");
#nullable restore
#line 3 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                                    Write(Model.DataInterval);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 5 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
         for (int i = 0; i < Model.Items.Count; i++)
        {
            if (i == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carousel");
#nullable restore
#line 9 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"0\" class=\"active\"></li>\r\n");
#nullable restore
#line 10 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carousel");
#nullable restore
#line 13 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 13 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 14 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 18 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 695, "\"", 765, 2);
            WriteAttributeValue("", 703, "carousel-item", 703, 13, true);
#nullable restore
#line 20 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue(" ", 716, item == Model.Items.First() ? "active" : null, 717, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 783, "\"", 805, 1);
#nullable restore
#line 21 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 790, item.TargetUrl, 790, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 829, "\"", 846, 1);
#nullable restore
#line 22 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 835, item.Image, 835, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 847, "\"", 866, 1);
#nullable restore
#line 22 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 853, item.Caption, 853, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n                <div class=\"carousel-caption d-none d-md-block\" role=\"option\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 25 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                   Write(item.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <a class=\"carousel-control-prev\"");
            BeginWriteAttribute("href", " href=\"", 1173, "\"", 1200, 2);
            WriteAttributeValue("", 1180, "#carousel", 1180, 9, true);
#nullable restore
#line 32 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 1189, Model.Id, 1189, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\r\n        <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n        <span class=\"sr-only\">Previous</span>\r\n    </a>\r\n    <a class=\"carousel-control-next\"");
            BeginWriteAttribute("href", " href=\"", 1406, "\"", 1433, 2);
            WriteAttributeValue("", 1413, "#carousel", 1413, 9, true);
#nullable restore
#line 36 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 1422, Model.Id, 1422, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"next\">\r\n        <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n        <span class=\"sr-only\">Next</span>\r\n    </a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.CarouselWidgetViewComponentVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
