#pragma checksum "F:\Website Develop\VisionTake\VisionTake\Views\About\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fd49d38c9346ec1d6cf2b466fe917c88a7b3d57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_AboutUs), @"mvc.1.0.view", @"/Views/About/AboutUs.cshtml")]
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
#line 1 "F:\Website Develop\VisionTake\VisionTake\Views\_ViewImports.cshtml"
using VisionTake;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Website Develop\VisionTake\VisionTake\Views\_ViewImports.cshtml"
using VisionTake.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd49d38c9346ec1d6cf2b466fe917c88a7b3d57", @"/Views/About/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7650b73f47691663073f3af0a81928acbf20e0af", @"/Views/_ViewImports.cshtml")]
    public class Views_About_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VisionTake.Entities.TblAbout>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Website Develop\VisionTake\VisionTake\Views\About\AboutUs.cshtml"
  
    ViewData["Title"] = "AboutUs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ======= Breadcrumbs ======= -->
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <div class=""d-flex justify-content-between align-items-center"">
            <h2>About Us</h2>
            <ol>
                <li><a");
            BeginWriteAttribute("href", " href=\"", 389, "\"", 423, 1);
#nullable restore
#line 13 "F:\Website Develop\VisionTake\VisionTake\Views\About\AboutUs.cshtml"
WriteAttributeValue("", 396, Url.Action("Index","Home"), 396, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a></li>
                <li>About</li>
            </ol>
        </div>

    </div>
</section><!-- End Breadcrumbs -->

<section id=""about-us"" class=""about-us"">
    <div class=""container"" data-aos=""fade-up"">
        <div class=""row content"">
            <div class=""col-lg-6"" data-aos=""fade-right"">

                <img class=""col-lg-12 col-sm-12 col-md-12""");
            BeginWriteAttribute("src", " src=\"", 802, "\"", 850, 1);
#nullable restore
#line 26 "F:\Website Develop\VisionTake\VisionTake\Views\About\AboutUs.cshtml"
WriteAttributeValue("", 808, Url.Content("~/Images/" + Model.ImageUrl), 808, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-lg-6 pt-4 pt-lg-0\" data-aos=\"fade-left\">\r\n                <h2 style=\"text-align:center\">");
#nullable restore
#line 29 "F:\Website Develop\VisionTake\VisionTake\Views\About\AboutUs.cshtml"
                                         Write(Model.AboutTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>\r\n                    ");
#nullable restore
#line 31 "F:\Website Develop\VisionTake\VisionTake\Views\About\AboutUs.cshtml"
               Write(Model.AboutDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisionTake.Entities.TblAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591