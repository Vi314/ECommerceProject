#pragma checksum "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "939909a2d26f31df58a83556fe3003f594c88061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyCart), @"mvc.1.0.view", @"/Views/Home/MyCart.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\_ViewImports.cshtml"
using NetECommerce.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\_ViewImports.cshtml"
using NetECommerce.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\_ViewImports.cshtml"
using NetECommerce.MVC.ViewModels.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"939909a2d26f31df58a83556fe3003f594c88061", @"/Views/Home/MyCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db5aeb924c55b501a11abc0a4100d2560d72bf6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_MyCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
  
    ViewData["Title"] = "MyCart";
    decimal? toplamTutar = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-3"">
    <div class=""col-md-9"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Product Name</th>
                    <th>UnitPrice</th>
                    <th>Quantity</th>
                    <th>SubTotal</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
                 foreach (var item in ViewBag.Cart._myCart.Values)
                {
                    toplamTutar += item.SubTotal;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
                       Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
                       Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        <div class=\"card\">\r\n            <h1>Toplam Tutar: ");
#nullable restore
#line 34 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Views\Home\MyCart.cshtml"
                         Write(toplamTutar);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???</h1>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
