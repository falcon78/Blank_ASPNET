#pragma checksum "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\ViewAllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e794a264c2c3cd83b26b09847ebe210c9412ba66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewAllUsers), @"mvc.1.0.view", @"/Views/Home/ViewAllUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewAllUsers.cshtml", typeof(AspNetCore.Views_Home_ViewAllUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e794a264c2c3cd83b26b09847ebe210c9412ba66", @"/Views/Home/ViewAllUsers.cshtml")]
    public class Views_Home_ViewAllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<bProject_ASPNET.Models.User>>
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
            BeginContext(49, 55, true);
            WriteLiteral("\r\n    <html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n    ");
            EndContext();
            BeginContext(104, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e794a264c2c3cd83b26b09847ebe210c9412ba663014", async() => {
                BeginContext(110, 31, true);
                WriteLiteral("\r\n        <title></title>\r\n    ");
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
            BeginContext(148, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(154, 556, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e794a264c2c3cd83b26b09847ebe210c9412ba664231", async() => {
                BeginContext(160, 232, true);
                WriteLiteral("\r\n        <table>\r\n            <thead>\r\n                <tr>\r\n                    <th>ID</th>\r\n                    <th>Name</th>\r\n                    <th>Email</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 17 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\ViewAllUsers.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
                BeginContext(457, 52, true);
                WriteLiteral("                   <tr>\r\n                       <td>");
                EndContext();
                BeginContext(510, 7, false);
#line 20 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\ViewAllUsers.cshtml"
                      Write(user.ID);

#line default
#line hidden
                EndContext();
                BeginContext(517, 34, true);
                WriteLiteral("</td>\r\n                       <td>");
                EndContext();
                BeginContext(552, 9, false);
#line 21 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\ViewAllUsers.cshtml"
                      Write(user.Name);

#line default
#line hidden
                EndContext();
                BeginContext(561, 34, true);
                WriteLiteral("</td>\r\n                       <td>");
                EndContext();
                BeginContext(596, 10, false);
#line 22 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\ViewAllUsers.cshtml"
                      Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(606, 34, true);
                WriteLiteral("</td>\r\n                   </tr> \r\n");
                EndContext();
#line 24 "C:\Users\KHATRISUJAN\source\repos\bProject_ASPNET\bProject_ASPNET\Views\Home\ViewAllUsers.cshtml"
                }

#line default
#line hidden
                BeginContext(659, 44, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    ");
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
            BeginContext(710, 15, true);
            WriteLiteral("\r\n    </html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<bProject_ASPNET.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591