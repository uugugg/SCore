#pragma checksum "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e71d3c1bd03763269782ab248f57e28fcf49ed7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e71d3c1bd03763269782ab248f57e28fcf49ed7a", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c717140983b193c4db6fad861448ff2e71ba0066", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCore.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(66, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(232, 40, false);
#line 15 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(272, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 36, false);
#line 19 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(354, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(400, 44, false);
#line 23 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(444, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(490, 40, false);
#line 27 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(530, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(576, 41, false);
#line 31 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(617, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(663, 37, false);
#line 35 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(700, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(746, 50, false);
#line 39 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfRegister));

#line default
#line hidden
            EndContext();
            BeginContext(796, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(842, 46, false);
#line 43 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateOfRegister));

#line default
#line hidden
            EndContext();
            BeginContext(888, 32, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
            EndContext();
#line 48 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
     using (Html.BeginForm())
    {
        // @Html.AntiForgeryToken()


#line default
#line hidden
            BeginContext(997, 135, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(1133, 40, false);
#line 54 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 56 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Users\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1198, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCore.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
