#pragma checksum "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a8a080419371440fa298b365d467f681607f2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MonthlySpecials_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MonthlySpecials/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MonthlySpecials_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a8a080419371440fa298b365d467f681607f2e", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
    public class Views_Shared_Components_MonthlySpecials_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExploreCalifornia.Models.MonthlySpecial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 31, true);
            WriteLiteral("\r\n<h1>Monthly Specials</h1>\r\n\r\n");
            EndContext();
#line 5 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
 foreach (var special in Model)
{

#line default
#line hidden
            BeginContext(128, 34, true);
            WriteLiteral("    <h2 class=\"top\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 162, "\"", 198, 3);
            WriteAttributeValue("", 168, "/images/", 168, 8, true);
#line 8 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 176, special.Key, 176, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 190, "_bug.gif", 190, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 199, "\"", 218, 1);
#line 8 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 205, special.Name, 205, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(219, 34, true);
            WriteLiteral(" width=\"75\" height=\"75\">\r\n        ");
            EndContext();
            BeginContext(254, 12, false);
#line 9 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
   Write(special.Name);

#line default
#line hidden
            EndContext();
            BeginContext(266, 30, true);
            WriteLiteral("\r\n    </h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(297, 12, false);
#line 12 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
   Write(special.Type);

#line default
#line hidden
            EndContext();
            BeginContext(309, 17, true);
            WriteLiteral(" <br>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 326, "\"", 358, 3);
            WriteAttributeValue("", 333, "/tours/", 333, 7, true);
#line 13 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 340, special.Key, 340, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 354, ".htm", 354, 4, true);
            EndWriteAttribute();
            BeginContext(359, 2, true);
            WriteLiteral(">$");
            EndContext();
            BeginContext(362, 13, false);
#line 13 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
                                        Write(special.Price);

#line default
#line hidden
            EndContext();
            BeginContext(375, 16, true);
            WriteLiteral("</a>\r\n    </p>\r\n");
            EndContext();
#line 15 "C:\App funcionando\Ex_Files_ASPNET_CoreMVC_Upd\Ex_Files_ASPNET_CoreMVC_Upd\Exercise Files\Ch06\06_04_End\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExploreCalifornia.Models.MonthlySpecial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
