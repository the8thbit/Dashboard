#pragma checksum "C:\Users\Yasir\source\repos\LTCDashboard\LTCDashboard\Views\Shared\Footer\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85d3c76d8ce332f03d015e753419314e9497049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Footer__Footer), @"mvc.1.0.view", @"/Views/Shared/Footer/_Footer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Footer/_Footer.cshtml", typeof(AspNetCore.Views_Shared_Footer__Footer))]
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
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTCDashboard\Views\_ViewImports.cshtml"
using LTCDashboard;

#line default
#line hidden
#line 2 "C:\Users\Yasir\source\repos\LTCDashboard\LTCDashboard\Views\_ViewImports.cshtml"
using LTCDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85d3c76d8ce332f03d015e753419314e9497049", @"/Views/Shared/Footer/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cd85531b82a25b1d9f9c9f760a4e079ce716a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Footer__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTCDashboard\Views\Shared\Footer\_Footer.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 456, true);
            WriteLiteral(@"<div class=""navbar navbar-expand-lg navbar-light"">
    <div class=""text-center d-lg-none w-100"">
        <button type=""button"" class=""navbar-toggler dropdown-toggle"" data-toggle=""collapse"" data-target=""#navbar-footer"">
            <i class=""icon-unfold mr-2""></i>
            Footer
        </button>
    </div>

    <div class=""navbar-collapse collapse"" id=""navbar-footer"">
        <span class=""navbar-text"">
            &copy; Logic Tech Corp. ");
            EndContext();
            BeginContext(484, 17, false);
#line 14 "C:\Users\Yasir\source\repos\LTCDashboard\LTCDashboard\Views\Shared\Footer\_Footer.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(501, 58, true);
            WriteLiteral(". All rights reserved\r\n        </span>\r\n    </div>\r\n</div>");
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
