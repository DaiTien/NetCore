<<<<<<< HEAD
#pragma checksum "E:\NetCore\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2809e1bab2d64b1ff8d2d91ec49aec96bc92ea0a"
=======
#pragma checksum "F:\IT\Back-End\2020\NetCore\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2809e1bab2d64b1ff8d2d91ec49aec96bc92ea0a"
>>>>>>> 1478649a2fc3db988c7984a19470612856226f25
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
<<<<<<< HEAD
#line 1 "E:\NetCore\Views\_ViewImports.cshtml"
=======
#line 1 "F:\IT\Back-End\2020\NetCore\Views\_ViewImports.cshtml"
>>>>>>> 1478649a2fc3db988c7984a19470612856226f25
using netCore;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "E:\NetCore\Views\_ViewImports.cshtml"
=======
#line 2 "F:\IT\Back-End\2020\NetCore\Views\_ViewImports.cshtml"
>>>>>>> 1478649a2fc3db988c7984a19470612856226f25
using netCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2809e1bab2d64b1ff8d2d91ec49aec96bc92ea0a", @"/Views/Shared/_Header.cshtml")]
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
                                <%--<a class=""icon-top"" target=""_blank"" href=""#""><i class=""fab fa-facebook-f""></i></a>--%>
                                <%--<a class=""icon-top"" target=""_blank"" href=""#""><i class=""fab fa-youtube""></i></a>--%>
                                <a class=""icon-top"" id=""btnLogin"" runat=""server"" href=""#"" data-toggle=""modal"" data-target=""#login""><i class=""fas fa-u");
            WriteLiteral(@"ser""></i>Đăng Nhập</a>
                                <%--<a class=""hello"" style=""color: #fff"" href=""JavaScript:Void(0);"">Welcome <%=nameStudent%> </a>--%>
                                <div id=""dv_Account"" runat=""server"" class=""account"">
                                    <a style=""color: var(--color-primary-light); font-weight: 600"" href=""#"">Xin Chào  <%=nameStudent%></a>
                                    <div class=""account-top"">
                                        <div class=""account-top__name"">
                                            <a style=""color: var(--color-primary-light)"" href=""../../account-manager"">Hồ sơ học sinh</a>
                                        </div>
                                        <div class=""account-top__name"">
                                            <a style=""color: var(--color-primary-light)"" href=""../../bai-tap"">Bài tập</a>
                                        </div>
                                        <div class=""account-top__name");
            WriteLiteral(@""">
                                            <a style=""color: var(--color-primary-light)"" href=""#"" id=""btnLogout"" runat=""server"" onserverclick=""Logout_ServerClick"">Log Out</a>
                                        </div>
                                    </div>
                                </div>

                                <input id=""txtHocSinh"" runat=""server"" type=""text"" style=""display: none"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>");
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
