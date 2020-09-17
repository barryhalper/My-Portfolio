#pragma checksum "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3c669dc1ff815480774aeab20ff934d3931d61"
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
#nullable restore
#line 2 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3c669dc1ff815480774aeab20ff934d3931d61", @"/Views/Testimonials/TestimonialView.cshtml")]
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
#nullable restore
#line 4 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
  
    ViewBag.Title = "Testimonials";
    ViewBag.Meta = new MetaViewModel { Title = ViewBag.Title,  Description = Model.FirstOrDefault().Recommendation };


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"testimonial\" class=\"jumbotron\">\r\n\r\n\r\n    <div class=\"container\">\r\n        <section class=\"page mb-3\">\r\n\r\n            <h1 style=\"display:none;\"> ");
#nullable restore
#line 16 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
             foreach (var item in Model)
            {
              


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"pullquote \"");
            BeginWriteAttribute("id", " id=\"", 592, "\"", 617, 2);
            WriteAttributeValue("", 597, "testimonial-", 597, 12, true);
#nullable restore
#line 22 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
WriteAttributeValue("", 609, item.Id, 609, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n\r\n                    <div class=\"recommendation\">\r\n                        \" <span>");
#nullable restore
#line 27 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                           Write(item.Recommendation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \"\r\n                    </div>\r\n\r\n                    <div class=\"author mt-3 \">\r\n                        <div class=\"image-container\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e3c669dc1ff815480774aeab20ff934d3931d615651", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 881, "~/image/testimonials/", 881, 21, true);
#nullable restore
#line 31 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
AddHtmlAttributeValue("", 902, item.Image, 902, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
AddHtmlAttributeValue("", 920, item.Author, 920, 12, false);

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
#line 33 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                             Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <div class=\"position\">");
#nullable restore
#line 34 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                         Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </section>\r\n\r\n        <div class=\"container\">\r\n            <div class=\"testimonial-more float-right d-flex\">\r\n\r\n");
#nullable restore
#line 48 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <a href=\"#\" data-id=\"");
#nullable restore
#line 51 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("title", " title=\"", 1443, "\"", 1463, 1);
#nullable restore
#line 51 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
WriteAttributeValue("", 1451, item.Author, 1451, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fad fa-circle fa-2x\"></i></a>\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Testimonials\TestimonialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebHostEnvironment env { get; private set; }
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
