#pragma checksum "F:\LTC Git\Dashboard\LTCOfficePortal\Views\Shared\_AppSidePanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42de274d0bc3df982a21a8321c14aae33a7093eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AppSidePanel), @"mvc.1.0.view", @"/Views/Shared/_AppSidePanel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AppSidePanel.cshtml", typeof(AspNetCore.Views_Shared__AppSidePanel))]
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
#line 1 "F:\LTC Git\Dashboard\LTCOfficePortal\Views\_ViewImports.cshtml"
using LTCOfficePortal;

#line default
#line hidden
#line 2 "F:\LTC Git\Dashboard\LTCOfficePortal\Views\_ViewImports.cshtml"
using LTCOfficePortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42de274d0bc3df982a21a8321c14aae33a7093eb", @"/Views/Shared/_AppSidePanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fa387cf9a6468341429476b2066ddf7cb96e685", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AppSidePanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 7213, true);
            WriteLiteral(@"<div class=""app-sidepanel scroll"" data-overlay=""show"">
    <div class=""container"">

        <div class=""app-heading app-heading-condensed app-heading-small padding-left-0"">
            <div class=""icon icon-lg"">
                <span class=""icon-alarm""></span>
            </div>
            <div class=""title"">
                <h2>Notifications</h2>
                <p><strong>7 new</strong>, latest: July 19, 2016 at 10:14:32.</p>
            </div>
        </div>

        <div class=""listing margin-bottom-10"">
            <div class=""listing-item margin-bottom-10"">
                <strong>Product Delivered</strong> <span class=""label label-success pull-right"">delivered</span>
                <p class=""margin-0 margin-top-5"">#SPW-955-18 to st. StreetName SA, USA.</p>
                <p class=""text-muted"">
                    <span class=""fa fa-truck margin-right-5""></span> 19/07/2016 10:14:32 AM
                </p>
            </div>
            <div class=""listing-item margin-bottom-10"">");
            WriteLiteral(@"
                <strong>Successful Payment</strong> <span class=""label label-success pull-right"">success</span>
                <p class=""margin-0 margin-top-5"">Payment for order #SPW-955-17: <strong>$145.44</strong>.</p>
                <p class=""text-muted"">
                    <span class=""fa fa-bank margin-right-5""></span> 19/07/2016 09:55:12 AM
                </p>
            </div>
            <div class=""listing-item margin-bottom-10"">
                <strong>New Order #SPW-955-17</strong> <span class=""label label-warning pull-right"">waiting</span>
                <p class=""margin-0 margin-top-5"">Added new order, waiting for payment. <a href=""#"">Order details</a>.</p>
                <p class=""text-muted"">
                    <span class=""fa fa-bank margin-right-5""></span> 19/07/2016 09:51:55 AM
                </p>
            </div>
            <div class=""listing-item margin-bottom-10"">
                <strong>Money Back Request</strong> <span class=""label label-primary pull-right"">r");
            WriteLiteral(@"eturn</span>
                <p class=""margin-0 margin-top-5"">#SPW-955-17 return requested. <a href=""#"">Request details</a>.</p>
                <p class=""text-muted"">
                    <span class=""fa fa-bank margin-right-5""></span> 19/07/2016 08:44:51 AM
                </p>
            </div>
            <div class=""listing-item margin-bottom-10"">
                <strong>The critical amount of product</strong> <span class=""label label-danger pull-right"">important</span>
                <p class=""margin-0 margin-top-5"">Product: <a href=""#"">Extra Awesome Product</a> (amount: <span class=""text-danger"">2</span>). <a href=""#"">Storehouse</a>.</p>
                <p class=""text-muted"">
                    <span class=""fa fa-cube margin-right-5""></span> 19/07/2016 08:30:00 AM
                </p>
            </div>
            <div class=""listing-item margin-bottom-10"">
                <strong>Product Delivery Start</strong> <span class=""label label-warning pull-right"">delivering</span>
          ");
            WriteLiteral(@"      <p class=""margin-0 margin-top-5"">#SPW-955-18 to st. StreetName SA, USA.</p>
                <p class=""text-muted"">
                    <span class=""fa fa-truck margin-right-5""></span> 18/07/2016 06:14:32 PM
                </p>
            </div>
            <div class=""listing-item margin-bottom-10"">
                <strong>Critical Server Load</strong> <span class=""label label-danger pull-right"">server</span>
                <p class=""margin-0 margin-top-5"">Disk space: 248.1Gb/250Gb. <a href=""#"">Control panel</a>.</p>
                <p class=""text-muted"">
                    <span class=""fa fa-truck margin-right-5""></span> 18/07/2016 06:14:32 PM
                </p>
            </div>
        </div>
        <div class=""row margin-bottom-30"">
            <div class=""col-xs-6 col-xs-offset-3"">
                <button class=""btn btn-default btn-block"">All Notification</button>
            </div>
        </div>

        <div class=""app-heading app-heading-condensed app-heading-small ma");
            WriteLiteral(@"rgin-bottom-20 padding-left-0"">
            <div class=""icon icon-lg"">
                <span class=""icon-cog""></span>
            </div>
            <div class=""title"">
                <h2>Settings</h2>
                <p>Notification Settings</p>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-xs-2"">
                    <label class=""switch switch-sm margin-0"">
                        <input type=""checkbox"" name=""app_settings_1"" checked="""" value=""0"">
                    </label>
                </div>
                <div class=""col-xs-10"">
                    <label>Delivery Information</label>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-xs-2"">
                    <label class=""switch switch-sm margin-0"">
                        <input type=""checkbox"" name=""app_settings_2"" checked="""" value=""0"">");
            WriteLiteral(@"
                    </label>
                </div>
                <div class=""col-xs-10"">
                    <label>Product Amount Information</label>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-xs-2"">
                    <label class=""switch switch-sm margin-0"">
                        <input type=""checkbox"" name=""app_settings_3"" checked="""" value=""0"">
                    </label>
                </div>
                <div class=""col-xs-10"">
                    <label>Order Information</label>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-xs-2"">
                    <label class=""switch switch-sm margin-0"">
                        <input type=""checkbox"" name=""app_settings_4"" checked="""" value=""0"">
                    </label>
                </div>
                <div c");
            WriteLiteral(@"lass=""col-xs-10"">
                    <label>Server Load</label>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-xs-2"">
                    <label class=""switch switch-sm margin-0"">
                        <input type=""checkbox"" name=""app_settings_5"" value=""0"">
                    </label>
                </div>
                <div class=""col-xs-10"">
                    <label>User Registrations</label>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-xs-2"">
                    <label class=""switch switch-sm margin-0"">
                        <input type=""checkbox"" name=""app_settings_6"" value=""0"">
                    </label>
                </div>
                <div class=""col-xs-10"">
                    <label>Purchase Information</label>
                </div>
            <");
            WriteLiteral("/div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
