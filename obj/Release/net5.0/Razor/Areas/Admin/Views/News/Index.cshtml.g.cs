#pragma checksum "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d4b259f4f6b443f90eeca84233f73a817b39d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Index.cshtml")]
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
#line 7 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9d4b259f4f6b443f90eeca84233f73a817b39d7", @"/Areas/Admin/Views/News/Index.cshtml")]
    public class Areas_Admin_Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
  

    Layout = "~/Areas/Admin/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container-fluid px-4"">
    <h1 class=""mt-4"">News</h1>
    <div style=""margin-bottom:5px; margin-top:10px"">
    <a href=""/Admin/News/Create"" class=""btn btn-primary"">Add news</a>
    </div>
    <div class=""card mb-4"">
        <div class=""card-body"">
            <table id=""datatablesSimple"">
                <thead>
                    <tr>
                        <th style=""width:100px; text-align:center"">Image</th>
                        <th  style="" text-align:center"">Name</th>
                        <th  style="" text-align:center"">Hot News</th>
                        <th style="" text-align:center""></th>
                    </tr>
                    </thead>
                <tbody>

");
#nullable restore
#line 30 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <center>\r\n");
#nullable restore
#line 35 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
                                     if (item.Photo != null && File.Exists(Directory.GetCurrentDirectory() + "\\wwwroot\\Upload\\News\\" + item.Photo))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9d4b259f4f6b443f90eeca84233f73a817b39d75514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1360, "~/Upload/News/", 1360, 14, true);
#nullable restore
#line 37 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
AddHtmlAttributeValue("", 1374, item.Photo, 1374, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </center>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 42 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 44 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
                                 if (item.Hot == 1)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>Hot</center>");
#nullable restore
#line 46 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
                                                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td style=\"text-align:center;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1938, "\"", 1972, 2);
            WriteAttributeValue("", 1945, "/Admin/News/Update/", 1945, 19, true);
#nullable restore
#line 50 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
WriteAttributeValue("", 1964, item.ID, 1964, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>&nbsp;\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2024, "\"", 2058, 2);
            WriteAttributeValue("", 2031, "/Admin/News/Delete/", 2031, 19, true);
#nullable restore
#line 51 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"
WriteAttributeValue("", 2050, item.ID, 2050, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return window.confirm(\'Are you sure?\');\">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 54 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\News\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
