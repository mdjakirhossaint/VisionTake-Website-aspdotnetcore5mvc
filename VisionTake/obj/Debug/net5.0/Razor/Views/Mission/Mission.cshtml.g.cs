#pragma checksum "F:\Website Develop\VisionTake\VisionTake\Views\Mission\Mission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf29a790c439beae298174cda274385178d1bed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mission_Mission), @"mvc.1.0.view", @"/Views/Mission/Mission.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf29a790c439beae298174cda274385178d1bed", @"/Views/Mission/Mission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7650b73f47691663073f3af0a81928acbf20e0af", @"/Views/_ViewImports.cshtml")]
    public class Views_Mission_Mission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VisionTake.ViewModels.MissionViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Website Develop\VisionTake\VisionTake\Views\Mission\Mission.cshtml"
  
    ViewData["Title"] = "Mission";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ======= Breadcrumbs ======= -->
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <div class=""d-flex justify-content-between align-items-center"">
            <h2>Mision</h2>
            <ol>
                <li><a");
            BeginWriteAttribute("href", " href=\"", 399, "\"", 419, 1);
#nullable restore
#line 14 "F:\Website Develop\VisionTake\VisionTake\Views\Mission\Mission.cshtml"
WriteAttributeValue("", 406, Url.Action(), 406, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n                <li>Misions</li>\r\n                <li>Mision</li>\r\n            </ol>\r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Breadcrumbs -->\r\n<section id=\"about-us\" class=\"about-us\">\r\n");
#nullable restore
#line 23 "F:\Website Develop\VisionTake\VisionTake\Views\Mission\Mission.cshtml"
     foreach (var item in Model.TblMission)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" data-aos=\"fade-up\">\r\n        <div class=\"row content\">\r\n            <div class=\"col-lg-6\" data-aos=\"fade-right\">\r\n\r\n                <img class=\"col-lg-12 col-sm-12 col-md-12\"");
            BeginWriteAttribute("src", " src=\"", 880, "\"", 927, 1);
#nullable restore
#line 29 "F:\Website Develop\VisionTake\VisionTake\Views\Mission\Mission.cshtml"
WriteAttributeValue("", 886, Url.Content("~/Images/" + item.ImageUrl), 886, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-lg-6 pt-4 pt-lg-0\" data-aos=\"fade-left\">\r\n                <h2 style=\"text-align:center\">Mision</h2>\r\n                <p>\r\n                    ");
#nullable restore
#line 34 "F:\Website Develop\VisionTake\VisionTake\Views\Mission\Mission.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 40 "F:\Website Develop\VisionTake\VisionTake\Views\Mission\Mission.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisionTake.ViewModels.MissionViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
