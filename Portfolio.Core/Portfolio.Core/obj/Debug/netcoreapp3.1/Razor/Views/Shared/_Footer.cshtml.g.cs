#pragma checksum "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5325f865d7e4d6d377fbfcd92ef7edcbd191aee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#line 1 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
using Portfolio.Core.Models.Appsettings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5325f865d7e4d6d377fbfcd92ef7edcbd191aee2", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daad3ea096d60b0cf85245f1bd13769de6297385", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
  
    var rv = ViewContext.RouteData.Values;
    var thispage = $"{rv["Controller"]}-{rv["Action"]}".ToLowerInvariant();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<footer");
            BeginWriteAttribute("class", " class=\"", 255, "\"", 328, 4);
            WriteAttributeValue("", 263, "page-footer", 263, 11, true);
            WriteAttributeValue(" ", 274, "pt-4", 275, 5, true);
            WriteAttributeValue(" ", 279, "pb-4", 280, 5, true);
#nullable restore
#line 10 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
WriteAttributeValue(" ", 284, thispage == "home-index" ?  "fixed" : "", 285, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-md-8\">\r\n                <h5> About Me</h5>\r\n\r\n                <span>");
#nullable restore
#line 18 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
                 Write(appSettings.Value.Lead);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <a href=""#"" id=""footer-show-more"" class=""show-more more""><i class=""fad fa-info-circle ""></i> <span> more</span> </a></span>


                <div id=""about-me"">

                    Primarily based in London I have a wealth of knowledge in web development, database architecture, web design, SEO, server and domain management. As a technical lead, I have experience in team building,  managing developers, determining project requirements, liaising with both internal and external clients. Helping to build projects that increase profits, and drive efficiency.
                    <br />
                    <a href=""#"" class=""more""><i class=""fad fa-info-square""></i> read more </a>

                </div>

");
            WriteLiteral("\r\n                <!-- Copyright -->\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"col-md-4 \">\r\n                <div class=\"float-right\">\r\n\r\n                    <ul class=\"social-media\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1685, "\"", 1739, 2);
            WriteAttributeValue("", 1692, "mailto:", 1692, 7, true);
#nullable restore
#line 41 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 1699, appSettings.Value.ContactSettings.Email, 1699, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fad fa-envelope-open\"></i> </a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1820, "\"", 1870, 1);
#nullable restore
#line 42 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 1827, appSettings.Value.ContactSettings.LinkedIn, 1827, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fab fa-linkedin\"></i> </a></li>\r\n\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1948, "\"", 1997, 1);
#nullable restore
#line 44 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 1955, appSettings.Value.ContactSettings.Twitter, 1955, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter-square\"></i></a> </li>\r\n                        <li> <a");
            BeginWriteAttribute("href", " href=\"", 2079, "\"", 2127, 1);
#nullable restore
#line 45 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 2086, appSettings.Value.ContactSettings.Github, 2086, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-github-square\"></i></a> </li>\r\n                    </ul>\r\n\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <!-- Copyright -->\r\n</footer>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<AppSettings> appSettings { get; private set; }
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
