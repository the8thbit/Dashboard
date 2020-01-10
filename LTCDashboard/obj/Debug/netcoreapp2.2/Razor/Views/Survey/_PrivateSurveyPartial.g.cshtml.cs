#pragma checksum "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\Survey\_PrivateSurveyPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8582688fbfb6082b6755c22be63499cebc44efb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey__PrivateSurveyPartial), @"mvc.1.0.view", @"/Views/Survey/_PrivateSurveyPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/_PrivateSurveyPartial.cshtml", typeof(AspNetCore.Views_Survey__PrivateSurveyPartial))]
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
#line 1 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\_ViewImports.cshtml"
using LTCDashboard;

#line default
#line hidden
#line 2 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\_ViewImports.cshtml"
using LTCDashboard.Models;

#line default
#line hidden
#line 1 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\Survey\_PrivateSurveyPartial.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8582688fbfb6082b6755c22be63499cebc44efb7", @"/Views/Survey/_PrivateSurveyPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey__PrivateSurveyPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 24, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 105, "\"", 250, 2);
            WriteAttributeValue("", 112, "https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css?v=", 112, 75, true);
#line 4 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\Survey\_PrivateSurveyPartial.cshtml"
WriteAttributeValue("", 187, Configuration.GetSection("Configuration")["staticFileVersion"], 187, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(251, 12, true);
            WriteLiteral(">\r\n\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 263, "\"", 408, 2);
            WriteAttributeValue("", 269, "https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js?v=", 269, 76, true);
#line 6 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\Survey\_PrivateSurveyPartial.cshtml"
WriteAttributeValue("", 345, Configuration.GetSection("Configuration")["staticFileVersion"], 345, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(409, 5928, true);
            WriteLiteral(@"></script>



<div id=""divSurveyList"" class=""row card"">
    <div class=""col-md-12"">
        <div class=""block block-condensed noWhite"">
            <div class=""block-content"">
                <div class=""row row-margin"">
                    <div class=""col-lg-12 col-md-12"">
                        <button id=""btnPrivateSurveyToogle"" title=""Preview"" class=""btn btn-primary pull-right isPreviewHidden"" onclick=""Layout.togglePreviewButton(this,'privateSurveyListToggleParent')"">
                            <span class=""fa fa-eye""></span>
                        </button>
                        <button id=""btnPrivateSurveyCreateNew"" type=""button"" class=""btn btn-success margin-right-55 pull-right titleButtonsDefault"" onclick=""SurveyControls.createNewForm();"">Create New Survey</button>
                        <button id=""btnPrivateSurveyShowTemplates"" type=""button"" class=""btn btn-success margin-right-5 pull-right titleButtonsDefault"" data-toggle=""modal"" data-target=""#publicSurveyModal"" onclick=""SurveyCo");
            WriteLiteral(@"ntrols.showPublicTemplates();"">Show Templates</button>
                    </div>
                </div>
                <div id=""privateSurveyListToggleParent"" class=""row toggleDivParent toggleDivHidden"">
                    <div class=""panel-left col-lg-12 col-md-12 col-sm-12 col-xs-12 "">
                        <table id=""tblPrivateSurveyForms"" class=""table datatable-basic table-striped datatable-extended"">
                            <thead>
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
         ");
            WriteLiteral(@"                       preview
                            </h2>
                        </div>
                        <div class=""toogleDivContent"">
                            <iframe id=""iframePreviewPrivateSurvey""></iframe>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row card"" id=""divSurveyDesigner"" style=""display:none;"">
    <div class=""col-lg-12 col-md-12"">
        <div class=""row row-margin"">
            <div class=""col-md-9"">
                <input type=""hidden"" name=""hdsid"" id=""hdsid"" value=""-1"" />
                <input type=""text"" name=""txtsurveyname"" id=""txtsurveyname"" class=""form-control pull-left"" placeholder=""Survey Name"" value="""" />
            </div>
            <div class=""col-md-3"">
                <button type=""button"" class=""btn btn-primary margin-right-5 pull-left"" onclick=""SurveyControls.showSurveyList();"">Cancel</button>
                <button id=""btnSaveFormBot");
            WriteLiteral(@"tom"" type=""button"" class=""btn btn-success margin-right-5 pull-left "" onclick=""SurveyControls.saveSurveyDesign();"">Save</button>
            </div>
        </div>
        <div class=""row toggleDivParent toggleDivHidden"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div id=""fb-editor""></div>
            </div>
        </div>

    </div>
</div>

<div class=""modal fade"" id=""publicSurveyModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modal-default-header"" data-backdrop=""static"" data-keyboard=""false"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content block minModelSize"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""modal-default-header"">Rendering View</h4>
                <div class=""pull-right"">
                    <button id=""btnPrivateSurveySelectionPublicToggle"" title=""Preview"" class=""btn btn-primary pull-right isPreviewHidden"" onclick=""Layout.togglePreviewButton(this,'privat");
            WriteLiteral(@"eSurveySelectionPublicToggleParent')"">
                        <span class=""fa fa-eye""></span>
                    </button>

                    <button id=""btnPrivateSurveySelectionPublicDuplicate"" type=""button"" class=""btn btn-success margin-right-5 pull-right titleButtons"" onclick=""SurveyControls.duplicatePublicForm();"">Duplicate Survey</button>
                </div>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <div id=""privateSurveySelectionPublicToggleParent"" class=""row toggleDivParent toggleDivHidden"">
                    <div class=""panel-left col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                        <table id=""tblPublicSurveyForms"" class=""table table-striped table-bordered datatable-extended"">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Name</th>
");
            WriteLiteral(@"                                    <th>Action</th>
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
                            <iframe id=""iframePreviewPrivateSurveyPublicList""></iframe>
                        </div>
                    </div>
                </div>
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
