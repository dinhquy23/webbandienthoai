#pragma checksum "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8685a9c228a6e111b1136da969db4f15ee0dd72e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 6 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8685a9c228a6e111b1136da969db4f15ee0dd72e", @"/Views/Products/Index.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/frontend/assets/css/pagelist.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px; height:150px; z-index:-1;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Frontend/images/star.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
  

    Layout = "~/Views/Shared/TrangTrong.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8685a9c228a6e111b1136da969db4f15ee0dd72e5331", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
  
    int _CategoryID = Convert.ToInt32(ViewBag.CategoryID);
    string strOrder = !String.IsNullOrEmpty(Context.Request.Query["order"]) ? Context.Request.Query["order"] : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"left\">\r\n    <div class=\"title\"><h2>Sản phẩm</h2></div>\r\n    <div class=\"main-content\">\r\n        <ul>\r\n");
#nullable restore
#line 20 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li>

                    <div class=""product1"" style=""position:relative;"">
                        <div style=""width:30px; line-height:30px; text-align:center; z-index:3; background:rgba(246,0,0,0.6);color:white;border-radius:30px;position:absolute"">-");
#nullable restore
#line 25 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                                                                                                                                                                           Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                        <div class=\"img1\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 962, "\"", 994, 2);
            WriteAttributeValue("", 969, "/Products/Detail/", 969, 17, true);
#nullable restore
#line 27 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 986, item.ID, 986, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8685a9c228a6e111b1136da969db4f15ee0dd72e8440", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1053, "~/Upload/Products/", 1053, 18, true);
#nullable restore
#line 27 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1071, item.Photo, 1071, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1148, "\"", 1180, 2);
            WriteAttributeValue("", 1155, "/WishList/Create/", 1155, 17, true);
#nullable restore
#line 29 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 1172, item.ID, 1172, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div style=\"position:absolute; top:5px; right:7px;\" class=\"heart\"></div></a>\r\n                        <div class=\"content1\">\r\n                            <p>");
#nullable restore
#line 31 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"text-decoration: line-through;  color:red;\">");
#nullable restore
#line 32 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                                                                             Write(string.Format("{0:#,#.}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫ </p>\r\n                            <p>");
#nullable restore
#line 33 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                          Write(string.Format("{0:#,#.}",item.Price - (item.Price * item.Discount) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫ </p>\r\n                            <div class=\"star\" style=\"text-align: center;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1708, "\"", 1745, 3);
            WriteAttributeValue("", 1715, "/Products/Star/", 1715, 15, true);
#nullable restore
#line 35 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 1730, item.ID, 1730, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1738, "?star=1", 1738, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8685a9c228a6e111b1136da969db4f15ee0dd72e12271", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1825, "\"", 1862, 3);
            WriteAttributeValue("", 1832, "/Products/Star/", 1832, 15, true);
#nullable restore
#line 36 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 1847, item.ID, 1847, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1855, "?star=2", 1855, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8685a9c228a6e111b1136da969db4f15ee0dd72e13843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1942, "\"", 1979, 3);
            WriteAttributeValue("", 1949, "/Products/Star/", 1949, 15, true);
#nullable restore
#line 37 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 1964, item.ID, 1964, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1972, "?star=3", 1972, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8685a9c228a6e111b1136da969db4f15ee0dd72e15415", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2059, "\"", 2096, 3);
            WriteAttributeValue("", 2066, "/Products/Star/", 2066, 15, true);
#nullable restore
#line 38 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 2081, item.ID, 2081, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2089, "?star=4", 2089, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8685a9c228a6e111b1136da969db4f15ee0dd72e16987", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2176, "\"", 2213, 3);
            WriteAttributeValue("", 2183, "/Products/Star/", 2183, 15, true);
#nullable restore
#line 39 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 2198, item.ID, 2198, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2206, "?star=5", 2206, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8685a9c228a6e111b1136da969db4f15ee0dd72e18559", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                            </div>\r\n                            <form action=\"#\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2376, "\"", 2401, 2);
            WriteAttributeValue("", 2383, "/Cart/Buy/", 2383, 10, true);
#nullable restore
#line 42 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 2393, item.ID, 2393, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <input type=\"button\" value=\"Add To Cart\"></a>\r\n                            </form>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 47 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </ul>

    </div>

    <!-- sort -->
    <div class=""sort"">
        <select style=""width: 200px; height: 30px; font-size: 16px;"" onchange=""location.href = '/Products/Index/?order='+this.value;"">
            <option value=""0"">Sắp xếp</option>
            <option ");
#nullable restore
#line 57 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                     if(strOrder=="priceAsc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 57 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"priceAsc\">Giá tăng dần</option>\r\n            <option ");
#nullable restore
#line 58 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                     if(strOrder=="priceDesc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 58 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"priceDesc\">Giá giảm dần</option>\r\n            <option ");
#nullable restore
#line 59 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                     if(strOrder=="naneAsc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 59 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"nameAsc\">Sắp xếp theo tên A-Z</option>\r\n            <option ");
#nullable restore
#line 60 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                     if(strOrder=="nameDesc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 60 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"nameDesc\">Sắp xếp theo tên Z-A</option>\r\n        </select>\r\n    </div>\r\n    <!-- /sort -->\r\n    <div class=\"phantrang\">\r\n        ");
#nullable restore
#line 65 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)Model,p=>Url.Action("Index",new{ page=p})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
