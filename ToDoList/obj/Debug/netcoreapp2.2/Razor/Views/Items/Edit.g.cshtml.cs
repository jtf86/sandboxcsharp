#pragma checksum "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b35f53e39dcd3fcc8badf3c81cd9a9d7b4626de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Edit), @"mvc.1.0.view", @"/Views/Items/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Edit.cshtml", typeof(AspNetCore.Views_Items_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b35f53e39dcd3fcc8badf3c81cd9a9d7b4626de", @"/Views/Items/Edit.cshtml")]
    public class Views_Items_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 45, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n<hr />\r\n<h4>Edit this item: ");
            EndContext();
            BeginContext(75, 43, false);
#line 5 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(118, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 6 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(160, 37, false);
#line 8 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
Write(Html.HiddenFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(206, 41, false);
#line 10 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(254, 42, false);
#line 11 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(305, 40, false);
#line 13 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
Write(Html.LabelFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(352, 31, false);
#line 14 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
            EndContext();
            BeginContext(387, 66, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 17 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(457, 40, false);
#line 18 "C:\Users\Mordor\Desktop\sandboxcsharp\ToDoList\Views\Items\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
