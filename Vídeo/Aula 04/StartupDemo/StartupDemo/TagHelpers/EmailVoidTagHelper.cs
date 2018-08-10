﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace StartupDemo.TagHelpers
{
    [HtmlTargetElement("email", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class EmailVoidTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public string MailInfo { get; set; }
        public override async Task ProcessAsync(TagHelperContent context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            output.Attributes.SetAttribute("href", "mailto:" + MailTo);
            output.Content.SetContent(MailInfo);
        }
    }
}
