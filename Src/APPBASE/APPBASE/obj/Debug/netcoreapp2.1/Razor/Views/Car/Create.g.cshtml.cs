#pragma checksum "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\Car\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fce93ac7b294adb6d65e095d5e5818bbb36d80ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Create), @"mvc.1.0.view", @"/Views/Car/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Car/Create.cshtml", typeof(AspNetCore.Views_Car_Create))]
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
#line 1 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\_ViewImports.cshtml"
using APPBASE;

#line default
#line hidden
#line 2 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\_ViewImports.cshtml"
using APPBASE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce93ac7b294adb6d65e095d5e5818bbb36d80ff", @"/Views/Car/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8213c86c8e081f595c23c2761866d3b3e6bca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<APPBASE.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\Car\Create.cshtml"
  
    ViewData["Title"] = "Add Car";

#line default
#line hidden
            BeginContext(72, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(77, 17, false);
#line 6 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\Car\Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(106, 19, false);
#line 7 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\Car\Create.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(125, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
            BeginContext(134, 824, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf25d2910b154b65968ad2fbbd6eebc4", async() => {
                BeginContext(195, 178, true);
                WriteLiteral("\r\n    <!-- Input and Submit elements -->\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <label> Car Name</label>\r\n            <input type=\"text\" name=\"brand\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 373, "\"", 393, 1);
#line 14 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\Car\Create.cshtml"
WriteAttributeValue("", 381, Model.brand, 381, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(394, 170, true);
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <label> Car Year</label>\r\n            <input type=\"text\" name=\"year\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 564, "\"", 583, 1);
#line 21 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\Car\Create.cshtml"
WriteAttributeValue("", 572, Model.year, 572, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(584, 175, true);
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <label> Rental Price</label>\r\n            <input type=\"text\" name=\"price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 759, "\"", 779, 1);
#line 28 "E:\arns\ddtech\arinsuga.carrent\Src\APPBASE\APPBASE\Views\Car\Create.cshtml"
WriteAttributeValue("", 767, Model.price, 767, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(780, 171, true);
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <button type=\"submit\">Save</button>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APPBASE.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
