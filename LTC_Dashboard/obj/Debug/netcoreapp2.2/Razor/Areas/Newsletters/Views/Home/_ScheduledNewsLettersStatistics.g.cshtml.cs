#pragma checksum "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7e5d0f11fbd27ccc2f1665d5dc0035337ec9de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Newsletters_Views_Home__ScheduledNewsLettersStatistics), @"mvc.1.0.view", @"/Areas/Newsletters/Views/Home/_ScheduledNewsLettersStatistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Newsletters/Views/Home/_ScheduledNewsLettersStatistics.cshtml", typeof(AspNetCore.Areas_Newsletters_Views_Home__ScheduledNewsLettersStatistics))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7e5d0f11fbd27ccc2f1665d5dc0035337ec9de", @"/Areas/Newsletters/Views/Home/_ScheduledNewsLettersStatistics.cshtml")]
    public class Areas_Newsletters_Views_Home__ScheduledNewsLettersStatistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LTCDataModel.Newsletter.ScheduledNewsLetterStatisticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 498, true);
            WriteLiteral(@"
<div class=""row number-stats margin-bottom-30"">
    <div class=""col-md-6 col-sm-6 col-xs-6"">
        <div class=""stat-left"">
            <div class=""stat-chart"">
                <!-- do not line break ""sparkline_bar"" div. sparkline chart has an issue when the container div has line break -->
                <div id=""sparkline_bar""></div>
            </div>
            <div class=""stat-number"">
                <div class=""title""> Scheduled </div>
                <div class=""number""> ");
            EndContext();
            BeginContext(570, 15, false);
#line 12 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
                                Write(Model.Scheduled);

#line default
#line hidden
            EndContext();
            BeginContext(585, 501, true);
            WriteLiteral(@" </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-sm-6 col-xs-6"">
        <div class=""stat-right"">
            <div class=""stat-chart"">
                <!-- do not line break ""sparkline_bar"" div. sparkline chart has an issue when the container div has line break -->
                <div id=""sparkline_bar2""></div>
            </div>
            <div class=""stat-number"">
                <div class=""title""> Sent </div>
                <div class=""number""> ");
            EndContext();
            BeginContext(1087, 10, false);
#line 24 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
                                Write(Model.Sent);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 462, true);
            WriteLiteral(@" </div>
            </div>
        </div>
    </div>
</div>
<div class=""table-scrollable table-scrollable-borderless homeNewsletterTable"" style=""max-height: 650px !important "">
    <table class=""table table-hover table-light"">
        <thead>
            <tr class=""uppercase"">

                <th> Title </th>
                <th> Date </th>
                <th> Email </th>
                <th> Status </th>
            </tr>
        </thead>
");
            EndContext();
#line 40 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
      if (Model.ScheduledNewsLetter != null)
        {
            foreach (var item in Model.ScheduledNewsLetter)
            {

#line default
#line hidden
            BeginContext(1692, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1739, 10, false);
#line 45 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1749, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1781, 19, false);
#line 46 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
                   Write(item.SentTimeString);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1832, 10, false);
#line 47 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1874, 11, false);
#line 48 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
                   Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 50 "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Home\_ScheduledNewsLettersStatistics.cshtml"
            }
        } 

#line default
#line hidden
            BeginContext(1942, 28, true);
            WriteLiteral("\r\n\r\n\r\n    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LTCDataModel.Newsletter.ScheduledNewsLetterStatisticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591