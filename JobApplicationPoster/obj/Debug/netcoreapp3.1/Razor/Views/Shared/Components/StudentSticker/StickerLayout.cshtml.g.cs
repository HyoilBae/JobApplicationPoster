#pragma checksum "C:\Users\hyoil\Documents\GitHub\JobApplicationPoster\JobApplicationPoster\Views\Shared\Components\StudentSticker\StickerLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6470b0dd51bfaedad33e0521c9ee65b92cc83a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_StudentSticker_StickerLayout), @"mvc.1.0.view", @"/Views/Shared/Components/StudentSticker/StickerLayout.cshtml")]
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
#line 1 "C:\Users\hyoil\Documents\GitHub\JobApplicationPoster\JobApplicationPoster\Views\_ViewImports.cshtml"
using JobApplicationPoster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hyoil\Documents\GitHub\JobApplicationPoster\JobApplicationPoster\Views\_ViewImports.cshtml"
using JobApplicationPoster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6470b0dd51bfaedad33e0521c9ee65b92cc83a7", @"/Views/Shared/Components/StudentSticker/StickerLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69956246894991a4b4f589d0bbc58eb803bbc4a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_StudentSticker_StickerLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<td>\r\n    <div>First Name: ");
#nullable restore
#line 3 "C:\Users\hyoil\Documents\GitHub\JobApplicationPoster\JobApplicationPoster\Views\Shared\Components\StudentSticker\StickerLayout.cshtml"
                Write(ViewBag.Students[Model].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Sticker Count: ");
#nullable restore
#line 4 "C:\Users\hyoil\Documents\GitHub\JobApplicationPoster\JobApplicationPoster\Views\Shared\Components\StudentSticker\StickerLayout.cshtml"
                   Write(ViewBag.Students[Model].StickerCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
