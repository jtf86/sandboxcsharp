#pragma checksum "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e00350e7a92fae79e4b3ac5e4fee839c6678cd30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_AddCategory), @"mvc.1.0.view", @"/Views/Items/AddCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/AddCategory.cshtml", typeof(AspNetCore.Views_Items_AddCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00350e7a92fae79e4b3ac5e4fee839c6678cd30", @"/Views/Items/AddCategory.cshtml")]
    public class Views_Items_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.CategoryItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(41, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 3 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\AddCategory.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(94, 29, false);
#line 5 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\AddCategory.cshtml"
   Write(Html.Label("Select Category"));

#line default
#line hidden
            EndContext();
            BeginContext(134, 31, false);
#line 6 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\AddCategory.cshtml"
   Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
            EndContext();
            BeginContext(167, 57, true);
            WriteLiteral("        <input type=\"submit\" value=\"Add to category\" />\r\n");
            EndContext();
#line 8 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\AddCategory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.CategoryItem> Html { get; private set; }
    }
}
#pragma warning restore 1591