#pragma checksum "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d0ae0907c9a267242b1196994b4ea4c3991be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchPrice), @"mvc.1.0.view", @"/Views/Search/SearchPrice.cshtml")]
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
#line 6 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d0ae0907c9a267242b1196994b4ea4c3991be7", @"/Views/Search/SearchPrice.cshtml")]
    public class Views_Search_SearchPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
  

    Layout = "~/Views/Shared/TrangTrong.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
  
    int _CategoryID = Convert.ToInt32(ViewBag.CategoryID);
    string strOrder = !String.IsNullOrEmpty(Context.Request.Query["order"]) ? Context.Request.Query["order"] : "";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1d0ae0907c9a267242b1196994b4ea4c3991be75710", async() => {
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
            WriteLiteral("\r\n    <div class=\"left\">\r\n        <div class=\"title\"><a href=\"#\"><h2>Tìm kiếm theo giá từ ");
#nullable restore
#line 26 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                                                           Write(string.Format("{0:#,#.}", ViewBag.fromPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫ đến ");
#nullable restore
#line 26 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                                                                                                               Write(string.Format("{0:#,#.}", ViewBag.toPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫</h2></a></div>\r\n        <div class=\"main-content\">\r\n            <ul>\r\n");
#nullable restore
#line 29 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li>
                    
                       <div class=""product1"" style=""position:relative;"">
                        <div style=""width:30px; line-height:30px; text-align:center; z-index:3; background:rgba(246,0,0,0.6);color:white;border-radius:30px;position:absolute"">-");
#nullable restore
#line 34 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                                                                                                                                                                           Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                        <div class=\"img1\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1450, 2);
            WriteAttributeValue("", 1425, "/Products/Detail/", 1425, 17, true);
#nullable restore
#line 36 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 1442, item.ID, 1442, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1d0ae0907c9a267242b1196994b4ea4c3991be79213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1509, "~/Upload/Products/", 1509, 18, true);
#nullable restore
#line 36 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
AddHtmlAttributeValue("", 1527, item.Photo, 1527, 11, false);

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
            BeginWriteAttribute("href", " href=\"", 1604, "\"", 1636, 2);
            WriteAttributeValue("", 1611, "/WishList/Create/", 1611, 17, true);
#nullable restore
#line 38 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 1628, item.ID, 1628, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div style=\"position:absolute; top:5px; right:7px;\" class=\"heart\"></div></a>\r\n                        <div class=\"content1\">\r\n                            <p>");
#nullable restore
#line 40 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"text-decoration: line-through;  color:red;\">");
#nullable restore
#line 41 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                                                                             Write(string.Format("{0:#,#.}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫ </p>\r\n                            <p>");
#nullable restore
#line 42 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                          Write(string.Format("{0:#,#.}",item.Price - (item.Price * item.Discount) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫ </p>\r\n                            <div class=\"star\" style=\"text-align: center;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2164, "\"", 2201, 3);
            WriteAttributeValue("", 2171, "/Products/Star/", 2171, 15, true);
#nullable restore
#line 44 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 2186, item.ID, 2186, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2194, "?star=1", 2194, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1d0ae0907c9a267242b1196994b4ea4c3991be713068", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2281, "\"", 2318, 3);
            WriteAttributeValue("", 2288, "/Products/Star/", 2288, 15, true);
#nullable restore
#line 45 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 2303, item.ID, 2303, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2311, "?star=2", 2311, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1d0ae0907c9a267242b1196994b4ea4c3991be714644", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2398, "\"", 2435, 3);
            WriteAttributeValue("", 2405, "/Products/Star/", 2405, 15, true);
#nullable restore
#line 46 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 2420, item.ID, 2420, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2428, "?star=3", 2428, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1d0ae0907c9a267242b1196994b4ea4c3991be716220", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2515, "\"", 2552, 3);
            WriteAttributeValue("", 2522, "/Products/Star/", 2522, 15, true);
#nullable restore
#line 47 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 2537, item.ID, 2537, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2545, "?star=4", 2545, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1d0ae0907c9a267242b1196994b4ea4c3991be717796", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2632, "\"", 2669, 3);
            WriteAttributeValue("", 2639, "/Products/Star/", 2639, 15, true);
#nullable restore
#line 48 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 2654, item.ID, 2654, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2662, "?star=5", 2662, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1d0ae0907c9a267242b1196994b4ea4c3991be719372", async() => {
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
            BeginWriteAttribute("href", " href=\"", 2832, "\"", 2857, 2);
            WriteAttributeValue("", 2839, "/Cart/Buy/", 2839, 10, true);
#nullable restore
#line 51 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
WriteAttributeValue("", 2849, item.ID, 2849, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <input type=\"button\" value=\"Add To Cart\"></a>\r\n                            </form>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 56 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n            </ul>\r\n        </div>\r\n        <div class=\"phantrang\">\r\n            ");
#nullable restore
#line 61 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
       Write(Html.PagedListPager((IPagedList)Model,p=>Url.Action("SearchPrice",new{page=p})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Views\Search\SearchPrice.cshtml"
            
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
