#pragma checksum "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed79f4e481936c9923083539e8e9651678e6599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoLists_PartialViews__SingleToDoListSummary), @"mvc.1.0.view", @"/Views/ToDoLists/PartialViews/_SingleToDoListSummary.cshtml")]
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
#line 1 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_aspnetmvc_ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_aspnetmvc_ui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_aspnetmvc_ui.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_domain_entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed79f4e481936c9923083539e8e9651678e6599", @"/Views/ToDoLists/PartialViews/_SingleToDoListSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c741f233b3cff62190b1e860a76f6eeadb16aaed", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoLists_PartialViews__SingleToDoListSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
  
    var totalTasksCount = Model.ToDoEntries.Count();
    var completedTasksCount = @Model.ToDoEntries.Count(entry => entry.Status == ToDoStatus.Completed);
    var tasksInProgressCount = @Model.ToDoEntries.Count(entry => entry.Status == ToDoStatus.InProgress);
    var notStartedTasksCount = @Model.ToDoEntries.Count(entry => entry.Status == ToDoStatus.NotStarted);
    var completionPercentage = totalTasksCount == 0 ? 0 : completedTasksCount / totalTasksCount;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"nav flex-column nav-pills\" id=\"v-pills-tab\" role=\"textbox\" aria-orientation=\"vertical\">\r\n    <h1>Summary of ");
#nullable restore
#line 12 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
              Write(Model.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ToDo list</h1>\r\n    <span>Completion: ");
#nullable restore
#line 13 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
                 Write(completionPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <br />\r\n    <h2>Total tasks count: ");
#nullable restore
#line 15 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
                      Write(totalTasksCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 16 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
     if (completedTasksCount != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Completed: ");
#nullable restore
#line 18 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
                    Write(completedTasksCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 19 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
     if (tasksInProgressCount != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>In progress: ");
#nullable restore
#line 23 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
                      Write(tasksInProgressCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
     if (notStartedTasksCount != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Not started: ");
#nullable restore
#line 28 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
                      Write(notStartedTasksCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 29 "C:\Users\Serious\source\repos\ToDoApplication\todo-aspnetmvc-ui\Views\ToDoLists\PartialViews\_SingleToDoListSummary.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList> Html { get; private set; }
    }
}
#pragma warning restore 1591
