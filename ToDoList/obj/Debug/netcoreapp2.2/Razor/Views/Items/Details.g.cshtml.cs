#pragma checksum "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2e8b8c73936ae6e4e726b090523123c9fd1185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Details.cshtml", typeof(AspNetCore.Views_Items_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2e8b8c73936ae6e4e726b090523123c9fd1185", @"/Views/Items/Details.cshtml")]
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
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
            BeginContext(29, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(39, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba2e8b8c73936ae6e4e726b090523123c9fd11852899", async() => {
                BeginContext(45, 43, true);
                WriteLiteral("\r\n    <title>To Do List - Details</title>\r\n");
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
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(97, 299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba2e8b8c73936ae6e4e726b090523123c9fd11854121", async() => {
                BeginContext(103, 40, true);
                WriteLiteral("\r\n    <h2>Details</h2>\r\n    <hr />\r\n    ");
                EndContext();
                BeginContext(144, 47, false);
#line 10 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(191, 2, true);
                WriteLiteral(": ");
                EndContext();
                BeginContext(194, 43, false);
#line 10 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(237, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Details.cshtml"
     foreach(var link in Model.Categories)
    {

#line default
#line hidden
                BeginContext(290, 12, true);
                WriteLiteral("        <li>");
                EndContext();
                BeginContext(303, 18, false);
#line 13 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Details.cshtml"
       Write(link.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(321, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 14 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(335, 7, true);
                WriteLiteral("    <p>");
                EndContext();
                BeginContext(343, 40, false);
#line 15 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Details.cshtml"
  Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(383, 6, true);
                WriteLiteral("</p>\r\n");
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
            BeginContext(396, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
