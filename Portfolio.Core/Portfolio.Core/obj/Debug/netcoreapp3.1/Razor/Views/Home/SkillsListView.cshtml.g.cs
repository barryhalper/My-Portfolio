#pragma checksum "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52c100102fa99d6819c1593e9b99458a47b2394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SkillsListView), @"mvc.1.0.view", @"/Views/Home/SkillsListView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52c100102fa99d6819c1593e9b99458a47b2394", @"/Views/Home/SkillsListView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daad3ea096d60b0cf85245f1bd13769de6297385", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SkillsListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SkillsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_backgroundImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-auto ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
  
    ViewBag.Title = "Skills";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"skills\">\r\n\r\n    <div class=\"jumbotron\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f52c100102fa99d6819c1593e9b99458a47b23944655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (string)ViewBag.Title.ToLower();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"container\">\r\n            <section class=\"page mb-3\">\r\n\r\n                <h1>Skills</h1>\r\n            </section>\r\n        </div>\r\n    </div>\r\n\r\n    <section>\r\n        <div class=\"row mt-3 skills-container\" >\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
             foreach (var type in Model.Types)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4 col-sm-4 col-md-2 col-lg-2 col-xl-2\">\r\n\r\n                    <div class=\"panel\">\r\n                        <div class=\"panel-heading justify-content-center d-flex\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
                       Write(type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"panel-body \">\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 857, "\"", 865, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n");
#nullable restore
#line 41 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
                                 foreach (var skill in Model.Filter(type))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"container mb-4 col-12\">\r\n                                    <div class=\"row \">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f52c100102fa99d6819c1593e9b99458a47b23948081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1159, "~/image/skills/", 1159, 15, true);
#nullable restore
#line 45 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
AddHtmlAttributeValue("", 1174, skill.Image, 1174, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 45 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
AddHtmlAttributeValue("", 1226, skill.Name, 1226, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
AddHtmlAttributeValue("", 1292, skill.Name, 1292, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                       \r\n                                        </div>\r\n\r\n                                    <div class=\"row justify-content-center\">\r\n                                        ");
#nullable restore
#line 52 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
                                   Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 56 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 64 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Home\SkillsListView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </section>\r\n\r\n</div>\r\n\r\n\r\n<script>\r\n  \r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkillsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
