#pragma checksum "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc70cc292e8958635505265df4f394048dba42f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioiThieu_Index), @"mvc.1.0.view", @"/Views/GioiThieu/Index.cshtml")]
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
#line 1 "F:\IT\Back-End\2020\NetCore\Views\_ViewImports.cshtml"
using netCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\IT\Back-End\2020\NetCore\Views\_ViewImports.cshtml"
using netCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc70cc292e8958635505265df4f394048dba42f", @"/Views/GioiThieu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb77c82b607ca166daa2cd43e00b6c08d2570a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_GioiThieu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<netCore.Models.IndexGioiThieuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gioithieu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0dc70cc292e8958635505265df4f394048dba42f3761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""container"">
        <div class=""style-breadcrumb"">
            <div class=""container"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""../Default.aspx"">Trang chủ</a></li>
                    <li class=""breadcrumb-item""><a href=""#"">Giới Thiệu</a></li>
");
            WriteLiteral(@"                </ol>
            </div>
        </div>
        <h2 class=""title-gioithieu"">Giới thiệu</h2>
        <div class=""bd-example bd-example-tabs mt-2"">
            <div class=""row"">
                <div class=""col-3"">
                    <div class=""nav flex-column nav-pills"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
");
            WriteLiteral("                                    <a class=\"nav-link active show\" id=\"v-pills-home-tab\" data-toggle=\"pill\" href=\"#v-pills-home\" role=\"tab\" aria-controls=\"v-pills-home\" aria-selected=\"false\">");
#nullable restore
#line 29 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
                                                                                                                                                                                           Write(Model.Title2[0].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a class=\"nav-link\" id=\"v-pills-profile-tab\" data-toggle=\"pill\" href=\"#v-pills-profile\" role=\"tab\" aria-controls=\"v-pills-profile\" aria-selected=\"false\">");
#nullable restore
#line 30 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
                                                                                                                                                                                        Write(Model.Title2[1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a class=\"nav-link\" id=\"v-pills-messages-tab\" data-toggle=\"pill\" href=\"#v-pills-messages\" role=\"tab\" aria-controls=\"v-pills-messages\" aria-selected=\"false\">");
#nullable restore
#line 31 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
                                                                                                                                                                                           Write(Model.Title2[2].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a class=\"nav-link \" id=\"v-pills-settings-tab\" data-toggle=\"pill\" href=\"#v-pills-settings\" role=\"tab\" aria-controls=\"v-pills-settings\" aria-selected=\"true\">");
#nullable restore
#line 32 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
                                                                                                                                                                                           Write(Model.Title2[3].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a class=\"nav-link \" id=\"v-csvc-tab\" data-toggle=\"pill\" href=\"#v-csvc\" role=\"tab\" aria-controls=\"v-csvc\" aria-selected=\"true\">");
#nullable restore
#line 33 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
                                                                                                                                                             Write(Model.Title2[4].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-9"">
                    <div class=""tab-content "" id=""v-pills-tabContent"">
                        <div class=""tab-pane fade active show"" id=""v-pills-home"" role=""tabpanel"" aria-labelledby=""v-pills-home-tab"">
                            <h3 class=""title-content"">ĐỘI NGŨ GIÁO VIÊN TRƯỜNG LIÊN CẤP VIỆT NHẬT</h3>
                            <p>
                                <b>- Đội ngũ Giáo Viên là yếu tố quan trọng và quyết định cho chất lượng Giáo dục và Đào tạo của Nhà trường. Đây cũng là niềm tự hào của Việt Nhật vì đội ngũ Giáo viên trong Nhà trường luôn hội tụ đầy đủ các yếu tố của một người thầy có tài, có tâm và dạy
									trẻ bằng cả trái tim nhiệt huyết.</b> </br> + Giáo viên Việt Nhật là những Thầy Cô giáo có tri thức, tâm hồn, có khả năng tự học, sáng tạo, làm việc hết mình vì sự trưởng thành của các học sinh thân yêu;</br> +
                                Thầy cô được bồi dưỡng chuyên môn, lý tưởng");
            WriteLiteral(@" nghề nghiệp bằng các chuyên đề tập huấn phương pháp dạy học, chuyên đề kĩ năng sống, kĩ năng giao tiếp, tâm lý trẻ, các cuộc thi Chuyên môn Giỏi, trong nước và cả nước ngoài;</br>
                                + Đội ngũ giáo viên nước ngoài là các thầy cô am hiểu văn hoá Việt Nam, am hiểu tâm lý trẻ, có phương pháp dạy học hiện đại, hỗ trợ rèn luyện cho trẻ làm quen với Tư duy toàn cầu ngay từ những giai đoạn đầu đời;
                                </br> + Ban Lãnh đạo, Hội đồng Cố vấn, Thanh tra chuyên môn là các chuyên gia trong lĩnh vực giáo dục và quản lý giáo dục, lĩnh vực quan hệ quốc tế và chuyển giao công nghệ mang đến cho các em những quyền lợi giáo dục ưu
                                việt nhất; <br> <b>Đội ngũ giáo viên Mầm non:</b> <br> + Yêu thương và kiên nhẫn với trẻ là yếu tố tiên quyết;</br> + 100% tốt nghiệp từ các trường Cao đẳng, Đại học trở lên; </br> + Thành thạo kỹ năng chuyên môn và nắm
                                bắt tâm lý trẻ nhỏ; </br> + Nhiều tài năng, mang đến cho t");
            WriteLiteral("rẻ cơ hội phát huy năng khiếu và giàu có về mặt tinh thần ngay từ lứa tuổi Mầm non: ca hát, nhảy - múa, MC, vẽ…\r\n                            </p>\r\n                            <div class=\"img1\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5582, "\"", 5601, 1);
#nullable restore
#line 52 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 5588, Model.Image1, 5588, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Giáo viên mầm non"">
                            </div>
                            <p>
                                <b>Đội ngũ giáo viên Tiểu học:</b> <br> + Luôn tạo động lực cho học sinh học tập mỗi ngày; <br> + Sẵn sàng đổi mới, tiếp cận những phương pháp giáo dục hiện đại, hiệu quả cao; <br> + Liên tục đạt thành tích cao trong các
                                cuộc thi giáo viên dạy giỏi của ngành; tham gia các cuộc thi viết sáng kiến kinh nghiệm để trau dồi kỹ năng trên hành trình dạy trẻ trưởng thành; <br> <b>Đội ngũ giáo viên THCS & THPT:</b> <br> + Nuôi dưỡng ước mơ và đồng
                                hành với học sinh trong việc biến ước mơ trở thành hiện thực <br> + Khám phá “công thức bí ẩn” để hiểu, yêu thương và hòa hợp với trẻ ở lứa tuổi THCS & THPT trong cả việc học cũng như trong cuộc sống
                            </p>
                            <div class=""img1"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 6558, "\"", 6577, 1);
#nullable restore
#line 60 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 6564, Model.Image2, 6564, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Đội ngũ giáo viên THCS & THPT của trường Liên Cấp Việt Nhật"">
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""v-pills-profile"" role=""tabpanel"" aria-labelledby=""v-pills-profile-tab"">
                            <h3 class=""title-content"">CƠ CẤU TỔ CHỨC HỆ THỐNG</h3>
                            <div class=""img-cocautochuchethong"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 7037, "\"", 7056, 1);
#nullable restore
#line 66 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 7043, Model.Image3, 7043, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Sơ đồ cơ cấu tổ chức hệ thống"">
                            </div>

                        </div>
                        <div class=""tab-pane fade"" id=""v-pills-messages"" role=""tabpanel"" aria-labelledby=""v-pills-messages-tab"">
                            <h3 class=""title-content"">ĐỐI TÁC CHIẾN LƯỢC</h3>
                            <p>Giáo viên đóng vai trò quan trọng trong việc quyết định chất lượng và hiệu quả giáo dục. Vì vậy ngay từ những ngày đầu thành lập, chúng tôi đã đầu tư kỹ lưỡng cho công tác tuyển dụng, đào tạo chuyên môn và luôn cố gắng tạo
                                mọi điều kiện tốt nhất có thể để các thầy giáo, cô giáo yên tâm công tác cũng như nghiên cứu, áp dụng các phương pháp giảng dạy tiên tiến. Chúng tôi luôn cảm thấy may mắn khi sở hữu đội ngũ giáo viên đầy kinh nghiệm và
                                tâm huyết, đã có nhiều năm làm việc tại các trường học có bề dày lịch sử trên địa bàn thành phố như Nguyễn Huệ, Trưng Vương, Nguyễn Khuyến, Lê Quý Đôn,… chính các thầy");
            WriteLiteral(@" cô là những người đã phát hiện và đào tạo ra nhiều
                                thế hệ học sinh giỏi cho đất nước, được học trò kính yêu, phụ huynh tin tưởng và đồng nghiệp công nhận. Cùng với đó là đội ngũ giáo viên trẻ, họ là những giáo viên năng động, có tư duy sáng tạo và được tuyển chọn một cách
                                kỹ lưỡng.</p>
                        </div>
                        <div class=""tab-pane fade"" id=""v-pills-settings"" role=""tabpanel"" aria-labelledby=""v-pills-settings-tab"">
                            <h3 class=""title-content"">THÀNH TỰU VIỆT NHẬT</h3>
                            <p class=""pt-2"" style=""text-align: center; font-weight: bold;"">THÀNH TỰU ĐẠT ĐƯỢC</p>
                            <p style=""text-indent: 30px;"">Chặng đường năm chưa phải là dài nhưng đây là chặng đường đầu tiên cho sự hình thành và phát triển của trường Liên Cấp Việt Nhật. Trong những năm qua trường đã không ngừng vươn lên, dạy tốt học tốt. Đứng trước nhiều khó khăn
                            ");
            WriteLiteral(@"    thách thức, nhà trường đã luôn nêu cao tinh thần đoàn kết, quyết tâm vượt qua mọi khó khăn, vận dụng sáng tạo nhiều chủ trương, nhiệm vụ của ngành vào tình hình thực tế, giữ vững và phát huy những thành tựu và đi lên vững
                                chắc. Những giá trị tinh thần do các thế hệ thầy và trò nhà trường tạo dựng nên trong những năm tháng qua đã viết lên truyền thống đáng tự hào của tập thể sư phạm nhà trường hôm nay.</p>
                            <p style=""text-indent: 30px;"">Đến nay, trường với 2 cơ sở khang trang. Cơ sở 1 tại Lê Duẩn được thành lập vào ngày 05/09/2010. Tổng cộng có 8 giáo viên và 1 lớp có nhiều độ tuổi khác nhau. Sau 10 năm hình thành và phát triển trường hiện nay đã mở rộng thêm
                                cơ sở 2 tại 2A Nguyên Quý Đức với nhiều cấp học từ Mầm Non tới Trung học Phổ thông.</p>
                            <div class=""img1"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 10043, "\"", 10062, 1);
#nullable restore
#line 87 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 10049, Model.Image4, 10049, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Lễ hội thể thao lần thứ 9 năm 2019"">
                            </div>
                            <p style=""text-indent: 30px;"">Chú tâm vào công tác dạy và học bên cạnh đó trường hằng năm đã tổ chức cho học sinh tham gia các lễ hội thường niên, như Lê hội Âm nhạc, Lễ hội Thể thao, Lễ hội mùa hè…100% học sinh đều được tham gia và tỏa sáng tài năng của
                                mình.
                            </p>
                            <div class=""img1"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 10584, "\"", 10603, 1);
#nullable restore
#line 93 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 10590, Model.Image5, 10590, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Lễ hội âm nhạc lần thứ 2 năm 2019 tại cơ sở 2"">
                            </div>
                            <p style=""text-indent: 30px;"">Trong suốt năm học trường còn tổ chức các buổi hoạt động ngoại khóa đầy bổ ích. Đây là chương trình hấp dẫn nhất đối với các em học sinh, là từ khóa mà mỗi lần nghe thấy thì tất cả các em đều reo hò phấn khởi… Sự hấp dẫn của
                                dã ngoại hẳn không chỉ được tạo bởi sự vui vẻ đặc thù vì các em được vui chơi, được thỏa sức khám phá… mà còn bởi, dã ngoại mang lại cho các em những cơ hội, những trải nghiệm bài học rất thực tế, rất hữu ích… Hằng năm
                                vào thời điểm thích hợp nhà trường sẽ tổ chức cho các con được tham gia trải nghiệm và học tập đầy bổ ích.
                            </p>
                            <div class=""img1"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 11489, "\"", 11508, 1);
#nullable restore
#line 100 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 11495, Model.Image6, 11495, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt="" Học sinh các khối 6,7, 10 tham gia dã ngoại năm học 2019 -2020"">
                            </div>
                        </div>

                        <div class=""tab-pane fade "" id=""v-csvc"" role=""tabpanel"" aria-labelledby=""v-csvc-tab"">
                            <h3 class=""title-content"">CƠ SỞ VẬT CHẤT TRƯỜNG LIÊN CẤP VIỆT NHẬT</h3>
                            <P style=""text-indent: 30px;"">Trường được xây dựng trên khuôn viên gần 2.000m2, gồm khối mầm non, khối tiểu học, trung học cơ sở có tổng diện tích sàn sử dụng gần 5.000 m2 . Công trình cao 5 tầng có thang máy. Cở sở vật chất và thiết bị giáo dục được đầu
                                tư hiện đại, đẳng cấp quốc tế, đảm bảo việc dạy và học các môn văn hóa, thể thao, nghệ thuật, kỹ năng sống và tổ chức các lễ hội hàng tháng, hàng năm cho học sinh toàn trường. Tại mỗi cơ sở, trường còn bố trí một bếp ăn
                                công nghiệp phục vụ tại chỗ cho giáo viên và học sinh bán trú toàn trường.</P>
                    ");
            WriteLiteral("        <div class=\"img1\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 12597, "\"", 12616, 1);
#nullable restore
#line 110 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 12603, Model.Image7, 12603, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" Khung nhà 5 tầng có thang máy phục vụ giảng dạy\">\r\n                            </div>\r\n                            <div class=\"img1 mt-2\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 12800, "\"", 12819, 1);
#nullable restore
#line 113 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 12806, Model.Image8, 12806, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" Khung nhà 5 tầng có thang máy phục vụ giảng dạy\">\r\n                            </div>\r\n                            <div class=\"img1 mt-2\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 13003, "\"", 13022, 1);
#nullable restore
#line 116 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 13009, Model.Image9, 13009, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" Khung nhà 5 tầng có thang máy phục vụ giảng dạy\">\r\n                            </div>\r\n                            <div class=\"img1 mt-2\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 13206, "\"", 13226, 1);
#nullable restore
#line 119 "F:\IT\Back-End\2020\NetCore\Views\GioiThieu\Index.cshtml"
WriteAttributeValue("", 13212, Model.Image10, 13212, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt="" Khung nhà 5 tầng có thang máy phục vụ giảng dạy"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.min.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.15.0/umd/popper.min.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.min.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<netCore.Models.IndexGioiThieuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
