#pragma checksum "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da14009c28ac4f35f8a5b48bd9417df8e31bc0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonials_TestimonialView), @"mvc.1.0.view", @"/Views/Testimonials/TestimonialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da14009c28ac4f35f8a5b48bd9417df8e31bc0b", @"/Views/Testimonials/TestimonialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daad3ea096d60b0cf85245f1bd13769de6297385", @"/Views/_ViewImports.cshtml")]
    public class Views_Testimonials_TestimonialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Portfolio.Core.Models.TestimonialViewModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
  
    ViewBag.Title = "Testimonials";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"testimonial\" class=\"jumbotron\">\r\n\r\n\r\n    <div class=\"container\">\r\n        <section class=\"page mb-3\">\r\n\r\n            <h1 style=\"display:none;\"> ");
#nullable restore
#line 13 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"pullquote\"");
            BeginWriteAttribute("id", " id=\"", 384, "\"", 409, 2);
            WriteAttributeValue("", 389, "testimonial-", 389, 12, true);
#nullable restore
#line 17 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
WriteAttributeValue("", 401, item.Id, 401, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n\r\n                    <div class=\"recommendation\">\r\n                        \" <span>");
#nullable restore
#line 22 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                           Write(item.Recommendation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \"\r\n                    </div>\r\n\r\n                    <div class=\"author mt-3 \">\r\n                        <div class=\"image-container\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2da14009c28ac4f35f8a5b48bd9417df8e31bc0b5319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 673, "~/image/testimonials/", 673, 21, true);
#nullable restore
#line 26 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
AddHtmlAttributeValue("", 694, item.Image, 694, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
AddHtmlAttributeValue("", 712, item.Author, 712, 12, false);

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
            WriteLiteral("</div>\r\n\r\n                        <span class=\"author-name\">");
#nullable restore
#line 28 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                             Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <div class=\"position\">");
#nullable restore
#line 29 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                         Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </section>\r\n\r\n        <div class=\"container\">\r\n            <div class=\"testimonial-more float-right d-flex\">\r\n\r\n");
#nullable restore
#line 42 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <a href=\"#\" data-id=\"");
#nullable restore
#line 45 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("title", " title=\"", 1218, "\"", 1238, 1);
#nullable restore
#line 45 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
WriteAttributeValue("", 1226, item.Author, 1226, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fad fa-circle fa-2x\"></i></a>\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Portfolio.Core.Models.TestimonialViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
