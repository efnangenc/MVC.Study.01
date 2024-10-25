﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.UI.MyCustomTagHelper
{
    [HtmlTargetElement("stok-durum")]
    public class StokTagHelper : TagHelper

    {
        public int Stok { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";
            string renk;
            string mesaj;

            if (Stok > 20)
            {
                renk = "green";
                mesaj = $"Stok durumu {Stok} adet - yeterli miktarda var";
            }
            else if (Stok > 10)
            {
                renk = "orange";
                mesaj = $"Stok durumu {Stok} adet - kritik durumda";
            }
            else
            {
                renk = "red";
                mesaj = $"Stok durumu {Stok} adet - bitti bitecek";
            }

            output.Attributes.SetAttribute("style", $"color:{renk}");
            output.Content.SetContent(mesaj);
        }
    }
}
