#pragma checksum "D:\Office\Github\Dashboard\LTC_Dashboard\Views\Subscribers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af32ea9376f49c530fea110ce17a40bf4ddc0a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscribers_Index), @"mvc.1.0.view", @"/Views/Subscribers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subscribers/Index.cshtml", typeof(AspNetCore.Views_Subscribers_Index))]
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
#line 1 "D:\Office\Github\Dashboard\LTC_Dashboard\Views\_ViewImports.cshtml"
using LTCDashboard;

#line default
#line hidden
#line 2 "D:\Office\Github\Dashboard\LTC_Dashboard\Views\_ViewImports.cshtml"
using LTCDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af32ea9376f49c530fea110ce17a40bf4ddc0a42", @"/Views/Subscribers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscribers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Resources/theme/js/vendor/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Resources/theme/js/vendor/datatables.net/js/DataTables-1.10.18/js/dataTables.bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ScriptsView/Subscribers.js?version=5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Office\Github\Dashboard\LTC_Dashboard\Views\Subscribers\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/Layouts/_NewsletterLayout.cshtml";


#line default
#line hidden
            BeginContext(106, 1136, true);
            WriteLiteral(@"<div class=""content"">
    <div class=""row"">
        <div class=""card"" style=""width:100%"">
            <div class=""card-header bg-white header-elements-inline"">
                <h6 class=""card-title font-variant-smallCaps"">Subscribers</h6>
                <div class=""header-elements"">
                    <div class=""list-icons"">
                        <a class=""list-icons-item"" data-action=""collapse""></a>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <table id=""subscriberTable"" class=""table table-striped table-hover table-checkable order-column""></table>
                    </div>

                </div>
            </div>
        </div>
    </div>




    <div id=""modifySubscription"" class=""modal"" tabindex=""-1"" data-width=""400"" data-keyboard=""false"" role=""dialog"" aria-labelledby=""modifySubscription"" aria-hidden=""true"" data-ba");
            WriteLiteral("ckdrop=\"static\">\r\n        <div id=\"modifySubscriptionContainer\">\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1295, 455, true);
            WriteLiteral(@"<div id=""div_template"" style=""display:none"">
    <div id=""div_grid_actions"">
        <div class=""btn-group"">

            <div class=""list-icons"">
                <div class=""dropdown"">
                    <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                        <i class=""icon-menu9""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a href=""#""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1750, "\"", 1863, 3);
            WriteAttributeValue("", 1760, "Subscription.toggleSubscription(\'", 1760, 33, true);
#line 53 "D:\Office\Github\Dashboard\LTC_Dashboard\Views\Subscribers\Index.cshtml"
WriteAttributeValue("", 1793, Url.Action("ToggleStatus", "Subscribers", new {  Id="__prm_id__" }), 1793, 68, false);

#line default
#line hidden
            WriteAttributeValue("", 1861, "\')", 1861, 2, true);
            EndWriteAttribute();
            BeginContext(1864, 99, true);
            WriteLiteral(" class=\"dropdown-item\"><i class=\"icon-shuffle\"></i> Toggle</a>\r\n                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1963, "\"", 2068, 3);
            WriteAttributeValue("", 1973, "Subscription.modifySubscription(\'", 1973, 33, true);
#line 54 "D:\Office\Github\Dashboard\LTC_Dashboard\Views\Subscribers\Index.cshtml"
WriteAttributeValue("", 2006, Url.Action("Edit", "Subscribers",new { Id= "__prm_id__" }), 2006, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 2065, "\');", 2065, 3, true);
            EndWriteAttribute();
            BeginContext(2069, 153, true);
            WriteLiteral(" data-target=\"#modifySubscription\" data-toggle=\"modal\" class=\"dropdown-item\"><i class=\"icon-pencil7\"></i> Modify</a>\r\n                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2222, "\"", 2328, 3);
            WriteAttributeValue("", 2232, "Subscription.deleteSubscription(\'", 2232, 33, true);
#line 55 "D:\Office\Github\Dashboard\LTC_Dashboard\Views\Subscribers\Index.cshtml"
WriteAttributeValue("", 2265, Url.Action("Delete", "Subscribers",new { Id="__prm_id__" }), 2265, 60, false);

#line default
#line hidden
            WriteAttributeValue("", 2325, "\');", 2325, 3, true);
            EndWriteAttribute();
            BeginContext(2329, 168, true);
            WriteLiteral(" class=\"dropdown-item\"><i class=\"icon-x\"></i> Delete</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2514, 288, true);
                WriteLiteral(@"
    <script>
        $('#dashBoard').removeClass(""active"");
        $('#subscriber').removeClass(""active"");
        $('#newsLetter').removeClass(""active"");
        $('#scheduledNewsLetters').removeClass(""active"");
        $('#subscriber').addClass(""active"");
    </script>

    ");
                EndContext();
                BeginContext(2802, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af32ea9376f49c530fea110ce17a40bf4ddc0a429308", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2889, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2897, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af32ea9376f49c530fea110ce17a40bf4ddc0a4210568", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3012, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3147, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3153, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af32ea9376f49c530fea110ce17a40bf4ddc0a4211940", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3215, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
