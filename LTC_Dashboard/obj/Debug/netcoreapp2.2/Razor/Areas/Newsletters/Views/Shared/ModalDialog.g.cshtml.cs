#pragma checksum "F:\LTC Git\Dashboard\LTC_Dashboard\Areas\Newsletters\Views\Shared\ModalDialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb4d5507db921701a6f1132fa1494c498a9486f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Newsletters_Views_Shared_ModalDialog), @"mvc.1.0.view", @"/Areas/Newsletters/Views/Shared/ModalDialog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Newsletters/Views/Shared/ModalDialog.cshtml", typeof(AspNetCore.Areas_Newsletters_Views_Shared_ModalDialog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb4d5507db921701a6f1132fa1494c498a9486f", @"/Areas/Newsletters/Views/Shared/ModalDialog.cshtml")]
    public class Areas_Newsletters_Views_Shared_ModalDialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 768, true);
            WriteLiteral(@"<style>
    .modal-body {
        display: block;
        overflow: auto;
    }
</style>

<div id=""modal-window"" style=""display:none;"" class=""modal fade"">
    <div class=""modal-dialog"" style=""width: 50%;"">
        <div class=""modal-content"">
            <div class=""modal-header btn-primary"">
                <h4 class=""modal-title""></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
            </div>
            <div class=""modal-body"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btn-close"" class=""btn btn-danger"">Close</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
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