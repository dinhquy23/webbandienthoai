#pragma checksum "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e295563dd6a25b316d851cde535a821190e7cb19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#line 4 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e295563dd6a25b316d851cde535a821190e7cb19", @"/Areas/Admin/Views/Users/Index.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12"">
    <div style=""margin-bottom:5px; margin-left:10px; margin-top:10px"">
        <a href=""/Admin/Users/Create"" class=""btn btn-primary"">Add user</a>
    </div>
    <div class=""panel panel-primary"">
        <div class=""panel-heading"" style=""margin-left:10px; font-weight:bold"">List User</div>
        <div class=""panel-body"" style=""margin-left:10px; margin-right:10px"">
            <table  class=""table table-bordered table-hover"">
                <tr>
                    <th>Fullname</th>
                    <th>Email</th>
                    <th style=""width:100px;""></th>
                </tr>
");
#nullable restore
#line 20 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 23 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center;\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1017, "\"", 1052, 2);
            WriteAttributeValue("", 1024, "/Admin/Users/Update/", 1024, 20, true);
#nullable restore
#line 26 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 1044, item.ID, 1044, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>&nbsp;\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1100, "\"", 1135, 2);
            WriteAttributeValue("", 1107, "/Admin/Users/Delete/", 1107, 20, true);
#nullable restore
#line 27 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 1127, item.ID, 1127, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return window.confirm(\'Are you sure?\');\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <style type=\"text/css\">\r\n                .pagination {\r\n                    padding: 0px;\r\n                    margin: 0px;\r\n                }\r\n            </style>\r\n            ");
#nullable restore
#line 38 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Users\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, p=>Url.Action("Index",new{page=p})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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