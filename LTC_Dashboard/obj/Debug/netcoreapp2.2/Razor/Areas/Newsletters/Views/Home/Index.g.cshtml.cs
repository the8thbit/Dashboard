#pragma checksum "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d266edd520af379fb4b1070705dbdabf6c5e701e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Newsletters_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Newsletters/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Newsletters/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Newsletters_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d266edd520af379fb4b1070705dbdabf6c5e701e", @"/Areas/Newsletters/Views/Home/Index.cshtml")]
    public class Areas_Newsletters_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/ScriptsView/Home.js?version=9"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Newsletters/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(106, 1633, true);
            WriteLiteral(@"




<style>
    .number-stats .stat-number .number {
        font-size: 27px;
        line-height: 27px;
        color: #7D8C9D;
    }

    .number-stats .stat-left, .number-stats .stat-left .stat-chart {
        float: right;
    }

    .number-stats .stat-number .title {
        font-size: 13px;
        margin-bottom: 3px;
        color: #B8C3C7;
    }

    .number-stats .stat-left, .number-stats .stat-left .stat-chart {
        float: right;
    }

    .number-stats .stat-chart {
        display: inline-block;
        margin: 0 5px;
        float: left;
    }

    .table.table-light > thead > tr > th {
        font-weight: 600;
        font-size: 13px;
        color: #93a2a9;
        border: 0;
        border-bottom: 1px solid #F2F5F8;
    }
</style>




<div class=""content"">

    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header bg-white header-elements-inline"">
                    <h6");
            WriteLiteral(@" class=""card-title font-variant-smallCaps""></h6>
                    <div class=""header-elements"">
                        <div class=""list-icons"">
                            <a class=""list-icons-item"" data-action=""collapse""></a>

                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""row"">

                                <div class=""col-md-6 col-sm6"">
                                    Category  ");
            EndContext();
            BeginContext(1740, 278, false);
#line 71 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\Index.cshtml"
                                         Write(Html.DropDownList("Status", new List<SelectListItem>{
new SelectListItem{ Text="All", Value="All"},
new SelectListItem{ Text="Scheduled", Value="Scheduled"},
new SelectListItem{ Text="Sent", Value="Sent"}
}, new { @class = "form-control input-sm homeNewsletterDropdown" }
));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 153, true);
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"col-md-6 col-sm6\">\r\n\r\n                                    Period ");
            EndContext();
            BeginContext(2172, 350, false);
#line 81 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\Index.cshtml"
                                      Write(Html.DropDownList("Period", new List<SelectListItem>{
new SelectListItem{ Text="Today", Value="Today"},
new SelectListItem{ Text="This Week", Value="ThisWeek"},
new SelectListItem{ Text="Last Week", Value="LastWeek"},
new SelectListItem{ Text="This Month", Value="ThisMonth"}
}, new { @class = "form-control input-sm homeNewsletterDropdown" }
));

#line default
#line hidden
            EndContext();
            BeginContext(2522, 380, true);
            WriteLiteral(@"
                                </div>

                            </div>
                            <div id=""scheduledNewsletterContainer""  >
                                 
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

    </div>






</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2919, 289, true);
                WriteLiteral(@"
    <script>
        $('#dashBoard').removeClass(""active"");
        $('#subscriber').removeClass(""active"");
        $('#newsLetter').removeClass(""active"");
        $('#scheduledNewsLetters').removeClass(""active"");
        $('#dashBoard').addClass(""active"");
    </script>


    ");
                EndContext();
                BeginContext(3208, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d266edd520af379fb4b1070705dbdabf6c5e701e7578", async() => {
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
                BeginContext(3271, 4, true);
                WriteLiteral("\r\n\r\n");
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