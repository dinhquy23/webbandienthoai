#pragma checksum "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0fe2a036cb9a6328520bf99638ee0451478078f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Category), @"mvc.1.0.view", @"/Views/Products/Category.cshtml")]
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
#line 6 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0fe2a036cb9a6328520bf99638ee0451478078f", @"/Views/Products/Category.cshtml")]
    public class Views_Products_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
  

    Layout = "~/Views/Shared/TrangTrong.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
  
    int _CategoryID = Convert.ToInt32(ViewBag.CategoryID);
    string strOrder = !String.IsNullOrEmpty(Context.Request.Query["order"]) ? Context.Request.Query["order"] : "";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0fe2a036cb9a6328520bf99638ee0451478078f5699", async() => {
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
            WriteLiteral("\r\n<div class=\"left\">\r\n    <div class=\"title\"><a href=\"#\"><h2>");
#nullable restore
#line 26 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                                  Write(GetCategory(_CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></a></div>\r\n    <div class=\"main-content\">\r\n        <ul>\r\n");
#nullable restore
#line 29 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li>

                    <div class=""product1"" style=""position:relative;"">
                        <div style=""width:30px; line-height:30px; text-align:center; z-index:3; background:rgba(246,0,0,0.6);color:white;border-radius:30px;position:absolute"">-");
#nullable restore
#line 34 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                                                                                                                                                                           Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                        <div class=\"img1\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1279, "\"", 1311, 2);
            WriteAttributeValue("", 1286, "/Products/Detail/", 1286, 17, true);
#nullable restore
#line 36 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 1303, item.ID, 1303, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0fe2a036cb9a6328520bf99638ee0451478078f8724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1370, "~/Upload/Products/", 1370, 18, true);
#nullable restore
#line 36 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
AddHtmlAttributeValue("", 1388, item.Photo, 1388, 11, false);

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
            BeginWriteAttribute("href", " href=\"", 1465, "\"", 1497, 2);
            WriteAttributeValue("", 1472, "/WishList/Create/", 1472, 17, true);
#nullable restore
#line 38 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 1489, item.ID, 1489, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div style=\"position:absolute; top:5px; right:7px;\" class=\"heart\"></div></a>\r\n                        <div class=\"content1\">\r\n                            <p>");
#nullable restore
#line 40 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"text-decoration: line-through;  color:red;\">");
#nullable restore
#line 41 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                                                                             Write(string.Format("{0:#,#.}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫ </p>\r\n                            <p>");
#nullable restore
#line 42 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                          Write(string.Format("{0:#,#.}",item.Price - (item.Price * item.Discount) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫ </p>\r\n                            <div class=\"star\" style=\"text-align: center;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2025, "\"", 2062, 3);
            WriteAttributeValue("", 2032, "/Products/Star/", 2032, 15, true);
#nullable restore
#line 44 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 2047, item.ID, 2047, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2055, "?star=1", 2055, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0fe2a036cb9a6328520bf99638ee0451478078f12573", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2142, "\"", 2179, 3);
            WriteAttributeValue("", 2149, "/Products/Star/", 2149, 15, true);
#nullable restore
#line 45 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 2164, item.ID, 2164, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2172, "?star=2", 2172, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0fe2a036cb9a6328520bf99638ee0451478078f14148", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2259, "\"", 2296, 3);
            WriteAttributeValue("", 2266, "/Products/Star/", 2266, 15, true);
#nullable restore
#line 46 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 2281, item.ID, 2281, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2289, "?star=3", 2289, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0fe2a036cb9a6328520bf99638ee0451478078f15723", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2376, "\"", 2413, 3);
            WriteAttributeValue("", 2383, "/Products/Star/", 2383, 15, true);
#nullable restore
#line 47 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 2398, item.ID, 2398, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2406, "?star=4", 2406, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0fe2a036cb9a6328520bf99638ee0451478078f17298", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2493, "\"", 2530, 3);
            WriteAttributeValue("", 2500, "/Products/Star/", 2500, 15, true);
#nullable restore
#line 48 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 2515, item.ID, 2515, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2523, "?star=5", 2523, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0fe2a036cb9a6328520bf99638ee0451478078f18873", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2693, "\"", 2718, 2);
            WriteAttributeValue("", 2700, "/Cart/Buy/", 2700, 10, true);
#nullable restore
#line 51 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 2710, item.ID, 2710, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <input type=\"button\" value=\"Add To Cart\"></a>\r\n                            </form>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 56 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n\r\n    </div>\r\n\r\n    <!-- sort -->\r\n    <div class=\"sort\">\r\n        <select style=\"width: 200px; height: 30px; font-size: 16px;\"");
            BeginWriteAttribute("onchange", " onchange=\"", 3047, "\"", 3127, 5);
            WriteAttributeValue("", 3058, "location.href", 3058, 13, true);
            WriteAttributeValue(" ", 3071, "=", 3072, 2, true);
            WriteAttributeValue(" ", 3073, "\'/Products/Category/", 3074, 21, true);
#nullable restore
#line 64 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
WriteAttributeValue("", 3094, _CategoryID, 3094, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3106, "/?order=\'+this.value;", 3106, 21, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <option value=\"0\">Sắp xếp</option>\r\n            <option ");
#nullable restore
#line 66 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                     if(strOrder=="priceAsc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 66 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"priceAsc\">Giá tăng dần</option>\r\n            <option ");
#nullable restore
#line 67 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                     if(strOrder=="priceDesc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 67 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"priceDesc\">Giá giảm dần</option>\r\n            <option ");
#nullable restore
#line 68 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                     if(strOrder=="naneAsc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 68 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"nameAsc\">Sắp xếp theo tên A-Z</option>\r\n            <option ");
#nullable restore
#line 69 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                     if(strOrder=="nameDesc"){

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 69 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"nameDesc\">Sắp xếp theo tên Z-A</option>\r\n        </select>\r\n    </div>\r\n    <!-- /sort -->\r\n    <div class=\"phantrang\">\r\n        ");
#nullable restore
#line 74 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
   Write(Html.PagedListPager((IPagedList)Model,p=>Url.Action("Category",new{page=p})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Products\Category.cshtml"
            
    public MyDbContext db = new MyDbContext();

    public string GetCategory(int _CategoryID)
    {
        Categories record = db.Categories.Where(item => item.ID == _CategoryID).FirstOrDefault();
        return record.Name != null ? record.Name : "";
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