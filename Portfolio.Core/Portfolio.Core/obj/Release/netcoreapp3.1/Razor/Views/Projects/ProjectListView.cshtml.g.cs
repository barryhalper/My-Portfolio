#pragma checksum "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2b352a155235664738bc1c050ff52d8083e143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_ProjectListView), @"mvc.1.0.view", @"/Views/Projects/ProjectListView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2b352a155235664738bc1c050ff52d8083e143", @"/Views/Projects/ProjectListView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daad3ea096d60b0cf85245f1bd13769de6297385", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_ProjectListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Portfolio.Core.Models.ProjectViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Modal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
  
    ViewBag.Title="Projects";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""project"" class=""jumbotron"">

    <img srcset=""
            /image/background/library.jpg  1024w,
            /image/background/library-medium.jpg 640w,
             /image/background/library-small.jpg 320w
            /image/background/library-wide.jpg  1980w"" ,
         sizes=""100vw""
         src=""/image/background/library-small.jpg"" alt=""skills"" />
    <div class=""container"">
        <section class=""page mb-3"">

            <h1>");
#nullable restore
#line 20 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n\r\n<section>\r\n    <div class=\"container  mt-3 \" id=\"project-body\">\r\n\r\n\r\n");
#nullable restore
#line 30 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
         foreach (var project in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\">\r\n                <div class=\"panel\">\r\n                    <div class=\"panel-heading\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
                   Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"panel-body\">\r\n\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d2b352a155235664738bc1c050ff52d8083e1436075", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1129, "~/image/projects/", 1129, 17, true);
#nullable restore
#line 43 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
AddHtmlAttributeValue("", 1146, project.Image, 1146, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
AddHtmlAttributeValue("", 1167, project.Name, 1167, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n\r\n                            <div class=\"col-md-6\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
                           Write(project.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        </div>\r\n                    </div>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Projects\ProjectListView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n      </div>\r\n       \r\n\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d2b352a155235664738bc1c050ff52d8083e1439019", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Portfolio.Core.Models.ProjectViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
