#pragma checksum "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Layouts__RenderSurveyLayout), @"mvc.1.0.view", @"/Views/Shared/Layouts/_RenderSurveyLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Layouts/_RenderSurveyLayout.cshtml", typeof(AspNetCore.Views_Shared_Layouts__RenderSurveyLayout))]
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
#line 1 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\_ViewImports.cshtml"
using LTCDashboard;

#line default
#line hidden
#line 2 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\_ViewImports.cshtml"
using LTCDashboard.Models;

#line default
#line hidden
#line 1 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de96e84b36f76ef8f4cb9e4b60b64c5c24e760b6", @"/Views/Shared/Layouts/_RenderSurveyLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Layouts__RenderSurveyLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("demo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(118, 2436, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b64492", async() => {
                BeginContext(124, 33, true);
                WriteLiteral("\r\n    <title>LTC-Dental (Survey) ");
                EndContext();
                BeginContext(158, 13, false);
#line 7 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
                          Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(171, 441, true);
                WriteLiteral(@"</title>

    <!-- META SECTION -->
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""shortcut icon"" href=""favicon.ico"" type=""image/x-icon"">
    <link rel=""icon"" href=""favicon.ico"" type=""image/x-icon"">
    <!-- END META SECTION -->
    <!-- CSS INCLUDE -->
    ");
                EndContext();
                BeginContext(612, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b65737", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 624, "~/Resources/loadermain.css?v=", 624, 29, true);
#line 18 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
AddHtmlAttributeValue("", 653, Configuration.GetSection("Configuration")["staticFileVersion"], 653, 63, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(737, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(743, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b67562", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 755, "~/Resources/loadernormalize.css?v=", 755, 34, true);
#line 19 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
AddHtmlAttributeValue("", 789, Configuration.GetSection("Configuration")["staticFileVersion"], 789, 63, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(873, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(879, 129, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b69392", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 892, "~/Resources/theme/js/modernizr-2.8.3.js?v=", 892, 42, true);
#line 20 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
AddHtmlAttributeValue("", 934, Configuration.GetSection("Configuration")["staticFileVersion"], 934, 63, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1008, 1006, true);
                WriteLiteral(@"
    <style type=""text/css"">

        .back-link a {
            color: #4ca340;
            text-decoration: none;
            border-bottom: 1px #4ca340 solid;
        }

            .back-link a:hover,
            .back-link a:focus {
                color: #408536;
                text-decoration: none;
                border-bottom: 1px #408536 solid;
            }

        h1 {
            height: 100%;
            /* The html and body elements cannot have any padding or margin. */
            margin: 0;
            font-size: 14px;
            font-family: 'Open Sans', sans-serif;
            font-size: 32px;
            margin-bottom: 3px;
        }

        .entry-header {
            text-align: left;
            margin: 0 auto 50px auto;
            width: 80%;
            max-width: 978px;
            position: relative;
            z-index: 10001;
        }

        #demo-content {
            padding-top: 100px;
        }
    </style>
    ");
                EndContext();
                BeginContext(2014, 129, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b612156", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2043, "~/Resources/theme/css/styles.css?v=", 2043, 35, true);
#line 59 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
AddHtmlAttributeValue("", 2078, Configuration.GetSection("Configuration")["staticFileVersion"], 2078, 63, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2143, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2152, 49, false);
#line 61 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
Write(RenderSection("pagelevelstyles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2201, 38, true);
                WriteLiteral("\r\n    <!-- EOF CSS INCLUDE -->\r\n\r\n    ");
                EndContext();
                BeginContext(2240, 45, false);
#line 64 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
Write(RenderSection("headscripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2285, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2291, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b614800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2303, "~/Resources/Site.css?v=", 2303, 23, true);
#line 65 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
AddHtmlAttributeValue("", 2326, Configuration.GetSection("Configuration")["staticFileVersion"], 2326, 63, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2410, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2554, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2556, 1098, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b617423", async() => {
                BeginContext(2575, 33, true);
                WriteLiteral("\r\n    <div id=\"loader-wrapper\">\r\n");
                EndContext();
                BeginContext(2677, 477, true);
                WriteLiteral(@"        <div id=""loader""></div>

        <div class=""loader-section section-left""></div>
        <div class=""loader-section section-right""></div>

    </div>
    <!-- APP WRAPPER -->
    <div class=""app"">

        <!-- START APP CONTAINER -->
        <div class=""container"">
            <!-- START APP CONTENT -->
            <div class=""container-boxed"">
                <!-- START PAGE CONTAINER -->
                <div class=""container"">
                    ");
                EndContext();
                BeginContext(3155, 12, false);
#line 86 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3167, 272, true);
                WriteLiteral(@"
                </div>
                <!-- END PAGE CONTAINER -->

            </div>
            <!-- END APP CONTENT -->

        </div>

        <!-- APP OVERLAY -->
        <div class=""app-overlay""></div>
        <!-- END APP OVERLAY -->
    </div>
    ");
                EndContext();
                BeginContext(3440, 27, false);
#line 99 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
Write(Html.Partial("_AppScripts"));

#line default
#line hidden
                EndContext();
                BeginContext(3467, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3475, 118, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de96e84b36f76ef8f4cb9e4b60b64c5c24e760b619447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3488, "~/Scripts/SharedJS/Layout.js?v=", 3488, 31, true);
#line 101 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
AddHtmlAttributeValue("", 3519, Configuration.GetSection("Configuration")["staticFileVersion"], 3519, 63, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3593, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3602, 41, false);
#line 103 "F:\LTC Git\Dashboard\LTC_Dashboard\Views\Shared\Layouts\_RenderSurveyLayout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(3643, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3654, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
