#pragma checksum "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Ls\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c715d9b948620fc156df237972567d994d0aad9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ls_Create), @"mvc.1.0.view", @"/Views/Ls/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ls/Create.cshtml", typeof(AspNetCore.Views_Ls_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c715d9b948620fc156df237972567d994d0aad9e", @"/Views/Ls/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d431beede74b481b62fef28e0937d278fd3062", @"/Views/_ViewImports.cshtml")]
    public class Views_Ls_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Ls\Create.cshtml"
  
    ViewData["Title"] = "Log in";

#line default
#line hidden
            BeginContext(44, 157, true);
            WriteLiteral("\r\n<div class=\"alert alert-success \" role=\"alert\">\r\n    Registration completed.\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4 offset-md-4\">\r\n        ");
            EndContext();
            BeginContext(201, 834, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c715d9b948620fc156df237972567d994d0aad9e4415", async() => {
                BeginContext(237, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(252, 23, false);
#line 13 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Ls\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(275, 231, true);
                WriteLiteral("\r\n            <h3 class=\"text-center\">Log in</h3>\r\n            <div class=\"form-group\">\r\n                <input type=\"email\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" placeholder=\"Email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 506, "\"", 529, 1);
#line 16 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Ls\Create.cshtml"
WriteAttributeValue("", 514, ViewData["13"], 514, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(530, 50, true);
                WriteLiteral(" required>\r\n            </div>\r\n\r\n            <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 580, "\"", 622, 3);
                WriteAttributeValue("", 588, "alert", 588, 5, true);
                WriteAttributeValue(" ", 593, "alert-danger", 594, 13, true);
#line 19 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Ls\Create.cshtml"
WriteAttributeValue(" ", 606, ViewData["11"], 607, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(623, 243, true);
                WriteLiteral(">Email is not found.</div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"password\" class=\"form-control\" id=\"exampleInputPassword1\" placeholder=\"Password\" name=\"password\" required>\r\n            </div>\r\n\r\n            <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 866, "\"", 908, 3);
                WriteAttributeValue("", 874, "alert", 874, 5, true);
                WriteAttributeValue(" ", 879, "alert-danger", 880, 13, true);
#line 25 "C:\Users\Administrator\source\repos\socialclone\socialclone\Views\Ls\Create.cshtml"
WriteAttributeValue(" ", 892, ViewData["12"], 893, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(909, 119, true);
                WriteLiteral(">Wrong password.</div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary btn-block\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1035, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
