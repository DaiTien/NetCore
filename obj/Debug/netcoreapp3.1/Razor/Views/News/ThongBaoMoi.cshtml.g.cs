#pragma checksum "E:\NetCore\Views\News\ThongBaoMoi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266b2a2c56742a7777753b2e907c1bc9e6407b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ThongBaoMoi), @"mvc.1.0.view", @"/Views/News/ThongBaoMoi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"266b2a2c56742a7777753b2e907c1bc9e6407b33", @"/Views/News/ThongBaoMoi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb77c82b607ca166daa2cd43e00b6c08d2570a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ThongBaoMoi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<netCore.Models.NewsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""style-breadcrumb"">
    <div class=""container"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""./Default.aspx"">Trang chủ</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Tin tức</a></li>
            <li class=""breadcrumb-item active"">
                <span id=""higlobal_lblNoiDung"">");
#nullable restore
#line 8 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
                                          Write(Model.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </li>
        </ol>
    </div>
</div>

<section class=""irs-blog-field"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3 col-sm-4 d-none d-sm-none d-md-block "">
                <div class=""sticky-top"">
                    <div class=""irs-side-bar"">

                        <!-------Menu loai tin tuc------>
                        <div class=""irs-categories"">
                            <div class=""irs-sidebar-title"">
                                <h3>Tin tức</h3>
                            </div>
                            <ul>

                                <li>
                                    <i class=""fa fa-check"" aria-hidden=""true""></i><a
                                        href=""/news/thongbaomoi"">");
#nullable restore
#line 30 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
                                                            Write(Model.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </li>

                                <li>
                                    <i class=""fa fa-check"" aria-hidden=""true""></i><a
                                        href=""/news/hoatdongsukien"">Hoạt Động - Sự Kiện</a>
                                </li>

                            </ul>
                        </div>
                        <!-------Fanpage------>
                        <div class=""irs-video"">
                            <div class=""irs-sidebar-title"">
                                <h3>Facebook</h3>
                            </div>
                            <div id=""fb-root"" class="" fb_reset"">
                                <div style=""position: absolute; top: -10000px; width: 0px; height: 0px;"">
                                    <div></div>
                                </div>
                            </div>
                            <script");
            BeginWriteAttribute("async", " async=\"", 2161, "\"", 2169, 0);
            EndWriteAttribute();
            BeginWriteAttribute("defer", " defer=\"", 2170, "\"", 2178, 0);
            EndWriteAttribute();
            WriteLiteral(@" crossorigin=""anonymous""
                                src=""https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&amp;version=v5.0""></script>
                            <div class=""fb-page fb_iframe_widget""
                                data-href=""https://www.facebook.com/TruongLienCapVietNhat/"" data-tabs=""timeline""
                                data-width="""" data-height="""" data-small-header=""true"" data-adapt-container-width=""true""
                                data-hide-cover=""false"" data-show-facepile=""true"" fb-xfbml-state=""rendered""
                                fb-iframe-plugin-query=""adapt_container_width=true&amp;app_id=&amp;container_width=255&amp;hide_cover=false&amp;href=https%3A%2F%2Fwww.facebook.com%2FTruongLienCapVietNhat%2F&amp;locale=vi_VN&amp;sdk=joey&amp;show_facepile=true&amp;small_header=true&amp;tabs=timeline"">
                                <span style=""vertical-align: bottom; width: 255px; height: 500px;""><iframe
                                        name=""f2806834a3df11");
            WriteLiteral(@"8"" width=""1000px"" height=""1000px""
                                        data-testid=""fb:page Facebook Social Plugin""
                                        title=""fb:page Facebook Social Plugin"" frameborder=""0"" allowtransparency=""true""
                                        allowfullscreen=""true"" scrolling=""no"" allow=""encrypted-media""
                                        src=""https://www.facebook.com/v5.0/plugins/page.php?adapt_container_width=true&amp;app_id=&amp;channel=https%3A%2F%2Fstaticxx.facebook.com%2Fconnect%2Fxd_arbiter.php%3Fversion%3D46%23cb%3Df69edf72bbe85c%26domain%3Ddemo.vietnhatschool.edu.vn%26origin%3Dhttp%253A%252F%252Fdemo.vietnhatschool.edu.vn%252Ffb86a239e98dfc%26relation%3Dparent.parent&amp;container_width=255&amp;hide_cover=false&amp;href=https%3A%2F%2Fwww.facebook.com%2FTruongLienCapVietNhat%2F&amp;locale=vi_VN&amp;sdk=joey&amp;show_facepile=true&amp;small_header=true&amp;tabs=timeline""
                                        style=""border: none; visibility: visible; width:");
            WriteLiteral(" 255px; height: 500px;\"");
            BeginWriteAttribute("class", "\r\n                                        class=\"", 4250, "\"", 4299, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe></span></div>
                        </div>
                    </div>

                </div>

            </div>

            <div class=""col-md-9 col-sm-12"">
                <div class=""title-block"">
                    <h2 class=""color1"">
                        <span");
            BeginWriteAttribute("id", " id=\"", 4594, "\"", 4599, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
                               Write(Model.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h2>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 79 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
                     foreach(var news in Model.News){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-6 col-md-6 col-sm-12 col-12\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-image-top\">\r\n                                <img class=\"card-img-top img-thumbnail\"");
            BeginWriteAttribute("src", "\r\n                                    src=\"", 5007, "\"", 5065, 1);
#nullable restore
#line 84 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
WriteAttributeValue("", 5050, news.NewsImage, 5050, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\"><a href=\"#\">");
#nullable restore
#line 88 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
                                                              Write(news.NewsTittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 89 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
                                                Write(news.NewsContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a href=\"../../tin-tuc/Thong-Bao-Moi/Thong-Bao-Nghi-Hoc-3\">Xem thêm</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 94 "E:\NetCore\Views\News\ThongBaoMoi.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<netCore.Models.NewsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
