#pragma checksum "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f8cbbbcf6993f2679ee22fc82da3b1931b76b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskImportance_Create), @"mvc.1.0.view", @"/Views/TaskImportance/Create.cshtml")]
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
#line 1 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Create.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f8cbbbcf6993f2679ee22fc82da3b1931b76b4", @"/Views/TaskImportance/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskImportance_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskImportance>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h3 class=\"mb-0\">Görevlere Önem Seviyesi Ekleme</h3>\r\n</div>\r\n");
#nullable restore
#line 7 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Create.cshtml"
 using (Html.BeginForm("Create", "TaskImportance", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Create.cshtml"
Write(Html.Label("Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Create.cshtml"
Write(Html.TextBoxFor(ba => ba.TaskImportanceName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Create.cshtml"
Write(Html.ValidationMessageFor(ba => ba.TaskImportanceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 16 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\TaskImportance\Create.cshtml"
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
