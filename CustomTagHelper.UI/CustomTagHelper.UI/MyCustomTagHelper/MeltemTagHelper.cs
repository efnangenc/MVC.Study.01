using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.UI.MyCustomTagHelper
{
    [HtmlTargetElement("meltem")]
    public class MeltemTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Attributes.SetAttribute("style", "color:brown;  font-size:56px; font-family:arial; box-shadow:0px 4px 8px rgba(0, 0, 0, 0.4);");
            output.Content.SetContent("meltemle ilgili bir şey 🛴");
        }
    }
}
