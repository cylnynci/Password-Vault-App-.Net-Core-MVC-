#pragma checksum "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e5861b449b1ec76ad893809ef858d1a7433bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccountList), @"mvc.1.0.view", @"/Views/Account/AccountList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e5861b449b1ec76ad893809ef858d1a7433bf9", @"/Views/Account/AccountList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b729101a3a3c5e91fb2d85a3c13f18d95b0f01d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccountList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Account>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/colorlib-regform-7/vendor/jquery/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/packages/selenium.webdriver/4.2.0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/packages/selenium.webdriver.chromedriver/102.0.5005.6102"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
  

//Layout = "~/Views/Shared/_UILayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e5861b449b1ec76ad893809ef858d1a7433bf94915", async() => {
                WriteLiteral(@"
    <title>Bootstrap Example</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/2.2.6/semantic.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e5861b449b1ec76ad893809ef858d1a7433bf95739", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e5861b449b1ec76ad893809ef858d1a7433bf96838", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e5861b449b1ec76ad893809ef858d1a7433bf97937", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e5861b449b1ec76ad893809ef858d1a7433bf99740", async() => {
                WriteLiteral("\r\n\r\n    <td class=\"container\">\r\n");
#nullable restore
#line 25 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
         using (Html.BeginForm("AccountList", "Account", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h2>\r\n                Accounts and Details\r\n            </h2>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1154, "\"", 1197, 1);
#nullable restore
#line 30 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 1161, Url.Action("AddAccount", "Account"), 1161, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><input class=""navbar-brand"" type=""button"" value=""Add Account"" /></a>
            <table class=""table table-hover"">
                <thead>

                    <tr>
                        <th>Site Name</th>
                        <th>User Name</th>
                        <th>Password</th>
                        <th>Delete</th>
                        <th>Update</th>
                        <th>Go</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 44 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
                     foreach (var account in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
                       Write(account.Site.SiteName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
                       Write(account.SiteUserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td> <input type=\"password\"");
                BeginWriteAttribute("id", " id=\"", 1963, "\"", 1986, 1);
#nullable restore
#line 49 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 1968, account.AccountId, 1968, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1987, "\"", 2012, 1);
#nullable restore
#line 49 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 1994, account.AccountId, 1994, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2013, "\"", 2042, 1);
#nullable restore
#line 49 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2021, account.SitePassword, 2021, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"circular eye link icon\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2077, "\"", 2123, 3);
                WriteAttributeValue("", 2087, "HideShowPassword(", 2087, 17, true);
#nullable restore
#line 49 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2104, account.AccountId, 2104, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2122, ")", 2122, 1, true);
                EndWriteAttribute();
                WriteLiteral("></i></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2166, "\"", 2241, 3);
#nullable restore
#line 50 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2173, Url.Action("DeleteAccount", "Account"), 2173, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2212, "?AccountId=", 2212, 11, true);
#nullable restore
#line 50 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2223, account.AccountId, 2223, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2313, "\"", 2385, 3);
#nullable restore
#line 51 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2320, Url.Action("GetAccount", "Account"), 2320, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2356, "?AccountId=", 2356, 11, true);
#nullable restore
#line 51 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2367, account.AccountId, 2367, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2458, "\"", 2557, 3);
#nullable restore
#line 52 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2465, Url.Action("GetSessionInformation", "Account",FormMethod.Post), 2465, 63, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2528, "?AccountId=", 2528, 11, true);
#nullable restore
#line 52 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
WriteAttributeValue("", 2539, account.AccountId, 2539, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Go To The Site</a></td>\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 71 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Account\AccountList.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n");
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
            WriteLiteral(@"
<script>
    function HideShowPassword(id) {
        var element = document.getElementById(id);
        element.type = (element.type == 'password' ? 'text' : 'password');
    }
            //function GetSessionInformation(id) {
            //  var m = document.getElementById(id);
            //  <div class=""input-container touched pristine required""><input id=""emailOrPhone"" tabindex=""1"" autofocus=""autofocus"" type=""text"" name=""emailOrPhone"" class=""form-input touched pristine required"">Html.TextBoxFor(m => m.SiteUserName, new {class = ""form-control""})</div>
            //  <div class=""input-container""><input tabindex=""2"" name=""password"" id=""password"" type=""password"" class=""form-input touched pristine required""> <!----> <button type=""button"" class=""btn-togglePassword color-grey4""><i class=""icon icon-open-eye"">Html.TextBoxFor(m => m.SitePassword, new {class = ""form-control""})</i></button></div>
            //}
</script>


</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
