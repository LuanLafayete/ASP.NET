using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DevIO.UI.Site.Extensions
{
    public class EmailTagHelper : TagHelper 
    {
        public string DominioEmail { get; set; } = "knockknockenglish.com.br";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + DominioEmail;
            output.Attributes.SetAttribute("href", "malito:" + target);
            output.Content.SetContent(target);
        }
    }
}
