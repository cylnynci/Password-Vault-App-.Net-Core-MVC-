#pragma checksum "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d2326c9fedbe35df1ae5dda594b44e7deb97ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_SiteList), @"mvc.1.0.view", @"/Views/Site/SiteList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2326c9fedbe35df1ae5dda594b44e7deb97ec9", @"/Views/Site/SiteList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b729101a3a3c5e91fb2d85a3c13f18d95b0f01d", @"/Views/_ViewImports.cshtml")]
    public class Views_Site_SiteList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Site>>
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
#line 2 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
  


    //Layout = "~/Views/Shared/_UILayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d2326c9fedbe35df1ae5dda594b44e7deb97ec93562", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d2326c9fedbe35df1ae5dda594b44e7deb97ec94978", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 21 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
         using (Html.BeginForm("AccountList", "Site", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h2>\r\n                Sites and Details\r\n            </h2>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 808, "\"", 844, 1);
#nullable restore
#line 26 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
WriteAttributeValue("", 815, Url.Action("AddSite","Site"), 815, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><input class=\"navbar-brand\" type=\"button\" value=\"Add Site\" /></a>\r\n");
                WriteLiteral(@"    <table class=""table table-hover"">
        <thead>

            <tr>
                <th>Site Name</th>
                <th>Site Address</th>
                <th>Delete</th>
                <th>Update</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 44 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
             foreach (var site in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td style=\"height: 150px;\">");
#nullable restore
#line 47 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
                                          Write(site.SiteName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"height: 150px; word-break: break-word;\">");
#nullable restore
#line 48 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
                                                                  Write(site.SiteAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"height: 150px;\"><a");
                BeginWriteAttribute("href", " href=\"", 1705, "\"", 1765, 3);
#nullable restore
#line 49 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
WriteAttributeValue("", 1712, Url.Action("DeleteSite", "Site"), 1712, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1745, "?SiteId=", 1745, 8, true);
#nullable restore
#line 49 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
WriteAttributeValue("", 1753, site.SiteId, 1753, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n                    <td style=\"height: 150px;\"><a");
                BeginWriteAttribute("href", " href=\"", 1856, "\"", 1913, 3);
#nullable restore
#line 50 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
WriteAttributeValue("", 1863, Url.Action("GetSite", "Site"), 1863, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1893, "?SiteId=", 1893, 8, true);
#nullable restore
#line 50 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
WriteAttributeValue("", 1901, site.SiteId, 1901, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 56 "C:\Users\Ceylan\source\repos\PasswordVaultApp\PasswordVaultApp\Views\Site\SiteList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Site>> Html { get; private set; }
    }
}
#pragma warning restore 1591
