#pragma checksum "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TrangTrong), @"mvc.1.0.view", @"/Views/Shared/TrangTrong.cshtml")]
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
#line 30 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc", @"/Views/Shared/TrangTrong.cshtml")]
    public class Views_Shared_TrangTrong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Frontend/assets/css/style1.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Frontend/assets/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Frontend/assets/js/jquery-3.6.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Frontend/images/search-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Frontend/images/icon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("240px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Frontend/images/unamed.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc7575", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>DQ Shop</title>\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc7934", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc9200", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc10386", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc12281", async() => {
                WriteLiteral(@"
    <!--Start of Tawk.to Script-->
    <script type=""text/javascript"">
        var Tawk_API=Tawk_API||{}, Tawk_LoadStart=new Date();
        (function(){
        var s1=document.createElement(""script""),s0=document.getElementsByTagName(""script"")[0];
        s1.async=true;
        s1.src='https://embed.tawk.to/6155b9e1d326717cb68415b0/1fgrds69h';
        s1.charset='UTF-8';
        s1.setAttribute('crossorigin','*');
        s0.parentNode.insertBefore(s1,s0);
        })();
    </script>
    <!--End of Tawk.to Script-->
    ");
#nullable restore
#line 28 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
Write(Html.Partial("~/Views/Shared/Header.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- content -->\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 54 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
      
        int _CategoryID = Convert.ToInt32(ViewBag.CategoryID);
        string strOrder = !String.IsNullOrEmpty(Context.Request.Query["order"]) ? Context.Request.Query["order"] : "";
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"content\">\r\n        <!--left -->\r\n        ");
#nullable restore
#line 61 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /left -->\r\n        <!-- right -->\r\n        <div class=\"right\">\r\n            <!-- search -->\r\n            <div class=\"timkiemnangcao\">\r\n                <div class=\"title\">Tìm kiếm nâng cao</div>\r\n");
                WriteLiteral("                <form class=\"form\" action=\"/Search/SearchMix\" method=\"post\" style=\"background: white;\">\r\n                    <ul>\r\n");
                WriteLiteral("                        <li>\r\n");
#nullable restore
#line 73 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                              
                                List<Categories> _ListCategory = Categories();
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <select name=\"brand\">\r\n                                <option value=\"0\">Chọn hãng sản xuất</option>\r\n");
#nullable restore
#line 78 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                                 foreach (var item in _ListCategory)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <option");
                BeginWriteAttribute("value", " value=\"", 3331, "\"", 3347, 1);
#nullable restore
#line 80 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
WriteAttributeValue("", 3339, item.ID, 3339, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 80 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 81 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>

                        </li>
                        <li>
                            <select name=""cost"">
                                <option>Mức giá</option>
                                <option value=""gia1"">Dưới 5 tr</option>
                                <option value=""gia2"">Từ 5-10 tr</option>
                                <option value=""gia3"">Từ 10-20 tr</option>
                                <option value=""gia4"">Trên 20</option>
                            </select>
                        </li>
");
                WriteLiteral("                        <li><button style=\"width: 90px;\" type=\"submit\">Tìm kiếm</button></li>\r\n                    </ul>\r\n                    <div class=\"a\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc17025", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                </form>\r\n\r\n");
                WriteLiteral(@"            </div>
            <!-- /search -->
            <!-- support -->
            <div class=""support"">
                <div class=""title"">Hỗ trợ trực tuyến</div>
                <div class=""form-support"">
                    <ul>
                        <li>
                            <div class=""img"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc18548", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <div class=""infor""><a href=""#"">0972 236 762</a></div>
                        </li>
                        <li>
                            <div class=""img"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc19900", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <div class=""infor""><a href=""#"">Email liên hệ</a></div>
                        </li>
                        <li>
                            <div class=""img"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc21253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <div class=""infor""><a href=""#"">Liên hệ trực tiếp</a></div>
                        </li>
                        <li>
                            <div class=""img"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc22610", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <div class=""infor""><a href=""#"">abc</a></div>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- /support -->
            <!-- support -->
            <div class=""support"">
                <div class=""title"">Tìm theo mức giá</div>
                <div class=""form-support"">
                    <ul>
                        <li>
                            <input type=""checkbox"" id=""gia1"" onclick=""location.href='/Search/SearchPrice?fromPrice=1000000&toPrice=5000000';"" />
                            <label for=""gia1"" style=""margin-top:3px;""> Từ 1.000.000đ đến 5.000.000đ</label>
                        </li>
                        <li>
                            <input type=""checkbox"" id=""gia2"" onclick=""location.href='/Search/SearchPrice?fromPrice=5000000&toPrice=10000000';"" />
                            <label for=""gia2"" style=""margin-top:3px;""> Từ 5.000.000đ đến 10.");
                WriteLiteral(@"000.000đ</label>
                        </li>
                        <li>
                            <input type=""checkbox"" id=""gia3"" onclick=""location.href='/Search/SearchPrice?fromPrice=10000000&toPrice=20000000';"" />
                            <label for=""gia3"" style=""margin-top:3px;""> Từ 10.000.000đ đến 20.000.000đ</label>
                        </li>
                        <li>
                            <input type=""checkbox"" id=""gia4"" onclick=""location.href='/Search/SearchPrice?fromPrice=20000000&toPrice=100000000';"" />
                            <label for=""gia4"" style=""margin-top:3px;""> Trên 20 triệu</label>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- /support -->
            <!-- support -->
            <div class=""support"">
                <div class=""title"">Tìm theo đặc điểm sản phẩm</div>
                <div class=""form-support"" style=""padding-left:10px;"">
");
#nullable restore
#line 165 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                      
                        List<Tags> listTag = GetTags();
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                     foreach(var item in listTag)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 7872, "\"", 7900, 2);
                WriteAttributeValue("", 7879, "/Search/Tags/", 7879, 13, true);
#nullable restore
#line 170 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
WriteAttributeValue("", 7892, item.ID, 7892, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span style=\" line-height:30px; border-radius:5px; margin-bottom:20px; font-size:10px; margin-left:3px; color:black; padding:5px; border:1px solid #dddddd;\">");
#nullable restore
#line 170 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                                                                                                                                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></a>\r\n");
#nullable restore
#line 171 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n            <!-- /support -->\r\n            <div class=\"banner\">\r\n                <a href=\"#\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0838af9c8cdb6a1c82fcf3b1fa8a4fa4673c9ecc27760", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
            </div>
        </div>
        <!-- /right -->
    </div>
    <div class=""footer"">
        <div class=""box"">
            <div class=""box1"">
                <div class=""box1-1"">
                    QUẢN LÝ TÀI KHOẢN
                    <ul style=""list-style-type: square; margin-left: 15px;"">
                        <li><a href=""/Account/Register"">Tạo tài khoản</a></li>
                        <li><a href=""/Account/Login"">Đăng nhập</a></li>
                        <li><a href=""#"">Thay đổi thông tin tài khoản</a></li>
                        <li><a href=""#"">Quên mật khẩu</a></li>
                        <li><a href=""#"">Lịch sử mua hàng</a></li>
                    </ul>
                </div>
                <div class=""box1-2"">
                    TRỢ GIÚP
                    <ul style=""list-style-type: square; margin-left: 15px;"">
                        <li><a href=""#"">Quy định sử dụng</a></li>
                        <li><a href=""#"">Hướng dẫn mua hàng</a></li>
         ");
                WriteLiteral(@"               <li><a href=""#"">Phương thức thanh toán</a></li>
                        <li><a href=""#"">Phương thức vận chuyển</a></li>
                        <li><a href=""#"">Các câu hỏi thường gặp F.A.Q</a></li>
                    </ul>
                </div>
                <div class=""box1-3"">
                    GIỚI THIỆU NHÀ XUẤT BẢN
                    <ul style=""list-style-type: square; margin-left: 15px;"">
                        <li><a href=""#"">Giới thiệu nhà xuất bản</a></li>
                        <li><a href=""#"">Liên hệ</a></li>
                        <li><a href=""#"">Góc báo chí</a></li>
                        <li><a href=""#"">Sơ đồ website</a></li>
                    </ul>
                </div>
                <div class=""box1-4"">
                    ĐIỀU KHOẢN
                    <ul style=""list-style-type: square; margin-left: 15px;"">
                        <li><a href=""#"">Điều khoản sử dụng</a></li>
                        <li><a href=""#"">Liên hệ</a></li>
            ");
                WriteLiteral(@"            <li><a href=""#"">Góc báo chí</a></li>
                        <li><a href=""#"">Sơ đồ website</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""a"">
            <div class=""right"">
                <p style=""font-weight: bold;"">
                    NGUYỄN ĐÌNH QUÝ
                </p>

                <p>Số 6, 136/88/9 Đường Cầu Diễn, Minh Khai, Bắc Từ Liêm, Hà Nội</p>

                Tel: 0972 236 762 - Fax: 08.38394948
            </div>
            <div class=""left"">
                <p>
                    Social Sciences Publishing House
                </p>
                <p>
                    Châu Sơn, Quảng Trường, Quảng Xương, Thanh Hóa
                </p>
                <p>
                    Tel: 036.239.1959 - Email: dinhquy23121999@gmail.com
                </p>
            </div>
        </div>
    </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Shared\TrangTrong.cshtml"
                
        public MyDbContext db = new MyDbContext();

        public string GetCategory(int _CategoryID)
        {
            Categories record = db.Categories.Where(item => item.ID == _CategoryID).FirstOrDefault();
            return record.Name != null ? record.Name : "";
        }
        public List<Categories> Categories()
        {
            List<Categories> _ListRecord = db.Categories.Where(item => item.ParentID == 0).OrderByDescending(item => item.ID).ToList();
            return _ListRecord;
        }
        public List<Tags> GetTags()
        {
            List<Tags> record = db.Tags.OrderByDescending(item => item.ID).ToList();
            return record;
        }
    

#line default
#line hidden
#nullable disable
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