#pragma checksum "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Shared\Components\MonthList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9153c8997a3fc6b25200abfe695f02443236e002"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MonthList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MonthList/Default.cshtml")]
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
#line 1 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\_ViewImports.cshtml"
using TaskManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\_ViewImports.cshtml"
using TaskManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Shared\Components\MonthList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9153c8997a3fc6b25200abfe695f02443236e002", @"/Views/Shared/Components/MonthList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MonthList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Month>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>Ay</th>\r\n            <th>Görev</th>\r\n            <th>Durumu</th>\r\n\r\n\r\n\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Shared\Components\MonthList\Default.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Shared\Components\MonthList\Default.cshtml"
               Write(item.MonthTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Shared\Components\MonthList\Default.cshtml"
               Write(item.MonthTaskContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Shared\Components\MonthList\Default.cshtml"
               Write(item.TaskStatuse.TaskStatuseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Shared\Components\MonthList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Month>> Html { get; private set; }
    }
}
#pragma warning restore 1591
