#pragma checksum "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f8ac030c509923e06ebd27213884c8719759db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Create.cshtml")]
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
#line 3 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f8ac030c509923e06ebd27213884c8719759db", @"/Areas/Admin/Views/Products/Create.cshtml")]
    public class Areas_Admin_Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("language", new global::Microsoft.AspNetCore.Html.HtmlString("javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f8ac030c509923e06ebd27213884c8719759db5314", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 1271, "\"", 1281, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 1310, "\"", 1320, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <title>Register - SB Admin</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4f8ac030c509923e06ebd27213884c8719759db6204", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f8ac030c509923e06ebd27213884c8719759db7382", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js\" crossorigin=\"anonymous\"></script>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f8ac030c509923e06ebd27213884c8719759db9408", async() => {
                WriteLiteral(@"
    <div id=""layoutAuthentication"" style=""margin-bottom:50px;"">
        <div id=""layoutAuthentication_content"">
            <main>
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-11"">
                            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Create Products</h3></div>
                                <div class=""card-body"">
                                    <form method=""post"" enctype=""multipart/form-data""");
                BeginWriteAttribute("action", " action=\"", 2314, "\"", 2323, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">
                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    <input class=""form-control"" id=""inputName"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2656, "\"", 2710, 1);
                WriteAttributeValue("", 2664, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 59 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                   if (Model != null) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                               }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 2664, 46, false);
                EndWriteAttribute();
                WriteLiteral(@" name=""Name"" required />
                                                    <label for=""inputName"">Name</label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">
                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    <input class=""form-control"" id=""inputPrice"" style=""width:100%;"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 3332, "\"", 3387, 1);
                WriteAttributeValue("", 3340, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 67 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                        if (Model != null) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                             Write(Model.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                                     }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 3340, 47, false);
                EndWriteAttribute();
                WriteLiteral(@" name=""Price"" required />
                                                    <label for=""inputPrice"">Price</label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">
                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    <input class=""form-control"" id=""inputDiscount"" style=""width:100%;"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4015, "\"", 4073, 1);
                WriteAttributeValue("", 4023, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 75 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                           if (Model != null) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                Write(Model.Discount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                                           }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 4023, 50, false);
                EndWriteAttribute();
                WriteLiteral(@" name=""Discount"" required />
                                                    <label for=""inputDiscount"">Discount</label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">
                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    <select name=""CategoryID"" class=""form-control"" id=""Category"" style=""width:100%;"">
");
#nullable restore
#line 84 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                          
                                                            List<Categories> Categories = GetListCategory();
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                         foreach (Categories itemCategory in Categories)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <option ");
#nullable restore
#line 89 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                     if (Model != null && Model.CategoryID == itemCategory.ID) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(" selected");
#nullable restore
#line 89 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                       }

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 89 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                           Write(itemCategory.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 89 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                             Write(itemCategory.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 90 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                            List<Categories> CategoriesSub = GetListCategorySub(itemCategory.ID);
                                                            foreach (Categories itemSub in CategoriesSub)
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <option ");
#nullable restore
#line 93 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                         if (Model != null && Model.CategoryID == itemSub.ID) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(" selected");
#nullable restore
#line 93 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 93 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                          Write(itemSub.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
#nullable restore
#line 93 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                                                     Write(itemSub.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 94 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                            }
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    </select>
                                                    <label for=""Category"">Category</label>
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""row"" style=""margin-top:5px;"">
                                            <div class=""col-md-2"">Tags</div>
                                            <div class=""col-md-10"" style="" height: 200px; overflow: scroll;"">
                                                <table class=""table"">
");
#nullable restore
#line 106 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                      
                                                        List<Tags> _ListRecord = ListTags();
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                     foreach (var item in _ListRecord)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <tr>\r\n                                                            <td><input type=\"checkbox\" ");
#nullable restore
#line 112 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                        if (Model != null && ChechExists(Model.ID, item.ID)) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("checked");
#nullable restore
#line 112 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"tag_");
#nullable restore
#line 112 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                           Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"  id=\"tag_");
#nullable restore
#line 112 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                                              Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />&nbsp;&nbsp;<label");
                BeginWriteAttribute("for", " for=\"", 7256, "\"", 7274, 2);
                WriteAttributeValue("", 7262, "tag_", 7262, 4, true);
#nullable restore
#line 112 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
WriteAttributeValue("", 7266, item.ID, 7266, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 112 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 114 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </table>
                                            </div>
                                        </div>


                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">

                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    Photo
                                                    <input type=""file"" id=""inputPhoto"" name=""Photo"" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">
                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    Hot Products
                             ");
                WriteLiteral("                       <input type=\"checkbox\" name=\"Hot\" id=\"Hot\" ");
#nullable restore
#line 133 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                if (Model != null && Model.Hot == 1) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(" checked ");
#nullable restore
#line 133 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/>

                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">
                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    Description
                                                    <textarea name=""Description""> ");
#nullable restore
#line 142 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                   if (Model != null)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                             Write(Model.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                           
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    </textarea>
                                                    <script language=""javascript"">
                                                        CKEDITOR.replace(""Description"")
                                                    </script>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row mb-3"">
                                            <div class=""col-md-12"">
                                                <div class=""form-floating mb-3 mb-md-0"">
                                                    Content
                                                    <textarea name=""Content""> ");
#nullable restore
#line 157 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                               if (Model != null)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                             Write(Model.Content);

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
                                                                                       
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    </textarea>
                                                    <script language=""javascript"">
                                                        CKEDITOR.replace(""Content"")
                                                    </script>
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""mt-4 mb-0"">
                                            <div class=""d-grid"">
                                                <input type=""submit"" class=""btn btn-primary btn-block"" value=""Create Products"">

                                            </div>
                                        </div>

                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
                WriteLiteral("            </main>\r\n        </div>\r\n    </div>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f8ac030c509923e06ebd27213884c8719759db32821", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
#line 5 "D:\Lập trình asp.net\Back-end\Bài tập\Project\Areas\Admin\Views\Products\Create.cshtml"
 
    public MyDbContext db = new MyDbContext();
    public List<Categories> GetListCategory()
    {
        List<Categories> _ListRecord = db.Categories.Where(item => item.ParentID == 0).OrderByDescending(item => item.ID).ToList();
        return _ListRecord;
    }
    public List<Categories> GetListCategorySub(int _CategoryID)
    {
        List<Categories> _ListRecord = db.Categories.Where(item => item.ParentID == _CategoryID).OrderByDescending(item => item.ID).ToList();
        return _ListRecord;
    }
    public List<Tags> ListTags()
    {
        List<Tags> _ListRecord = db.Tags.OrderByDescending(item => item.ID).ToList();
        return _ListRecord;
    }
    public bool ChechExists(int _ProductID, int _TagID)
    {
        int intCount = db.ProductsTags.Where(item => item.ProductID == _ProductID && item.TagID == _TagID).Count();
        if (intCount > 0)
        {
            return true;
        }
        return false;
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
