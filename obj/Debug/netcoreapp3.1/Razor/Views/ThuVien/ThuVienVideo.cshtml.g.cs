#pragma checksum "E:\NetCore\Views\ThuVien\ThuVienVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554063e3692261215fdf3f8803b317596854065c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThuVien_ThuVienVideo), @"mvc.1.0.view", @"/Views/ThuVien/ThuVienVideo.cshtml")]
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
#line 1 "E:\NetCore\Views\_ViewImports.cshtml"
using netCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\NetCore\Views\_ViewImports.cshtml"
using netCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554063e3692261215fdf3f8803b317596854065c", @"/Views/ThuVien/ThuVienVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb77c82b607ca166daa2cd43e00b6c08d2570a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_ThuVien_ThuVienVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<netCore.Models.ThuVienVideoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\NetCore\Views\ThuVien\ThuVienVideo.cshtml"
  
ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""portfolio section"">
        <div class=""container"">
            <div class=""top-side"">
                <h2>Thư Viện Video</h2>
            </div>
            <div class=""filters"">
                <ul class=""nav"">
                    <li class=""nav-glr active"" data-filter=""*"">Tất Cả</li>
");
#nullable restore
#line 13 "E:\NetCore\Views\ThuVien\ThuVienVideo.cshtml"
                        foreach (var item in Model.Name)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-glr\" data-filter=\"");
#nullable restore
#line 15 "E:\NetCore\Views\ThuVien\ThuVienVideo.cshtml"
                                                        Write(item.NameFilter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 15 "E:\NetCore\Views\ThuVien\ThuVienVideo.cshtml"
                                                                          Write(item.NameClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "E:\NetCore\Views\ThuVien\ThuVienVideo.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>

            <div class=""filters-content-video"">
                <div class=""row grid"" style=""position: relative; height: 0px;"">
                    
               
                </div>
            </div>

        </div>
    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<netCore.Models.ThuVienVideoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
