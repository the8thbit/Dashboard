#pragma checksum "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\NewsLetter\LoginPage\_PreDefinedNewsLetterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af10c0859548cca7fe708be5ebb0cb57b0528611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsLetter_LoginPage__PreDefinedNewsLetterPartial), @"mvc.1.0.view", @"/Views/NewsLetter/LoginPage/_PreDefinedNewsLetterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewsLetter/LoginPage/_PreDefinedNewsLetterPartial.cshtml", typeof(AspNetCore.Views_NewsLetter_LoginPage__PreDefinedNewsLetterPartial))]
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
#line 1 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\NewsLetter\LoginPage\_PreDefinedNewsLetterPartial.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af10c0859548cca7fe708be5ebb0cb57b0528611", @"/Views/NewsLetter/LoginPage/_PreDefinedNewsLetterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsLetter_LoginPage__PreDefinedNewsLetterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 24, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 105, "\"", 250, 2);
            WriteAttributeValue("", 112, "https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css?v=", 112, 75, true);
#line 4 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\NewsLetter\LoginPage\_PreDefinedNewsLetterPartial.cshtml"
WriteAttributeValue("", 187, Configuration.GetSection("Configuration")["staticFileVersion"], 187, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(251, 12, true);
            WriteLiteral(">\r\n\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 263, "\"", 408, 2);
            WriteAttributeValue("", 269, "https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js?v=", 269, 76, true);
#line 6 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Views\NewsLetter\LoginPage\_PreDefinedNewsLetterPartial.cshtml"
WriteAttributeValue("", 345, Configuration.GetSection("Configuration")["staticFileVersion"], 345, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(409, 814, true);
            WriteLiteral(@"></script>

<div id=""PreDefinedNewsLetter"" class=""modal fade"" tabindex=""-1"" data-backdrop=""static"" data-keyboard=""false"">
    <div class=""modal-dialog modal-full"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Public Newsletters</h5>

                <button id=""btnPredefinedNewsLetterSelectionToggle"" title=""Preview"" class=""btn btn-primary pull-right isPreviewHidden"" onclick=""Layout.togglePreviewButton(this,'predefinedNewsletterSelectionList')"">
                    <span class=""fa fa-eye""></span>
                </button>
                <select id=""ddlNewsLetterIndustries"" class=""bs-select form-control pull-right newsletter-industry-ddl"" onchange=""PreNewsLetterControls.searchPredifinedNLOnIndustry();"">
                    ");
            EndContext();
            BeginContext(1223, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af10c0859548cca7fe708be5ebb0cb57b05286115984", async() => {
                BeginContext(1241, 14, true);
                WriteLiteral("All Industries");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1264, 2048, true);
            WriteLiteral(@"
                </select>

                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""block-content"">
                            <div id=""predefinedNewsletterSelectionList"" class=""row toggleDivParent toggleDivHidden"">
                                <div class=""panel-left col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <table id=""tblPrivateNewsLetterForms"" class=""table datatable-basic table-striped datatable-extended"">
                                        <thead>
                                            <tr>
                                                <th>ID</th>
                                                <th>Description</th>
                                                <th>Action</th>
                                            </tr>
          ");
            WriteLiteral(@"                              </thead>
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
                                        <iframe id=""previewPreNewsLetter""></iframe>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">

            </div>
        </div>
    </div>
</div>");
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
