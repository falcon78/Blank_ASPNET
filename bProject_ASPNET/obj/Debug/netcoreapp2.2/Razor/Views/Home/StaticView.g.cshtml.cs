#pragma checksum "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\StaticView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138360fe430e4e15ca6cf6725dd10b034b547cfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StaticView), @"mvc.1.0.view", @"/Views/Home/StaticView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/StaticView.cshtml", typeof(AspNetCore.Views_Home_StaticView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138360fe430e4e15ca6cf6725dd10b034b547cfc", @"/Views/Home/StaticView.cshtml")]
    public class Views_Home_StaticView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bProject_ASPNET.ViewModels.HomeStaticViewViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 47, true);
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(106, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138360fe430e4e15ca6cf6725dd10b034b547cfc3002", async() => {
                BeginContext(112, 23, true);
                WriteLiteral("\r\n    <title></title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(144, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138360fe430e4e15ca6cf6725dd10b034b547cfc4207", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("\r\n    <h3>");
                EndContext();
                BeginContext(161, 15, false);
#line 8 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\StaticView.cshtml"
   Write(Model.PageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(176, 33, true);
                WriteLiteral("</h3>\r\n    <div>\r\n        Name : ");
                EndContext();
                BeginContext(210, 15, false);
#line 10 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\StaticView.cshtml"
          Write(Model.user.Name);

#line default
#line hidden
                EndContext();
                BeginContext(225, 42, true);
                WriteLiteral(" \r\n    </div>\r\n    <div>\r\n        Email : ");
                EndContext();
                BeginContext(268, 16, false);
#line 13 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\StaticView.cshtml"
           Write(Model.user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(284, 39, true);
                WriteLiteral(" \r\n    </div>\r\n    <div>\r\n        ID : ");
                EndContext();
                BeginContext(324, 13, false);
#line 16 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\StaticView.cshtml"
        Write(Model.user.ID);

#line default
#line hidden
                EndContext();
                BeginContext(337, 15, true);
                WriteLiteral(" \r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(359, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bProject_ASPNET.ViewModels.HomeStaticViewViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
