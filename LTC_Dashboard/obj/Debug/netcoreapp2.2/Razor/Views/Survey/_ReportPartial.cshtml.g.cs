#pragma checksum "/Users/myasirnawaz/Documents/Projects/Dashboard/LTC_Dashboard/Views/Survey/_ReportPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94852e8a4340c2e2111f1b9e1a601bf466f390db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey__ReportPartial), @"mvc.1.0.view", @"/Views/Survey/_ReportPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/_ReportPartial.cshtml", typeof(AspNetCore.Views_Survey__ReportPartial))]
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
#line 1 "/Users/myasirnawaz/Documents/Projects/Dashboard/LTC_Dashboard/Views/_ViewImports.cshtml"
using LTCDashboard;

#line default
#line hidden
#line 2 "/Users/myasirnawaz/Documents/Projects/Dashboard/LTC_Dashboard/Views/_ViewImports.cshtml"
using LTCDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94852e8a4340c2e2111f1b9e1a601bf466f390db", @"/Views/Survey/_ReportPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2166ac7352159f215a0ab09cb8ee87cb308f596e", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey__ReportPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 635, true);
            WriteLiteral(@"<div id=""divReportList"" class=""row card"">
    <div class=""col-md-12"">
        <div class=""block block-condensed noWhite"">
            <div class=""block-content"">
                <table id=""tblSurveyReportForms"" class=""table table-striped table-bordered datatable-extended"">
                    <thead>
                    <tr>
                        <th>ID</th>
                        <th>Survey Description</th>
                        <th>Survey Provided</th>
                        <th>Action</th>
                    </tr>
                    </thead>
                </table>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591