#pragma checksum "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f145fbb30beacba8910ec22c29a3331272187af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Create), @"mvc.1.0.view", @"/Views/Role/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Create.cshtml", typeof(AspNetCore.Views_Role_Create))]
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
#line 1 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\_ViewImports.cshtml"
using SCore.WEB;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\_ViewImports.cshtml"
using SCore.Models.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f145fbb30beacba8910ec22c29a3331272187af4", @"/Views/Role/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c717140983b193c4db6fad861448ff2e71ba0066", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCore.WEB.ViewModels.RoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 27, true);
            WriteLiteral("\r\n<h2>Add new role</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(105, 23, false);
#line 7 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(132, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(152, 32, false);
#line 10 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Create.cshtml"
   Write(Html.ValidationSummary(true, ""));

#line default
#line hidden
            EndContext();
            BeginContext(184, 24, true);
            WriteLiteral("\r\n        <p>Название:  ");
            EndContext();
            BeginContext(209, 35, false);
#line 11 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Create.cshtml"
                 Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(244, 70, true);
            WriteLiteral("</p>\r\n        <p><input type=\"submit\" value=\"Add\" /></p>\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCore.WEB.ViewModels.RoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
