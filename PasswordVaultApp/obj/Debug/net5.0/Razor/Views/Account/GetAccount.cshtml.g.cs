#pragma checksum "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ad8ee59a49c7f991f7af8706be4f70721ffb15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetAccount), @"mvc.1.0.view", @"/Views/Account/GetAccount.cshtml")]
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
#line 1 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\_ViewImports.cshtml"
using PasswordVaultApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\_ViewImports.cshtml"
using PasswordVaultApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ad8ee59a49c7f991f7af8706be4f70721ffb15", @"/Views/Account/GetAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b729101a3a3c5e91fb2d85a3c13f18d95b0f01d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GetAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Account>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
  
    //ViewBag.Title = "GetAccount";
    //Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ad8ee59a49c7f991f7af8706be4f70721ffb153617", async() => {
                WriteLiteral(@"
    <title>Bootstrap Example</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ad8ee59a49c7f991f7af8706be4f70721ffb155033", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <h2>Update Account</h2><br/>\r\n");
#nullable restore
#line 21 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
         using (Html.BeginForm("UpdateAccount", "Account", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.LabelFor(m => m.AccountId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.TextBoxFor(m => m.AccountId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.LabelFor(m => m.SiteId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 29 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.DropDownListFor(m => m.SiteId, (List<SelectListItem>)ViewBag.dgr, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 32 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.LabelFor(m => m.SiteUserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.TextBoxFor(m => m.SiteUserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 36 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.LabelFor(m => m.SitePassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
           Write(Html.TextBoxFor(m => m.SitePassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default\" onclick=\"window.location.href = \" ");
#nullable restore
#line 39 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
                                                                                       Write(Url.Action("AccountList", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \";\">Update</button>\r\n");
#nullable restore
#line 40 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\GetAccount.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
