#pragma checksum "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ce8fd3174d26368cee1f2222225d1b6d9193062"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 3 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2116045\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
