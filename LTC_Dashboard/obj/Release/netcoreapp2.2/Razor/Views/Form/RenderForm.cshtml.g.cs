#pragma checksum "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6ae2854fd6b6448312f2082ed46f83be3929c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_RenderForm), @"mvc.1.0.view", @"/Views/Form/RenderForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Form/RenderForm.cshtml", typeof(AspNetCore.Views_Form_RenderForm))]
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
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6ae2854fd6b6448312f2082ed46f83be3929c7", @"/Views/Form/RenderForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_RenderForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
  
    Layout = "~/Views/Shared/Layouts/_RenderFormLayout.cshtml";

#line default
#line hidden
            BeginContext(229, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(231, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc6ae2854fd6b6448312f2082ed46f83be3929c73949", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 243, "~/Resources/FormDesigner/assets/css/RateYo/RateYo.css?v=", 243, 56, true);
#line 8 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
AddHtmlAttributeValue("", 299, Configuration.GetSection("Configuration")["staticFileVersion"], 299, 63, false);

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
            BeginContext(383, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
  
    string os = "0", fid = "0", pid = "0";
    os = HttpContextAccessor.HttpContext.Request.Query["os"].ToString();
    pid = HttpContextAccessor.HttpContext.Request.Query["pi"].ToString();
    fid = HttpContextAccessor.HttpContext.Request.Query["fi"].ToString();

    //if (HttpContextAccessor.HttpContext.Request.Query["os"].ToString() != null)
    //{
    //    os = HttpContextAccessor.HttpContext.Request.Query["os"].ToString();
    //}
    //if (HttpContextAccessor.HttpContext.Request.Query["pi"].ToString() != null)
    //{
    //    pid = HttpContextAccessor.HttpContext.Request.Query["pi"].ToString();
    //}
    //if (HttpContextAccessor.HttpContext.Request.Query["fi"].ToString() != null)
    //{
    //    fid = HttpContextAccessor.HttpContext.Request.Query["fi"].ToString();
    //}

#line default
#line hidden
            BeginContext(1705, 102, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <input type=\"hidden\" name=\"hid_os\" id=\"hid_os\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1807, "\"", 1818, 1);
#line 33 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
WriteAttributeValue("", 1815, os, 1815, 3, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1819, 61, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"hid_fid\" id=\"hid_fid\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1880, "\"", 1892, 1);
#line 34 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
WriteAttributeValue("", 1888, fid, 1888, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1893, 61, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"hid_pid\" id=\"hid_pid\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1954, "\"", 1966, 1);
#line 35 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
WriteAttributeValue("", 1962, pid, 1962, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1967, 300, true);
            WriteLiteral(@" />
        <div id=""render-container"" class=""renderingFormStyling"">
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <input type='button' class=""btn btn-success pull-right"" value=""Submit form"" onclick=""FormRender.saveRendering()"" />
    </div>
</div>
");
            EndContext();
            BeginContext(2280, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2307, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2638, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2644, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6ae2854fd6b6448312f2082ed46f83be3929c78917", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2657, "~/Resources/theme/js/vendor/datatables.net/js/datatables.min.js?v=", 2657, 66, true);
#line 52 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
AddHtmlAttributeValue("", 2723, Configuration.GetSection("Configuration")["staticFileVersion"], 2723, 63, false);

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
                BeginContext(2797, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2803, 175, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6ae2854fd6b6448312f2082ed46f83be3929c710706", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2816, "~/Resources/theme/js/vendor/datatables.net/js/Select-1.2.6/js/select.bootstrap.min.js?v=", 2816, 88, true);
#line 53 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
AddHtmlAttributeValue("", 2904, Configuration.GetSection("Configuration")["staticFileVersion"], 2904, 63, false);

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
                BeginContext(2978, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3134, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(3138, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6ae2854fd6b6448312f2082ed46f83be3929c712630", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3151, "~/Resources/FormDesigner/assets/js/form-render.min.js?v=", 3151, 56, true);
#line 55 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
AddHtmlAttributeValue("", 3207, Configuration.GetSection("Configuration")["staticFileVersion"], 3207, 63, false);

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
                BeginContext(3281, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3455, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(3459, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6ae2854fd6b6448312f2082ed46f83be3929c714522", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3472, "~/Resources/FormDesigner/assets/js/Rateyo/jquery.rateyo.min.js?v=", 3472, 65, true);
#line 57 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
AddHtmlAttributeValue("", 3537, Configuration.GetSection("Configuration")["staticFileVersion"], 3537, 63, false);

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
                BeginContext(3611, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3617, 118, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6ae2854fd6b6448312f2082ed46f83be3929c716311", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3630, "~/Scripts/Form/FormRender.js?v=", 3630, 31, true);
#line 58 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Form\RenderForm.cshtml"
AddHtmlAttributeValue("", 3661, Configuration.GetSection("Configuration")["staticFileVersion"], 3661, 63, false);

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
                BeginContext(3735, 4, true);
                WriteLiteral("\r\n\r\n");
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
