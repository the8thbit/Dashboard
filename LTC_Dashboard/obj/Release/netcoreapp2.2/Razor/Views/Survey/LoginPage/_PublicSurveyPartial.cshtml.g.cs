#pragma checksum "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\LoginPage\_PublicSurveyPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aee71b391b55565748fc14ec3b0ca8f546722d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_LoginPage__PublicSurveyPartial), @"mvc.1.0.view", @"/Views/Survey/LoginPage/_PublicSurveyPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/LoginPage/_PublicSurveyPartial.cshtml", typeof(AspNetCore.Views_Survey_LoginPage__PublicSurveyPartial))]
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
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\LoginPage\_PublicSurveyPartial.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aee71b391b55565748fc14ec3b0ca8f546722d3", @"/Views/Survey/LoginPage/_PublicSurveyPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_LoginPage__PublicSurveyPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 24, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 105, "\"", 250, 2);
            WriteAttributeValue("", 112, "https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css?v=", 112, 75, true);
#line 4 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\LoginPage\_PublicSurveyPartial.cshtml"
WriteAttributeValue("", 187, Configuration.GetSection("Configuration")["staticFileVersion"], 187, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(251, 10, true);
            WriteLiteral(">\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 261, "\"", 406, 2);
            WriteAttributeValue("", 267, "https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js?v=", 267, 76, true);
#line 5 "C:\Users\Yasir\source\repos\LTCDashboard\LTC_Dashboard\Views\Survey\LoginPage\_PublicSurveyPartial.cshtml"
WriteAttributeValue("", 343, Configuration.GetSection("Configuration")["staticFileVersion"], 343, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(407, 3853, true);
            WriteLiteral(@"></script>


<div id=""PublicSurveyloginModal"" class=""modal fade"" tabindex=""-1"">
    <div class=""modal-dialog modal-full"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Public Survey</h5>

                <button id=""btnPublicSurveyToggle"" title=""Preview"" class=""btn btn-primary pull-right isPreviewHidden publicSurveyList"" onclick=""Layout.togglePreviewButton(this,'publicSurveyListToggleParent')""><span class=""fa fa-eye""></span></button>
                <button id=""publicSurveyCreateNew"" type=""button"" class=""btn btn-success margin-right-5 pull-right titleButtonsDefault publicSurveyList"" onclick=""PublicSurveyControls.createNewForm();"">Create New Survey</button>
                <button id=""btnSavePublicFormBottom"" type=""button"" class=""btn btn-success margin-right-5 pull-right publicSurveyCreate"" onclick=""PublicSurveyControls.saveSurveyDesign();"">Save</button>
                <button type=""button"" class=""btn btn-primary margin-right-5 p");
            WriteLiteral(@"ull-right publicSurveyCreate"" onclick=""PublicSurveyControls.showSurveyList();"">Cancel</button>
                <input type=""text"" name=""txtsurveyname"" id=""txtPublicsurveyname"" class=""form-control pull-right textboxMinWidth publicSurveyCreate"" placeholder=""Survey Name"" value="""" />

                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""PublicSurveyControls.showSurveyList();"">&times;</button>
            </div>
            <div class=""modal-body"">
                <div class=""row publicSurveyList"">
                    <div class=""col-md-12"">
                        <div class=""block-content"">
                            <div id=""publicSurveyListToggleParent"" class=""row toggleDivParent toggleDivHidden"">
                                <div class=""panel-left col-lg-12 col-md-12 col-sm-12 col-xs-12 minTableSize"">
                                    <table id=""tblPublicSurvey"" class=""table datatable-basic table-striped datatable-extended"">
                                      ");
            WriteLiteral(@"  <thead>
                                            <tr>
                                                <th>ID</th>
                                                <th>Description</th>
                                                <th>Action</th>
                                            </tr>
                                        </thead>
                                    </table>
                                </div>

                                <div class=""splitter"">
                                </div>
                                <div class=""panel-right toogleDivMain"">
                                    <div class=""toogleDivTitle"">
                                        <h2>
                                            preview
                                        </h2>
                                    </div>
                                    <div class=""toogleDivContent"">
                                        <iframe id=""iframePreviewPublicSurvey""></ifra");
            WriteLiteral(@"me>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""publicSurveyCreate"" style=""display:none;"">
                    <input type=""hidden"" name=""hdPublicsid"" id=""hdsPublicid"" value=""-1"" />
                    <div class=""row toggleDivParent"">
                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                            <div id=""fbPublicSurvey-editor""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">

            </div>
        </div>
    </div>
</div>


");
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
