#pragma checksum "E:\Net Core\NewProject\NetCore\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c240658d0ab96cfd65247041310b5f20f3091acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
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
#line 1 "E:\Net Core\NewProject\NetCore\Views\_ViewImports.cshtml"
using netCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Net Core\NewProject\NetCore\Views\_ViewImports.cshtml"
using netCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c240658d0ab96cfd65247041310b5f20f3091acc", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb77c82b607ca166daa2cd43e00b6c08d2570a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <div class=""hiheader"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-6"">
                        </div>
                        <div class=""col-lg-6 col-md-6 col-sm-7 hidden-xs"">
                            <div class=""title-hiheader"">
                                <h4>Hệ Thống Trường Liên Cấp Việt Nhật</h4>
                            </div>
                        </div>
                        <div class=""col-md-3 col-sm-2 col-12"">
                            <div class=""irs-social irs-center-2 text-right"">
                              <a href=""#"" style=""color: var(--color-primary-light) ;""> Đăng nhập</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
              <div class=""navigation-wrap bg-light start-header start-style"">
                <div class=""container"">
                    <div class=""");
            WriteLiteral(@"row"">
                        <div class=""col-12"">
                            <nav class=""navbar navbar-expand-md navbar-light"">

                                <a class=""navbar-brand"" href=""/trang-chu"">
                                    <img src=""/images/logovn-2295.png""");
            BeginWriteAttribute("alt", " alt=\"", 1305, "\"", 1311, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>

                                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                                    <span class=""navbar-toggler-icon""></span>
                                </button>

                                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                                    <ul class=""navbar-nav ml-auto py-4 py-md-0"">
                                        <li class=""nav-item pl-4 pl-md-0 ml-0 ml-md-4 active"">
                                            <a class=""nav-link"" href=""/trang-chu"">Trang Chủ</a>
                                        </li>
                                           <li class=""nav-item pl-4 pl-md-0 ml-0 ml-md-4"">
                                            <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-");
            WriteLiteral(@"expanded=""false"">Giới thiệu</a>
                                        </li>
                                        <li class=""nav-item pl-4 pl-md-0 ml-0 ml-md-4"">
                                            <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Tin tức</a>
                                        </li>
                                        <li class=""nav-item pl-4 pl-md-0 ml-0 ml-md-4"">
                                            <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Tuyển Sinh</a>
                                            <div class=""dropdown-menu"">
                                               
                                                <a class=""dropdown-item"" href=""#"">Tuyển sinh</a>
                                                <a class=""dropdown-item"" href=""/thu-vien-hinh-anh"">Học phí</a>
                             ");
            WriteLiteral(@"                   <a class=""dropdown-item"" href=""/thu-vien-video"">Thư Viện Video</a>
                                          
                                            </div>
                                        </li>
                                        
                                        <li class=""nav-item pl-4 pl-md-0 ml-0 ml-md-4"">
                                            <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Thư Viện</a>
                                            <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">Sách</a>
                                                <a class=""dropdown-item"" href=""/thu-vien-hinh-anh"">Thư Viện Ảnh</a>
                                                <a class=""dropdown-item"" href=""/thu-vien-video"">Thư Viện Video</a>
                                            </div>
                              ");
            WriteLiteral("          </li>\r\n                                    </ul>\r\n                                </div>\r\n                            </nav>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>");
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
