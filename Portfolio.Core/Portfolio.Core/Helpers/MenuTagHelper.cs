using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Portfolio.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("email")]
    public class MenuTagHelper : TagHelper
    {
      
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = "a";
            //output.Content = "HELLO";

        }
    }
}
