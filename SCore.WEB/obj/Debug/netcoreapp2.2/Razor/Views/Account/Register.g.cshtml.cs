#pragma checksum "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a66d5abb2e7e5f630e92361cc99ace1aafafca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08a66d5abb2e7e5f630e92361cc99ace1aafafca", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c717140983b193c4db6fad861448ff2e71ba0066", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCore.Models.Models.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
  
    ViewBag.Title = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 23, true);
            WriteLiteral("\r\n<h2>Register</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(193, 23, false);
#line 12 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(220, 71, true);
            WriteLiteral("    <div>\r\n        <h4>Register new user</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(292, 29, false);
#line 17 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
   Write(Html.ValidationSummary(false));

#line default
#line hidden
            EndContext();
            BeginContext(321, 72, true);
            WriteLiteral("\r\n\r\n        <div>\r\n            Name\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(394, 35, false);
#line 22 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(429, 111, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div>\r\n            Surname\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(541, 39, false);
#line 29 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(580, 109, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div>\r\n            Email\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(690, 36, false);
#line 36 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(726, 114, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div>\r\n            Password\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(841, 39, false);
#line 44 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(880, 120, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div>\r\n            Confirm password\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1001, 46, false);
#line 51 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => model.PasswordConfirm));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 180, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div>\r\n            <div>\r\n                <input type=\"submit\" value=\"Register\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 61 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Account\Register.cshtml"
}

#line default
#line hidden
            BeginContext(1230, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCore.Models.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
