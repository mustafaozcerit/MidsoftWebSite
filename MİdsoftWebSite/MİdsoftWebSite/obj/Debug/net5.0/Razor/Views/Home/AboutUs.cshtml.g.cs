#pragma checksum "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b2e80438a250ba8207cf39a9cb41c2bc531c4cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
#line 1 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
using MİdsoftWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b2e80438a250ba8207cf39a9cb41c2bc531c4cd", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3870aafb1da6fc09e78c4b7a7030504cd190e28e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutU>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/atap.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("1000"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
  
    ViewData["Title"] = "Hakkımızda";
    Layout = "~/Views/Shared/MidLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b2e80438a250ba8207cf39a9cb41c2bc531c4cd4836", async() => {
                WriteLiteral("\r\n    <title>Midsoft Company</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 361, "\"", 368, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 383, "\"", 389, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 413, "\"", 419, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <style>\r\n        #baslik {\r\n            /*color:red;*/\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b2e80438a250ba8207cf39a9cb41c2bc531c4cd6576", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h2");
                BeginWriteAttribute("class", " class=\"", 574, "\"", 582, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-top:8%\" align-items-center> </h2>\r\n        <div class=\"section-title\">\r\n            <h2>Hakkımızda</h2>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n");
                WriteLiteral("            <div class=\"row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b2e80438a250ba8207cf39a9cb41c2bc531c4cd7301", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <br />\r\n                <br />\r\n");
#nullable restore
#line 36 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h2 class=\"col-sm-12 col-md-12 text-center\" id=\"baslik\">");
#nullable restore
#line 38 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                                                                       Write(item.Baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <ul>\r\n");
#nullable restore
#line 40 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                         if (item.Icerik != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <p class=\"col-sm-9 col-md-12\">");
#nullable restore
#line 43 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                                                         Write(item.Icerik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </li>\r\n");
#nullable restore
#line 45 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                         if (item.Icerik2 != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <p class=\"col-sm-9 col-md-12\">");
#nullable restore
#line 49 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                                                         Write(item.Icerik2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n                            </li>\r\n");
#nullable restore
#line 52 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                         if (item.Icerik3 != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <p class=\"col-sm-9 col-md-12\">");
#nullable restore
#line 56 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                                                         Write(item.Icerik3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n                            </li>\r\n");
#nullable restore
#line 59 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 61 "C:\Users\musta\OneDrive\Masaüstü\MidsoftWebSiteV2\MİdsoftWebSite\MİdsoftWebSite\Views\Home\AboutUs.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <br />\r\n            <br />\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("        </div>\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AboutU>> Html { get; private set; }
    }
}
#pragma warning restore 1591
