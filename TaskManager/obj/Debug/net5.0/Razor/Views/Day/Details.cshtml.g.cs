#pragma checksum "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb800fb620f89fc3d37d6027ecf8f364ae99551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Day_Details), @"mvc.1.0.view", @"/Views/Day/Details.cshtml")]
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
#line 1 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb800fb620f89fc3d37d6027ecf8f364ae99551", @"/Views/Day/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Day_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Day>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Günlük Görev Düzenleme</h3>\r\n</div>\r\n");
#nullable restore
#line 7 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
 using (Html.BeginForm("Edit", "Day", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.HiddenFor(ba => ba.DayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 11 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.Label("Gün"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.TextBoxFor(ba => ba.DayTime, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.ValidationMessageFor(ba => ba.DayTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.Label("İçerik"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.TextBoxFor(ba => ba.DayTaskContent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.ValidationMessageFor(ba => ba.DayTaskContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.Label("Kullanıcı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.DropDownListFor(ba => ba.UserID, (List<SelectListItem>)ViewBag.Us, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.Label("Önem"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.DropDownListFor(ba => ba.TaskImportanceID, (List<SelectListItem>)ViewBag.tm, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.Label("Durum"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
Write(Html.DropDownListFor(ba => ba.TaskStatuseID, (List<SelectListItem>)ViewBag.ts, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-success\">Kaydet</button>\r\n");
#nullable restore
#line 32 "C:\Users\Burak Akmanoğlu\source\repos\TaskManager\TaskManager\Views\Day\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Day> Html { get; private set; }
    }
}
#pragma warning restore 1591
