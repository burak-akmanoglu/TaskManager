#pragma checksum "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3279d2373b1a98d17a9ab83fc8f7e6f5a82cf248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskImportance_Details), @"mvc.1.0.view", @"/Views/TaskImportance/Details.cshtml")]
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
#line 1 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Details.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3279d2373b1a98d17a9ab83fc8f7e6f5a82cf248", @"/Views/TaskImportance/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskImportance_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskImportance>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Servis Düzenleme Tablosu</h3>\r\n</div>\r\n");
#nullable restore
#line 7 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Details.cshtml"
 using (Html.BeginForm("Edit", "TaskImportance", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Details.cshtml"
Write(Html.HiddenFor(ba => ba.TaskImportanceID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 11 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Details.cshtml"
Write(Html.Label("Ad"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Details.cshtml"
Write(Html.TextBoxFor(ba => ba.TaskImportanceName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-success\">Kaydet</button>\r\n");
#nullable restore
#line 15 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Details.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskImportance> Html { get; private set; }
    }
}
#pragma warning restore 1591