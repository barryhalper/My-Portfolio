#pragma checksum "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Skills\_SkillsDock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8091f9a24735985ea66706414444e4dfcd58261d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skills__SkillsDock), @"mvc.1.0.view", @"/Views/Skills/_SkillsDock.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8091f9a24735985ea66706414444e4dfcd58261d", @"/Views/Skills/_SkillsDock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daad3ea096d60b0cf85245f1bd13769de6297385", @"/Views/_ViewImports.cshtml")]
    public class Views_Skills__SkillsDock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Portfolio.Core.Models.SkillsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div id=\"skills-dock\">\r\n    <ul>\r\n");
#nullable restore
#line 18 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Skills\_SkillsDock.cshtml"
         foreach (var skill in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1545, "\"", 1571, 2);
            WriteAttributeValue("", 1551, "~/image/", 1551, 8, true);
#nullable restore
#line 19 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Skills\_SkillsDock.cshtml"
WriteAttributeValue("", 1559, skill.Image, 1559, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1572, "\"", 1589, 1);
#nullable restore
#line 19 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Skills\_SkillsDock.cshtml"
WriteAttributeValue("", 1578, skill.Name, 1578, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1590, "\"", 1609, 1);
#nullable restore
#line 19 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Skills\_SkillsDock.cshtml"
WriteAttributeValue("", 1598, skill.Name, 1598, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 20 "C:\Users\barry\Documents\My Portfolio\Portfolio.Core\Portfolio.Core\Views\Skills\_SkillsDock.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Portfolio.Core.Models.SkillsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591