#pragma checksum "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0696a9757cd81e52dd4e578b63f65c3ada0b67a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
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
#line 1 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\_ViewImports.cshtml"
using MİdsoftWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\_ViewImports.cshtml"
using MİdsoftWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0696a9757cd81e52dd4e578b63f65c3ada0b67a4", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3870aafb1da6fc09e78c4b7a7030504cd190e28e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductDetail>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";
    Layout = "~/Views/Shared/MidLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0696a9757cd81e52dd4e578b63f65c3ada0b67a43670", async() => {
                WriteLiteral("\r\n    <title>\r\n\r\n    </title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0696a9757cd81e52dd4e578b63f65c3ada0b67a44671", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <br>\r\n        <br>\r\n");
#nullable restore
#line 18 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"section-title\" style=\"margin-top:12%\">\r\n                <h2>");
#nullable restore
#line 21 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
               Write(item.Baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <p></p>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-4 col-md-6 col-6 d-flex align-items-center justify-content-center\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 627, "\"", 696, 2);
                WriteAttributeValue("", 633, "data:image;base64,", 633, 18, true);
#nullable restore
#line 26 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
WriteAttributeValue("", 651, System.Convert.ToBase64String(item.Fotograf), 651, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 697, "\"", 703, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\" />\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 col-6 d-flex align-items-center justify-content-center\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 879, "\"", 949, 2);
                WriteAttributeValue("", 885, "data:image;base64,", 885, 18, true);
#nullable restore
#line 29 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
WriteAttributeValue("", 903, System.Convert.ToBase64String(item.Fotograf1), 903, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 950, "\"", 956, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\" />\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 col-6 d-flex align-items-center justify-content-center\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1132, "\"", 1202, 2);
                WriteAttributeValue("", 1138, "data:image;base64,", 1138, 18, true);
#nullable restore
#line 32 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
WriteAttributeValue("", 1156, System.Convert.ToBase64String(item.Fotograf2), 1156, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1203, "\"", 1209, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\" />\r\n                </div>\r\n            </div>\r\n            <div>\r\n                <ol style=\"font-size:20px\">\r\n\r\n");
#nullable restore
#line 38 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
                     if (item.Icerik != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 41 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
                       Write(item.Icerik);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 43 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
                     if (item.Icerik != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n\r\n                            ");
#nullable restore
#line 49 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
                       Write(item.Icerik2);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 51 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
                     if (item.Icerik != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n\r\n                            ");
#nullable restore
#line 57 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
                       Write(item.Icerik3);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 59 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ol>\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\ProductDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br>\r\n        <br>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
