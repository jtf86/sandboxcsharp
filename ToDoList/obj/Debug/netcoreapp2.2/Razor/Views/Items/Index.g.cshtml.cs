#pragma checksum "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ca8e2ea1c244db83201dca17376ccd8e7cccfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ca8e2ea1c244db83201dca17376ccd8e7cccfb", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoList.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(40, 45, true);
            WriteLiteral("        \r\n    <h1>To Do List</h1>\r\n    <ul>\r\n");
            EndContext();
#line 5 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(133, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(150, 59, false);
#line 7 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Index.cshtml"
           Write(Html.DisplayFor(currentItemDescription => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(209, 22, true);
            WriteLiteral("</li>\r\n            <p>");
            EndContext();
            BeginContext(232, 95, false);
#line 8 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Index.cshtml"
          Write(Html.ActionLink($"See Details for \"{item.Description}\"", "Details", new { id = item.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(327, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(344, 20, true);
            WriteLiteral("    </ul>\r\n\r\n    <p>");
            EndContext();
            BeginContext(365, 40, false);
#line 12 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Index.cshtml"
  Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(405, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoList.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
