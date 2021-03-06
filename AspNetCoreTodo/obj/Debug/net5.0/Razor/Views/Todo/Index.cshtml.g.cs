#pragma checksum "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ba9bea36cf64120e17885aff8e90141ad1fa5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
#line 1 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ba9bea36cf64120e17885aff8e90141ad1fa5f", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Manage your todo list";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
#nullable restore
#line 7 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    \r\n        \r\n\r\n");
#nullable restore
#line 11 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""box"">
            <div class=""item"">

            <label class=""checkitem""> 
                <input type=""checkbox""> 
                <span class=""checkmark""></span>
            </label>
            
            </div>
            <div class=""item""> ");
#nullable restore
#line 22 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n            <div class=\"item\"> ");
#nullable restore
#line 23 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
                          Write(item.DueAt.Humanize());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n        </div>\r\n");
#nullable restore
#line 25 "D:\asp.net\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    \r\n\r\n\r\n\r\n\r\n    <div class=\"panel-footer add-item-form\">\r\n    <!-- TODO: Add item form -->\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
