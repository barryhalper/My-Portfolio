#pragma checksum "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37d60c2ad8956c270d955e0ea443d1cd06e7355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideNavPartial), @"mvc.1.0.view", @"/Views/Shared/_SideNavPartial.cshtml")]
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
#line 1 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\_ViewImports.cshtml"
using Portfolio.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\_ViewImports.cshtml"
using Portfolio.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
using System.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37d60c2ad8956c270d955e0ea443d1cd06e7355", @"/Views/Shared/_SideNavPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a4d6b68c11fcab530998829e898f74241bb0ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SideNavPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/barry-halper-profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Barry Halper profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"sidebar\">\r\n    <div class=\"navbar-default\" role=\"navigation\">\r\n        <div class=\"sidebar-nav navbar-collapse\">\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c37d60c2ad8956c270d955e0ea443d1cd06e73554648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n           \r\n            <ul class=\"nav\" id=\"side-menu\">\r\n\r\n                <!-- /input-group -->\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 417, "\"", 442, 1);
#nullable restore
#line 15 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
WriteAttributeValue("", 424, Url.Content("~/"), 424, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-home\"></i> Home\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 599, "\"", 624, 1);
#nullable restore
#line 21 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
WriteAttributeValue("", 606, Url.Content("~/"), 606, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-chart-bar\"></i> Skills\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 788, "\"", 813, 1);
#nullable restore
#line 27 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
WriteAttributeValue("", 795, Url.Content("~/"), 795, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-external-link-square-alt\"></i> Projects\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1019, 1);
#nullable restore
#line 33 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
WriteAttributeValue("", 1001, Url.Content("~/"), 1001, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-file-pdf\"></i> CV / Resume\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1187, "\"", 1212, 1);
#nullable restore
#line 39 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
WriteAttributeValue("", 1194, Url.Content("~/"), 1194, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-newspaper\"></i> Articles\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1378, "\"", 1403, 1);
#nullable restore
#line 45 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
WriteAttributeValue("", 1385, Url.Content("~/"), 1385, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-blog\"></i> Blogs\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1561, "\"", 1586, 1);
#nullable restore
#line 51 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_SideNavPartial.cshtml"
WriteAttributeValue("", 1568, Url.Content("~/"), 1568, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""fas fa-university""></i> Education
                    </a>
                </li>

                <li class=""social-media"">
                    <ul>

                        <li><a href=""#""> <i class=""fab fa-linkedin""></i> </a></li>
                      
                        <li><a href=""#""><i class=""fab fa-twitter-square""></i></a> </li>
                        <li> <a href=""#""><i class=""fab fa-github-square""></i></a> </li>
                    </ul>
                </li>



            </ul>

            <div id=""close-menu"">
                <a href=""#""> <i class=""fas fa-arrow-alt-circle-left""></i></a>
            </div>
        </div>
        <!-- /.sidebar-collapse -->
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591