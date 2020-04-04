#pragma checksum "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Pages\Plans\AddPlan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a620fb930f31f30817cc78834e7ed973219af01e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PlannerApp.Client.Pages.Plans
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
#nullable restore
#line 7 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Pages\Plans\AddPlan.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/plans/add")]
    public partial class AddPlan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Pages\Plans\AddPlan.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    PlanRequest model = new PlanRequest();
    System.IO.Stream fileStream = null;
    string imageContent = string.Empty;
    string fileName = string.Empty;

    bool isBusy = false;

    ElementReference inputReference;

    // Alert
    string message = string.Empty;
    Models.AlertMessageType messageType = Models.AlertMessageType.Success;

    // Choose a cover photo for the plan
    async Task chooseFileAsync()
    {
        // Read the file
        var file = (await fileReaderSerivce.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        // Read the info of the file
        var fileInfo = await file.ReadFileInfoAsync();

        // Validate the extension
        string extension = System.IO.Path.GetExtension(fileInfo.Name);
        var allowedExtensions = new string[] { ".jpg", ".png", ".bmp" };

        if (!allowedExtensions.Contains(extension))
        {
            message = "The chosen file is not a valid image file";
            messageType = Models.AlertMessageType.Error;
            return;
        }
        message = null;

        // Open the stream
        using (var memoryStream = await file.CreateMemoryStreamAsync())
        {
            // Copy the content to a new stream
            fileStream = new System.IO.MemoryStream(memoryStream.ToArray());
            fileName = fileInfo.Name;

            // Show the file in the UI
            imageContent = $"data:{fileInfo.Type};base64, {Convert.ToBase64String(memoryStream.ToArray())}";
        }
    }

    async Task postPlanAsync()
    {
        isBusy = true;

        var userState = authenticationState.Result;
        plansService.AccessToken = userState.User.FindFirst("AccessToken").Value;

        model.CoverFile = fileStream;
        model.FileName = fileName;
        var result = await plansService.PostPlanAsync(model);

        if (result.IsSuccess)
            navigationManager.NavigateTo("/Plans");
        else
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Error; 
        }

        isBusy = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderSerivce { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PlansService plansService { get; set; }
    }
}
#pragma warning restore 1591
