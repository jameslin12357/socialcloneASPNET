#pragma checksum "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1413d2062b35d0ba17ea4f6bd5d538b87088034f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comments_Details), @"mvc.1.0.view", @"/Views/Comments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comments/Details.cshtml", typeof(AspNetCore.Views_Comments_Details))]
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
#line 1 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\_ViewImports.cshtml"
using socialclone;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\_ViewImports.cshtml"
using socialclone.Models;

#line default
#line hidden
#line 1 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1413d2062b35d0ba17ea4f6bd5d538b87088034f", @"/Views/Comments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d431beede74b481b62fef28e0937d278fd3062", @"/Views/_ViewImports.cshtml")]
    public class Views_Comments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deletecommentform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/deletecomment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
  
    ViewData["Title"] = "Comment";

#line default
#line hidden
            BeginContext(66, 119, true);
            WriteLiteral("\r\n\r\n<div class=\"card m-auto mb-15\" style=\"width: 25rem;\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(186, 23, false);
#line 10 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
                          Write(ViewData["description"]);

#line default
#line hidden
            EndContext();
            BeginContext(209, 36, true);
            WriteLiteral("</h5>\r\n        <div class=\"mb-15\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 245, "\"", 286, 2);
            WriteAttributeValue("", 252, "/users/details/", 252, 15, true);
#line 11 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
WriteAttributeValue("", 267, ViewData["userid"], 267, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(287, 20, true);
            WriteLiteral(" class=\"mr-3\"><span>");
            EndContext();
            BeginContext(308, 21, false);
#line 11 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
                                                                                      Write(ViewData["rusername"]);

#line default
#line hidden
            EndContext();
            BeginContext(329, 13, true);
            WriteLiteral("</span></a><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 342, "\"", 383, 2);
            WriteAttributeValue("", 349, "/posts/details/", 349, 15, true);
#line 11 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
WriteAttributeValue("", 364, ViewData["postid"], 364, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(384, 7, true);
            WriteLiteral("><span>");
            EndContext();
            BeginContext(392, 18, false);
#line 11 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
                                                                                                                                                                          Write(ViewData["postid"]);

#line default
#line hidden
            EndContext();
            BeginContext(410, 55, true);
            WriteLiteral("</span></a></div>\r\n\r\n        <span class=\"mb-12 block\">");
            EndContext();
            BeginContext(466, 19, false);
#line 13 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
                             Write(ViewData["created"]);

#line default
#line hidden
            EndContext();
            BeginContext(485, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 14 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
         if (ViewData["idonly"] as string == ViewData["userid"] as string)
        {

#line default
#line hidden
            BeginContext(581, 101, true);
            WriteLiteral("        <div><button id=\"deletecommentmodaltoggleopen\" class=\"btn btn-danger\">Delete</button></div>\r\n");
            EndContext();
#line 17 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(693, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 21 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
 if (ViewData["idonly"] as string == ViewData["userid"] as string)
{

#line default
#line hidden
            BeginContext(786, 807, true);
            WriteLiteral(@"    <div id=""deletecommentmodal"" class=""modal popupmodal"" tabindex=""-1"" role=""dialog"">
        <div id=""deleteprofilemodalinner"" class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Confirm delete comment</h5>
                    <button id=""deletecommentmodaltoggleclose"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-footer"">
                    <button id=""deletecommentbutton"" type=""button"" class=""btn btn-danger"">Delete</button>
                </div>
            </div>
        </div>
    </div>
    ");
            EndContext();
            BeginContext(1593, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1413d2062b35d0ba17ea4f6bd5d538b87088034f10069", async() => {
                BeginContext(1694, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1705, 23, false);
#line 39 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(1728, 53, true);
                WriteLiteral("\r\n        <button type=\"submit\">Submit</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1645, "/comments/delete/", 1645, 17, true);
#line 38 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
AddHtmlAttributeValue("", 1662, ViewData["rid"], 1662, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1788, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1794, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1413d2062b35d0ba17ea4f6bd5d538b87088034f12838", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Comments\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1844, 20, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
