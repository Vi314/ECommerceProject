#pragma checksum "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636c70e314242de12359a1adfcf5397093d1466e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\_ViewImports.cshtml"
using NetECommerce.MVC.Areas.Dashboard.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\_ViewImports.cshtml"
using NetECommerce.Entity.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636c70e314242de12359a1adfcf5397093d1466e", @"/Areas/Dashboard/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3187ec7c60250fadb5ece872ef5bdafe061a7cf6", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Dashboard_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetECommerce.Entity.Entity.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-asp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
 if (TempData["result"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible mt-2\">\r\n        <span>");
#nullable restore
#line 9 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
         Write(TempData["result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-4 mt-2\">\r\n    <div class=\"card-header\">\r\n        <div class=\"d-flex justify-content-between\">\r\n            <h3>");
#nullable restore
#line 15 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "636c70e314242de12359a1adfcf5397093d1466e8059", async() => {
                WriteLiteral("New Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""card-body"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>#</th>
                    <th>Product Name</th>
                    <th>Description</th>
                    <th>UnitPrice</th>
                    <th>Units In Stock</th>
                    <th>Category</th>
                    <th>Supplier</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                  
                    if (Model.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"7\">\r\n                                <span>Herhangi bir kategori eklenmemiş</span>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                    }
                    else
                    {
                        foreach (var product in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "636c70e314242de12359a1adfcf5397093d1466e11103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1696, "~/images/product/", 1696, 17, true);
#nullable restore
#line 51 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1713, product.ImagePath, 1713, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                               Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                     if (product.Description != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                         if (product.Description.Length > 100)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                       Write(product.Description.Substring(0,99));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>\r\n                                                [<a href=\"#\">Devamı..</a>]\r\n                                            </span>\r\n");
#nullable restore
#line 64 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                       Write(product.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                                                
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Açıklama bulunmuyor!</span>\r\n");
#nullable restore
#line 73 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 77 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                               Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 78 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                               Write(product.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 79 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                 foreach (var item in ViewBag.Categories)
                                {
                                    if (item.Id == product.CategoryId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 83 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 84 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                        break;
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                 foreach (var item in ViewBag.Suppliers)
                                {
                                    if (item.Id == product.SupplierId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>");
#nullable restore
#line 91 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                               Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 92 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                        break;
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "636c70e314242de12359a1adfcf5397093d1466e19282", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                                                                                                         WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    |\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "636c70e314242de12359a1adfcf5397093d1466e21791", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                                                                                                                        WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 101 "C:\Users\Viraldo\Desktop\Project-main\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Product\Index.cshtml"
                        }
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetECommerce.Entity.Entity.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
