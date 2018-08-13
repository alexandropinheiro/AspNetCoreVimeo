using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupDemo.TagHelpers
{
    [HtmlTargetElement("email", TagStructure =TagStructure.NormalOrSelfClosing)]
    public class EmailVoidTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public string MailInfo { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto: " + MailTo);
            output.Content.SetContent(MailInfo);
            return base.ProcessAsync(context, output);
        }

    }
}
