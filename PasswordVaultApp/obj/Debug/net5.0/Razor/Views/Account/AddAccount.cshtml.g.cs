#pragma checksum "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AddAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ee3f32f31d14eb57802da68a5af38fa89ff0ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AddAccount), @"mvc.1.0.view", @"/Views/Account/AddAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee3f32f31d14eb57802da68a5af38fa89ff0ba7", @"/Views/Account/AddAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b729101a3a3c5e91fb2d85a3c13f18d95b0f01d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AddAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PasswordVaultApp.Models.Account>
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee3f32f31d14eb57802da68a5af38fa89ff0ba73353", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee3f32f31d14eb57802da68a5af38fa89ff0ba74769", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <br />\r\n        <h2>Add Account</h2><br />\r\n");
#nullable restore
#line 23 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AddAccount.cshtml"
         using (Html.BeginForm("AddAccount", "Account", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AddAccount.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"siteName\">\r\n                    Select Site\r\n                </label>\r\n                ");
#nullable restore
#line 30 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AddAccount.cshtml"
           Write(Html.DropDownListFor(m=>m.SiteId, (List<SelectListItem>)ViewBag.dgr, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <label for=""userName"">User Name</label>
                <input type=""userName"" class=""form-control"" id=""siteUserName"" placeholder=""User Name"" name=""siteUserName"" required>
            </div>
            <div class=""form-group"">
                <label for=""pwd"">Password</label>
                <input type=""password"" class=""form-control"" id=""pwd"" placeholder=""Enter password"" name=""sitePassword"" required>

            </div>
            <button type=""submit"" class=""btn btn-default"" onclick=""window.location.href = "" ");
#nullable restore
#line 41 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AddAccount.cshtml"
                                                                                       Write(Url.Action("AccountList", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \";\">Add</button><br /><br /><br />\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1834, "\"", 1877, 1);
#nullable restore
#line 42 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AddAccount.cshtml"
WriteAttributeValue("", 1841, Url.Action("AccountList","Account"), 1841, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><input class=\"navbar-brand\" type=\"button\" value=\"Go to Account List\" /></a>\r\n");
#nullable restore
#line 43 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AddAccount.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PasswordVaultApp.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591