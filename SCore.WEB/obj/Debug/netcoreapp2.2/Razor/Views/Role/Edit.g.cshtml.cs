#pragma checksum "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73cbc748f427b5af508bf420b2680e67abf63553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Edit), @"mvc.1.0.view", @"/Views/Role/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Edit.cshtml", typeof(AspNetCore.Views_Role_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73cbc748f427b5af508bf420b2680e67abf63553", @"/Views/Role/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c717140983b193c4db6fad861448ff2e71ba0066", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCore.WEB.ViewModels.RoleViewModelEdit>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(49, 24, true);
            WriteLiteral("\r\n<h4>Edit role</h4>\r\n\r\n");
            EndContext();
#line 6 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(108, 23, false);
#line 8 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(135, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(155, 32, false);
#line 11 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Edit.cshtml"
   Write(Html.ValidationSummary(true, ""));

#line default
#line hidden
            EndContext();
            BeginContext(187, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(198, 33, false);
#line 12 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(231, 24, true);
            WriteLiteral("\r\n        <p>Название:  ");
            EndContext();
            BeginContext(256, 35, false);
#line 13 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Edit.cshtml"
                 Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(291, 71, true);
            WriteLiteral("</p>\r\n        <p><input type=\"submit\" value=\"Edit\" /></p>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Role\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCore.WEB.ViewModels.RoleViewModelEdit> Html { get; private set; }
    }
}
#pragma warning restore 1591
