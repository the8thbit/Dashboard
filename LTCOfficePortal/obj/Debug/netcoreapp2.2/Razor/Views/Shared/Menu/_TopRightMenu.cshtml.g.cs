#pragma checksum "C:\Users\Yasir\source\repos\LTCDashboard\LTCOfficePortal\Views\Shared\Menu\_TopRightMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bb9d53a3ca2a3b67639ba53012d2b4048c520cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Menu__TopRightMenu), @"mvc.1.0.view", @"/Views/Shared/Menu/_TopRightMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Menu/_TopRightMenu.cshtml", typeof(AspNetCore.Views_Shared_Menu__TopRightMenu))]
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
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTCOfficePortal\Views\_ViewImports.cshtml"
using LTCOfficePortal;

#line default
#line hidden
#line 2 "C:\Users\Yasir\source\repos\LTCDashboard\LTCOfficePortal\Views\_ViewImports.cshtml"
using LTCOfficePortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb9d53a3ca2a3b67639ba53012d2b4048c520cf", @"/Views/Shared/Menu/_TopRightMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fa387cf9a6468341429476b2066ddf7cb96e685", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Menu__TopRightMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Yasir\source\repos\LTCDashboard\LTCOfficePortal\Views\Shared\Menu\_TopRightMenu.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 245, true);
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n    <li class=\"nav-item dropdown dropdown-user\">\r\n        <a href=\"#\" class=\"navbar-nav-link d-flex align-items-center dropdown-toggle\" data-toggle=\"dropdown\">\r\n            <i class=\"icon-user\"></i>\r\n            <span>");
            EndContext();
            BeginContext(273, 18, false);
#line 9 "C:\Users\Yasir\source\repos\LTCDashboard\LTCOfficePortal\Views\Shared\Menu\_TopRightMenu.cshtml"
             Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(291, 443, true);
            WriteLiteral(@"</span>
        </a>
        <div class=""dropdown-menu dropdown-menu-right"">
            <a href=""#"" data-toggle=""modal"" data-target=""#userprofileModal"" class=""dropdown-item""><i class=""icon-user-plus""></i> User Profile</a>
            <a href=""#"" data-toggle=""modal"" data-target=""#changePasswordModal"" class=""dropdown-item""><i class=""icon-envelope""></i> Change Password</a>
            <div class=""dropdown-divider""></div>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 734, "\"", 772, 1);
#line 15 "C:\Users\Yasir\source\repos\LTCDashboard\LTCOfficePortal\Views\Shared\Menu\_TopRightMenu.cshtml"
WriteAttributeValue("", 741, Url.Action("Logout","Account"), 741, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(773, 62, true);
            WriteLiteral(" class=\"dropdown-item\"><i class=\"icon-users\"></i> Logout</a>\r\n");
            EndContext();
            BeginContext(1017, 32, true);
            WriteLiteral("        </div>\r\n    </li>\r\n</ul>");
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
