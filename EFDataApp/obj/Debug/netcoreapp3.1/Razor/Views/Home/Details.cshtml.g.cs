#pragma checksum "C:\Users\Админ\source\repos\EFDataApp\EFDataApp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15243f1b787d400702df1b63b0a640f7dcc1b20e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Админ\source\repos\EFDataApp\EFDataApp\Views\_ViewImports.cshtml"
using EFDataApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Админ\source\repos\EFDataApp\EFDataApp\Views\_ViewImports.cshtml"
using EFDataApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15243f1b787d400702df1b63b0a640f7dcc1b20e", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12699403ff1bbf2c3074e62ee7a1098dff966eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFDataApp.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Админ\source\repos\EFDataApp\EFDataApp\Views\Home\Details.cshtml"
   
    ViewBag.Title = Model.Name;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Пользователь ");
#nullable restore
#line 5 "C:\Users\Админ\source\repos\EFDataApp\EFDataApp\Views\Home\Details.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    <dl class=\"dl-horisontal\">\r\n        <dt>Итендификатор</dt>\r\n        <dd>");
#nullable restore
#line 9 "C:\Users\Админ\source\repos\EFDataApp\EFDataApp\Views\Home\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Возраст</dt>\r\n        <dd>");
#nullable restore
#line 12 "C:\Users\Админ\source\repos\EFDataApp\EFDataApp\Views\Home\Details.cshtml"
       Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFDataApp.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
