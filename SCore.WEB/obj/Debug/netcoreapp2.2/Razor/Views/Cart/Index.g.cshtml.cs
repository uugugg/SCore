#pragma checksum "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53080c0a82a8a8fca3766c081dc51c6dc0398ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53080c0a82a8a8fca3766c081dc51c6dc0398ec8", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c717140983b193c4db6fad861448ff2e71ba0066", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCore.WEB.ViewModels.CartIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 226, true);
            WriteLiteral("\r\n<h4>Cart</h4>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Quantity</th>\r\n            <th>Item</th>\r\n            <th>Price</th>\r\n            <th>Subtotal</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
            BeginContext(375, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(414, 11, false);
#line 20 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
               Write(line.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(425, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(453, 17, false);
#line 21 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
               Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(470, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(498, 32, false);
#line 22 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
               Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(530, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(559, 48, false);
#line 23 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
                Write((line.Amount * line.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(608, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(636, 87, false);
#line 24 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
               Write(Html.ActionLink("Remove", "RemoveFromCart", new { productId = line.Product.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(723, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(760, 65, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            Total sum:  ");
            EndContext();
            BeginContext(826, 37, false);
#line 30 "C:\Users\User\source\repos\SCore\SCore.WEB\Views\Cart\Index.cshtml"
                   Write(Model.Cart.Totalvalue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(863, 43, true);
            WriteLiteral("\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(906, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53080c0a82a8a8fca3766c081dc51c6dc0398ec87404", async() => {
                BeginContext(987, 16, true);
                WriteLiteral("\r\n    Checkout\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCore.WEB.ViewModels.CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
