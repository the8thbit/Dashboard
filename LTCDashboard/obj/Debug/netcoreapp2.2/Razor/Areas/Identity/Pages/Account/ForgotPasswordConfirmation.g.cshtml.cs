#pragma checksum "F:\LTCDashboard\LTCDashboard\LTCDashboard\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cea78530acf43bfa66b3582f9aff70eb81b56ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LTCDashboard.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml", typeof(LTCDashboard.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), null)]
namespace LTCDashboard.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Areas\Identity\Pages\_ViewImports.cshtml"
using LTCDashboard.Areas.Identity;

#line default
#line hidden
#line 3 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Areas\Identity\Pages\_ViewImports.cshtml"
using LTCDashboard.Data;

#line default
#line hidden
#line 1 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using LTCDashboard.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cea78530acf43bfa66b3582f9aff70eb81b56ee", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d01653d2a149e57cbb0b2bfd41601cd0f447b20", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b36681b765d5dced233fa62c163a1d03cb6bd873", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\LTCDashboard\LTCDashboard\LTCDashboard\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";
    Layout = "~/Views/Shared/Layouts/_loginLayout.cshtml";

#line default
#line hidden
            BeginContext(166, 1124, true);
            WriteLiteral(@"

<div class=""page-content login-coverFix"">
    <!-- Main content -->
    <div class=""content-wrapper"">
        <div class=""content d-flex justify-content-center align-items-center"">
            <div class=""login-form wmin-sm-400"">
                <div class=""card mb-0"">
                    <div class=""tab-content card-body"">
                        <input type=""hidden"" name=""returnurl"" id=""returnurl"" value="""" />
                        <div class=""tab-pane fade show active"">
                            <div class=""text-center mb-3"">
                                <i class=""icon-reading icon-2x text-slate-300 border-slate-300 border-3 rounded-round p-3 mb-3 mt-1"" style=""color: green;""></i>
                                <h5 class=""mb-0"">Please check your email to reset your password.</h5>
                            </div>
                            <span class=""form-text text-center text-muted"">&copy; Logic Tech Corp. 2018. All rights reserved.</span>
                        </div>
      ");
            WriteLiteral("              </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591
