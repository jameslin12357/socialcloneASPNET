#pragma checksum "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d72ec79c063fcfb4dfb64dc546035ab62d6d4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_Details), @"mvc.1.0.view", @"/Views/Topics/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topics/Details.cshtml", typeof(AspNetCore.Views_Topics_Details))]
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
#line 1 "C:\Users\mac\source\repos\socialclone\socialclone\Views\_ViewImports.cshtml"
using socialclone;

#line default
#line hidden
#line 2 "C:\Users\mac\source\repos\socialclone\socialclone\Views\_ViewImports.cshtml"
using socialclone.Models;

#line default
#line hidden
#line 1 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d72ec79c063fcfb4dfb64dc546035ab62d6d4e", @"/Views/Topics/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d431beede74b481b62fef28e0937d278fd3062", @"/Views/_ViewImports.cshtml")]
    public class Views_Topics_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/gettopicfollowing.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/topicfollowunfollow.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
  
    ViewData["Title"] = "Topic";

#line default
#line hidden
            BeginContext(64, 79, true);
            WriteLiteral("\r\n\r\n<div class=\"card m-auto mb-15 text-center\" style=\"width: 25rem;\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 143, "\"", 170, 1);
#line 9 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
WriteAttributeValue("", 149, ViewData["imageurl"], 149, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(171, 110, true);
            WriteLiteral(" id=\"profileImg\" class=\"card-img-top\" alt=\"...\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(282, 16, false);
#line 11 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                          Write(ViewData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(298, 36, true);
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
            EndContext();
            BeginContext(335, 23, false);
#line 12 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                        Write(ViewData["description"]);

#line default
#line hidden
            EndContext();
            BeginContext(358, 52, true);
            WriteLiteral("</p>\r\n        <div class=\"mb-15\"><span class=\"mr-3\">");
            EndContext();
            BeginContext(411, 22, false);
#line 13 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                                         Write(ViewData["postscount"]);

#line default
#line hidden
            EndContext();
            BeginContext(433, 107, true);
            WriteLiteral(" Posts</span><span id=\"topicfollowingmodaltoggleopen\" class=\"cursorPointer\"><span id=\"topicfollowingcount\">");
            EndContext();
            BeginContext(541, 26, false);
#line 13 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                                                                                                                                                                           Write(ViewData["followingcount"]);

#line default
#line hidden
            EndContext();
            BeginContext(567, 32, true);
            WriteLiteral("</span> Followers</span></div>\r\n");
            EndContext();
#line 14 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
         if (ViewData["isAuthenticated"] as string == "true")
        {

#line default
#line hidden
            BeginContext(673, 75, true);
            WriteLiteral("            <button id=\"topicfollowunfollowbutton\" class=\"btn btn-primary\">");
            EndContext();
            BeginContext(749, 26, false);
#line 16 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                                                                      Write(ViewData["followedstatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(775, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 17 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(797, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 22 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
 foreach (DataRow dr in (ViewData["posts"] as DataRowCollection))
{

#line default
#line hidden
            BeginContext(891, 69, true);
            WriteLiteral("    <div class=\"card m-auto mb-15\" style=\"width: 25rem;\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 960, "\"", 991, 2);
            WriteAttributeValue("", 967, "/posts/details/", 967, 15, true);
#line 25 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
WriteAttributeValue("", 982, dr["id"], 982, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(992, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 997, "\"", 1018, 1);
#line 25 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
WriteAttributeValue("", 1003, dr["imageurl"], 1003, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1019, 85, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\"></a>\r\n        <div class=\"card-body\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1104, "\"", 1135, 2);
            WriteAttributeValue("", 1111, "/posts/details/", 1111, 15, true);
#line 27 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
WriteAttributeValue("", 1126, dr["id"], 1126, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1136, 42, true);
            WriteLiteral(">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1179, 10, false);
#line 28 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                                  Write(dr["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 61, true);
            WriteLiteral("</h5>\r\n            </a>\r\n            <div><span class=\"mr-3\">");
            EndContext();
            BeginContext(1251, 12, false);
#line 30 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                               Write(dr["userid"]);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 13, true);
            WriteLiteral("</span><span>");
            EndContext();
            BeginContext(1277, 13, false);
#line 30 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                                                         Write(dr["topicid"]);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 48, true);
            WriteLiteral("</span></div>\r\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(1339, 17, false);
#line 31 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                            Write(dr["description"]);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 24, true);
            WriteLiteral("</p>\r\n            <span>");
            EndContext();
            BeginContext(1381, 13, false);
#line 32 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
             Write(dr["created"]);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 37, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 35 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"

}

#line default
#line hidden
            BeginContext(1436, 728, true);
            WriteLiteral(@"<div id=""topicfollowingmodal"" class=""modal popupmodal"" tabindex=""-1"" role=""dialog"">
    <div id=""deleteprofilemodalinner"" class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Topic Followers</h5>
                <button id=""topicfollowingmodaltoggleclose"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""topicfollowingmodalbody"" class=""modal-body jsmodal"">

            </div>

        </div>
    </div>
</div>

<div id=""datatopicid"" class=""Hidden"" data-topic-id=""");
            EndContext();
            BeginContext(2165, 15, false);
#line 54 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
                                               Write(ViewData["rid"]);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 10, true);
            WriteLiteral("\"></div>\r\n");
            EndContext();
            BeginContext(2190, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d72ec79c063fcfb4dfb64dc546035ab62d6d4e12945", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"
 if (ViewData["isAuthenticated"] as string == "true")
{

#line default
#line hidden
            BeginContext(2299, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2303, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d72ec79c063fcfb4dfb64dc546035ab62d6d4e14408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Users\mac\source\repos\socialclone\socialclone\Views\Topics\Details.cshtml"

}

#line default
#line hidden
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
