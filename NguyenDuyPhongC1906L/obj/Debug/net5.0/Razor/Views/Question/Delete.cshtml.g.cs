#pragma checksum "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd53deb6bd499fe8859c337f6916fcf5fb56685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Delete), @"mvc.1.0.view", @"/Views/Question/Delete.cshtml")]
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
#line 1 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/_ViewImports.cshtml"
using NguyenDuyPhongC1906L;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/_ViewImports.cshtml"
using NguyenDuyPhongC1906L.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd53deb6bd499fe8859c337f6916fcf5fb56685", @"/Views/Question/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf716552dce2fdb7421128ecf3331e8589ee15c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NguyenDuyPhongC1906L.Models.QuestionEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml"
  
    ViewData["Title"] = "Confirm Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-10 mx-auto py-4"">
    <div class=""card"">
        <div class=""card-header bg-primary text-uppercase text-white"">
            <h4>Are you sure you want to delete this?</h4>
        </div>
        <div class=""card-body"">
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 15 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 18 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml"
               Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 21 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 24 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n            </dl>\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd53deb6bd499fe8859c337f6916fcf5fb566855924", async() => {
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "acd53deb6bd499fe8859c337f6916fcf5fb566856194", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\n                <input type=\"button\" class=\"btn btn-primary\" value=\"Back To List\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1134, "\"", 1192, 3);
                WriteAttributeValue("", 1144, "location.href=\'", 1144, 15, true);
#nullable restore
#line 31 "/Users/phongnd/Projects/NguyenDuyPhongC1906L/NguyenDuyPhongC1906L/Views/Question/Delete.cshtml"
WriteAttributeValue("", 1159, Url.Action("Index", "Question"), 1159, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1191, "\'", 1191, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NguyenDuyPhongC1906L.Models.QuestionEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
