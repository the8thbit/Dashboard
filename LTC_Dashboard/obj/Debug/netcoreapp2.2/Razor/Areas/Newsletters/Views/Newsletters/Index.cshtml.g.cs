#pragma checksum "/Users/myasirnawaz/Documents/Projects/Dashboard/LTC_Dashboard/Areas/Newsletters/Views/Newsletters/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3a833e762a278c867e14a3d11efb46545209f7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Newsletters_Views_Newsletters_Index), @"mvc.1.0.view", @"/Areas/Newsletters/Views/Newsletters/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Newsletters/Views/Newsletters/Index.cshtml", typeof(AspNetCore.Areas_Newsletters_Views_Newsletters_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3a833e762a278c867e14a3d11efb46545209f7c", @"/Areas/Newsletters/Views/Newsletters/Index.cshtml")]
    public class Areas_Newsletters_Views_Newsletters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/kendo/styles/kendo.common.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/kendo/styles/kendo.default.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/kendo/styles/kendo.default.mobile.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/ScriptsView/Newsletter.js?version=10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/kendo/js/kendo.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/myasirnawaz/Documents/Projects/Dashboard/LTC_Dashboard/Areas/Newsletters/Views/Newsletters/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Newsletters/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(100, 479, true);
            WriteLiteral(@"
 
<style>
    #tblParadigm_filter, #tblParadigm_info, #tblMarketing_filter, #tblMarketing_info {
        display: none;
    }
    .dotted, .k-in {
        white-space: nowrap;
        width: 180px;
        overflow: hidden;
        text-overflow: ellipsis;
    }

    .contentSpace {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

        .contentSpace::before, .contentSpace::after {
            width: 130px;
        }

    ");
            EndContext();
            BeginContext(580, 200, true);
            WriteLiteral("@media (min-width: 768px) {\n        .seven-cols .col-md-1,\n        .seven-cols .col-sm-1,\n        .seven-cols .col-lg-1 {\n            width: 100%;\n            text-align: center;\n        }\n    }\n\n    ");
            EndContext();
            BeginContext(781, 229, true);
            WriteLiteral("@media (min-width: 576px) {\n        .seven-cols .col-md-1,\n        .seven-cols .col-sm-1,\n        .seven-cols .col-lg-1 {\n            -ms-flex: 0 0 30%;\n            flex: 0 0 30%;\n            max-width: 30%;\n        }\n    }\n\n    ");
            EndContext();
            BeginContext(1011, 261, true);
            WriteLiteral(@"@media (min-width: 992px) {
        .seven-cols .col-md-1,
        .seven-cols .col-sm-1,
        .seven-cols .col-lg-1 {
            -ms-flex: 0 0 30%;
            flex: 0 0 30%;
            max-width: 30%;
            text-align: center;
        }
    }

    ");
            EndContext();
            BeginContext(1273, 10745, true);
            WriteLiteral(@"@media (min-width: 1200px) {
        .seven-cols .col-md-1,
        .seven-cols .col-sm-1,
        .seven-cols .col-lg-1 {
            -ms-flex: 0 0 14.2857%;
            flex: 0 0 14.2857%;
            max-width: 14.2857%;
            text-align: center;
        }
    }

    .transparentBg {
        background-color: transparent;
    }

    .icon-checkmark-circle {
        margin-left: 1rem;
    }

    .truncate {
        white-space: nowrap;
        width: 185px;
        overflow: hidden;
        text-overflow: ellipsis;
        font-size: 12px;
    }

    .card-title {
        font-size: 15px !important;
    }

    .btn {
        font-size: 14px;
    }

    .dropdown-menu {
        font-size: 14px;
    }

    body {
        font-size: 13px !important;
    }
</style>


<div class=""content"">
    <div class=""row"">
        <div class=""card"" style=""width:100%"">
            <div class=""card-header bg-white header-elements-inline"">
                <h6 class=""card-title""></h6>
                <div class=""header-el");
            WriteLiteral(@"ements"">
                    <div class=""list-icons"">
                        <input id=""txtSearch"" onkeyup=""Newsletter.Search();"" class=""form-control"" placeholder=""Search ..."" />
                        <button type=""button"" id=""btnSelectOptions"" class=""btn btn-primary"" onclick=""Newsletter.userDefinedOptionChanged('create');"">Create New Template</button>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div id=""templateList"" class=""m-heading-1 border-green m-bordered"">

                            <ul class=""nav nav-tabs nav-tabs-top"">
                                <li class=""nav-item""><a href=""#userDefinedTemplatesTab"" onclick=""javascript:Newsletter.clearTabSelection('user');"" class=""nav-link active"" data-toggle=""tab"">My Paradigm Templates</a></li>
                                <li class=""nav-item""><a href=""#marketingTemplatesTab"" onclick=""javascri");
            WriteLiteral(@"pt:Newsletter.clearTabSelection('marketing');"" class=""nav-link"" data-toggle=""tab"">My Marketing Templates</a></li>
                                <li class=""nav-item""><a href=""#SystemTemplatesTab"" onclick=""javascript:Newsletter.clearTabSelection('system');"" class=""nav-link"" data-toggle=""tab""> Library</a></li>
                                <li class=""nav-item""><a href=""#SystemArticlesTab"" onclick=""javascript:Newsletter.clearTabSelection('article');"" class=""nav-link"" data-toggle=""tab""> Articles</a></li>

                            </ul>
                            <div class=""tab-content card"">
                                <div class=""tab-pane fade tiles fade show active"" id=""userDefinedTemplatesTab"">
                                    <div class=""col-lg-2 moveToTopRight"">

                                    </div>
                                    <div id=""userDefineTemplateList"">
                                        <div class=""card-body"" style=""margin-left: 50px;margin-right: 50px;"">
           ");
            WriteLiteral(@"                                 <div class=""row"">
                                                <div class=""col-md-1"" style=""margin-top: 10px;"">
                                                    <label>Category: </label>
                                                </div>
                                                <div class=""col-md-4"">
                                                    <select id=""ddlTemplatesTypes1"" class=""form-control"" onchange=""Newsletter.ddlTemplatesTypes1_OnChange()""></select>
                                                </div>

                                            </div>
                                             
                                            <table class=""table datatable-basic"" id=""tblParadigm"">
                                                <thead>
                                                    <tr>
                                                        <th>Name</th>
                                                        <th>Category</");
            WriteLiteral(@"th>
                                                        <th>Default</th>
                                                        <th>Modification Date</th>
                                                        <th class=""text-center"">Actions</th>
                                                    </tr>
                                                </thead>
                                                <tbody id=""tblBody""></tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                                <div class=""tab-pane tiles horizontalScrollOnExpand"" id=""SystemTemplatesTab"">
                                    <div class=""col-lg-2 moveToTopRight"">

                                    </div>
                                    <div id=""SystemTemplateList"">
                                        <div class=""card-body"" style=""margin-left: 50px;margin-right: 5");
            WriteLiteral(@"0px;"">
                                            <table class=""table datatable""  id=""tblSystem"">
                                                <thead>
                                                    <tr>
                                                        <th>Name</th>
                                                        <th style=""display: none"">Category</th>
                                                        <th>Modification Date</th>

                                                        <th class=""text-center"">Actions</th>
                                                    </tr>
                                                </thead>
                                                <tbody id=""tblBodySystem""></tbody>
                                            </table>
                                        </div>

                                    </div>
                                </div>
                                <div class=""tab-pane tiles horizontalScrollOnExpand"" id=");
            WriteLiteral(@"""marketingTemplatesTab"">
                                    <div class=""col-lg-2 moveToTopRight"">

                                    </div>
                                    <div id=""marketingTemplateList"">
                                        <div class=""card-body"" style=""margin-left: 50px;margin-right: 50px;"">

                                            <table class=""table datatable-basic""  id=""tblMarketing"">
                                                <thead>
                                                    <tr>
                                                        <th>Name</th>
                                                        <th>Modification Date</th>

                                                        <th class=""text-center"">Actions</th>
                                                    </tr>
                                                </thead>
                                                <tbody id=""tblBodyMarketing""></tbody>
                                       ");
            WriteLiteral(@"     </table>
                                        </div>

                                        <!-- /basic datatable -->


                                    </div>
                                </div>
                                <div class=""tab-pane tiles horizontalScrollOnExpand"" id=""SystemArticlesTab"">
                                    <div class=""col-lg-2 moveToTopRight"">

                                    </div>
                                    <div id=""SystemArticlesTabList"">
                                        <div class=""card-body"" style=""margin-left: 50px;margin-right: 50px;"">
                                            <table class=""table datatable-basic""  id=""tblArticle"">
                                                <thead>
                                                    <tr>
                                                        <th>Name</th>
                                                        <th>Modification Date</th>

                                        ");
            WriteLiteral(@"                <th class=""text-center"">Actions</th>
                                                    </tr>
                                                </thead>
                                                <tbody id=""tblBodyArticle""></tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>


                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <div id=""previewNewsletterModel"" class=""modal fade"" tabindex=""-1"" data-width=""600"" data-keyboard=""false"" role=""dialog"" aria-labelledby=""previewNewsletterModel"" aria-hidden=""true"" data-backdrop=""static"">

        <div class=""modal-dialog  modal-full"">
            <div class=""modal-content"">
                <div class=""modal-header btn-primary"" style=""padding-bottom: 10px"">
                    <h4 class=""modal-title"">Pr");
            WriteLiteral(@"eview</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                </div>

                <div class=""modal-body"" style=""height: calc(100vh - 200px);overflow: hidden;"">


                    <iframe id=""previewContent"" class=""hide""></iframe>



                </div>
                <div class=""modal-footer"">
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-primary"">Close</button>
                </div>

            </div>
        </div>
    </div>
    <div id=""previewArticleModel"" class=""modal fade"" tabindex=""-1"" data-width=""600"" data-keyboard=""false"" role=""dialog"" aria-labelledby=""previewArticleModel"" aria-hidden=""true"" data-backdrop=""static"">

        <div class=""modal-dialog  modal-full"">
            <div class=""modal-content"">
                <div class=""modal-header btn-primary"" style=""padding-bottom: 10px"">
                    <h4 class=""modal-title"">Preview</h4>
                    <button type=""button"" cla");
            WriteLiteral(@"ss=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                </div>

                <div class=""modal-body"" style=""height: calc(100vh - 200px);overflow: hidden;"">


                    <iframe id=""previewArticleContent"" class=""hide""></iframe>



                </div>
                <div class=""modal-footer"">
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-primary"">Close</button>
                </div>

            </div>
        </div>
    </div>

    ");
            EndContext();
            BeginContext(12019, 76, false);
#line 288 "/Users/myasirnawaz/Documents/Projects/Dashboard/LTC_Dashboard/Areas/Newsletters/Views/Newsletters/Index.cshtml"
Write(Html.Partial("~/Areas/Newsletters/Views/Newsletters/_EditNewsletter.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(12095, 210, true);
            WriteLiteral("\n    <div id=\"sendNewsletterModel\" class=\"modal fade\" tabindex=\"-1\" data-width=\"400\" data-keyboard=\"false\" role=\"dialog\" aria-labelledby=\"sendNewsletterModel\" aria-hidden=\"true\" data-backdrop=\"static\">\n        ");
            EndContext();
            BeginContext(12306, 76, false);
#line 290 "/Users/myasirnawaz/Documents/Projects/Dashboard/LTC_Dashboard/Areas/Newsletters/Views/Newsletters/Index.cshtml"
   Write(Html.Partial("~/Areas/Newsletters/Views/Newsletters/_SendNewsletter.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(12382, 984, true);
            WriteLiteral(@"
    </div>
    <div id=""previewNewsletterModel1"" class=""modal fade"" tabindex=""-1"" data-width=""600"" data-keyboard=""false"" role=""dialog"" aria-labelledby=""previewNewsletterModel1"" aria-hidden=""true"" data-backdrop=""static"">

        <div class=""modal-dialog  modal-full"">
            <div class=""modal-content"">
                <div class=""modal-header btn-primary"" style=""padding-bottom: 10px"">
                    <h4 class=""modal-title"">Preview</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                </div>

                <div class=""modal-body"" style="" height: calc(100vh - 200px);overflow: hidden;"">


                    <iframe id=""editorPreview""></iframe>



                </div>
                <div class=""modal-footer"">
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-primary"">Close</button>
                </div>

            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(13382, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(13388, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3a833e762a278c867e14a3d11efb46545209f7c20659", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13464, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(13469, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3a833e762a278c867e14a3d11efb46545209f7c21975", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13546, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(13551, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3a833e762a278c867e14a3d11efb46545209f7c23291", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13635, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(13639, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(13659, 651, true);
                WriteLiteral(@"
    <script>

        $('#dashBoard').removeClass(""active"");
        $('#subscriber').removeClass(""active"");
        $('#newsLetter').removeClass(""active"");
        $('#scheduledNewsLetters').removeClass(""active"");
        $('#newsLetter').addClass(""active"");

        
       
        $(window).bind(""load"", function() {
            $('#tblParadigm').DataTable({
                ""order"": [[3, ""desc""]],
                ""paging"":   false,
            });

            

            $('#tblMarketing').DataTable({
                ""order"": [[1, ""desc""]],
                ""paging"":   false,
            });


           

        });
    </script>

    ");
                EndContext();
                BeginContext(14310, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3a833e762a278c867e14a3d11efb46545209f7c25576", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14380, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(14385, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3a833e762a278c867e14a3d11efb46545209f7c26814", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14444, 262, true);
                WriteLiteral(@"
    <script id=""treeview-template"" type=""text/kendo-ui-template"">
        # if (!item.items) { #
        <a class='k-icon k-i-close-outline' onclick=""Newsletter.DeleteImage('#= item.text #');"" href='\#'></a>
        # } #
        #: item.text #
    </script>


");
                EndContext();
            }
            );
            BeginContext(14708, 4, true);
            WriteLiteral("\n\n\n\n");
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