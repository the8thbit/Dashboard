#pragma checksum "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae26c17ad695278fcbcdbe7e913de9777b859523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_RenderSurvey), @"mvc.1.0.view", @"/Views/Survey/RenderSurvey.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/RenderSurvey.cshtml", typeof(AspNetCore.Views_Survey_RenderSurvey))]
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
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\_ViewImports.cshtml"
using LTCDashboard;

#line default
#line hidden
#line 2 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\_ViewImports.cshtml"
using LTCDashboard.Models;

#line default
#line hidden
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae26c17ad695278fcbcdbe7e913de9777b859523", @"/Views/Survey/RenderSurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_RenderSurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
  
    Layout = "~/Views/Shared/Layouts/_RenderSurveyLayout.cshtml";

    string os = "0", fid = "0", pid = "0";
    os = HttpContextAccessor.HttpContext.Request.Query["os"].ToString();
    pid = HttpContextAccessor.HttpContext.Request.Query["pi"].ToString();
    fid = HttpContextAccessor.HttpContext.Request.Query["fi"].ToString();

    //if (HttpContextAccessor.HttpContext.Request.Query["os"] != null)
    //{
    //    os = HttpContextAccessor.HttpContext.Request.Query["os"].ToString();
    //}
    //if (HttpContextAccessor.HttpContext.Request.Query["pi"] != null)
    //{
    //    pid = HttpContextAccessor.HttpContext.Request.Query["pi"].ToString();
    //}
    //if (HttpContextAccessor.HttpContext.Request.Query["fi"] != null)
    //{
    //    fid = HttpContextAccessor.HttpContext.Request.Query["fi"].ToString();
    //}

#line default
#line hidden
            BeginContext(1017, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1019, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae26c17ad695278fcbcdbe7e913de9777b8595234876", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1031, "~/Resources/FormDesigner/assets/css/RateYo/RateYo.css?v=", 1031, 56, true);
#line 27 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
AddHtmlAttributeValue("", 1087, Configuration.GetSection("Configuration")["staticFileVersion"], 1087, 63, false);

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
            BeginContext(1171, 104, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <input type=\"hidden\" name=\"hid_os\" id=\"hid_os\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1275, "\"", 1286, 1);
#line 30 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
WriteAttributeValue("", 1283, os, 1283, 3, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1287, 61, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"hid_fid\" id=\"hid_fid\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1348, "\"", 1360, 1);
#line 31 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
WriteAttributeValue("", 1356, fid, 1356, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1361, 61, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"hid_pid\" id=\"hid_pid\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1422, "\"", 1434, 1);
#line 32 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
WriteAttributeValue("", 1430, pid, 1430, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1435, 314, true);
            WriteLiteral(@" />
        <div id=""render-container"" class=""renderingSurveyStyling"">
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <input type='button' class=""btn btn-success pull-right"" value=""Submit form"" onclick=""SurveyRender.saveRendering()"" />
    </div>
</div>

<br />
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1766, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1774, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae26c17ad695278fcbcdbe7e913de9777b8595238607", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1787, "~/Resources/theme/js/vendor/datatables.net/js/datatables.min.js?v=", 1787, 66, true);
#line 46 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
AddHtmlAttributeValue("", 1853, Configuration.GetSection("Configuration")["staticFileVersion"], 1853, 63, false);

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
                BeginContext(1927, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1933, 175, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae26c17ad695278fcbcdbe7e913de9777b85952310400", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1946, "~/Resources/theme/js/vendor/datatables.net/js/Select-1.2.6/js/select.bootstrap.min.js?v=", 1946, 88, true);
#line 47 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
AddHtmlAttributeValue("", 2034, Configuration.GetSection("Configuration")["staticFileVersion"], 2034, 63, false);

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
                BeginContext(2108, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2114, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae26c17ad695278fcbcdbe7e913de9777b85952312216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2127, "~/Resources/FormDesigner/assets/js/form-render.min.js?v=", 2127, 56, true);
#line 48 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
AddHtmlAttributeValue("", 2183, Configuration.GetSection("Configuration")["staticFileVersion"], 2183, 63, false);

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
                BeginContext(2257, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2263, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae26c17ad695278fcbcdbe7e913de9777b85952314000", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2276, "~/Resources/FormDesigner/assets/js/Rateyo/jquery.rateyo.min.js?v=", 2276, 65, true);
#line 49 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
AddHtmlAttributeValue("", 2341, Configuration.GetSection("Configuration")["staticFileVersion"], 2341, 63, false);

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
                BeginContext(2415, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2421, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae26c17ad695278fcbcdbe7e913de9777b85952315793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2434, "~/Scripts/Survey/SurveyRender.js?v=", 2434, 35, true);
#line 50 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\RenderSurvey.cshtml"
AddHtmlAttributeValue("", 2469, Configuration.GetSection("Configuration")["staticFileVersion"], 2469, 63, false);

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
                BeginContext(2543, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
