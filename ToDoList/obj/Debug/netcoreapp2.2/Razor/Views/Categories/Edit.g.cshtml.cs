#pragma checksum "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b12b1b62d23b19099bd3541dfb16c8d853fce032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Edit), @"mvc.1.0.view", @"/Views/Categories/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Edit.cshtml", typeof(AspNetCore.Views_Categories_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12b1b62d23b19099bd3541dfb16c8d853fce032", @"/Views/Categories/Edit.cshtml")]
    public class Views_Categories_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
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
            BeginContext(33, 12, true);
            WriteLiteral("\r\n<html>\r\n  ");
            EndContext();
            BeginContext(45, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12b1b62d23b19099bd3541dfb16c8d853fce0322919", async() => {
                BeginContext(51, 51, true);
                WriteLiteral("\r\n    <title>To Do List - Category Edit</title>\r\n  ");
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
            BeginContext(109, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
            BeginContext(113, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12b1b62d23b19099bd3541dfb16c8d853fce0324153", async() => {
                BeginContext(119, 61, true);
                WriteLiteral("\r\n    <h2>Edit</h2>\r\n    <hr />\r\n    <h4>Edit this category: ");
                EndContext();
                BeginContext(181, 36, false);
#line 10 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(217, 9, true);
                WriteLiteral("</h4>\r\n\r\n");
                EndContext();
#line 12 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
                BeginContext(273, 41, false);
#line 14 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml"
   Write(Html.HiddenFor(model => model.CategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(327, 34, false);
#line 16 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml"
   Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(372, 35, false);
#line 17 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml"
   Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(411, 46, true);
                WriteLiteral("        <input type=\"submit\" value=\"Save\" />\r\n");
                EndContext();
#line 20 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml"
    }

#line default
#line hidden
                BeginContext(464, 7, true);
                WriteLiteral("    <p>");
                EndContext();
                BeginContext(472, 40, false);
#line 21 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Categories\Edit.cshtml"
  Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(512, 10, true);
                WriteLiteral("</p>\r\n\r\n  ");
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
            BeginContext(529, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591