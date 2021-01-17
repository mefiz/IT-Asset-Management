// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IT.AssetManagement.Pages.Staff
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using IT.AssetManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using IT.AssetManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
    public partial class NewStaff_Dialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/mubah/Projects/IT-Asset-Management/src/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }
    void Cancel() => MudDialog.Cancel();

    private Staff staff = new Staff();
    private Department selectedDepartment = null;

    private IEnumerable<Department> departments = null;

    protected override async Task OnInitializedAsync()
    {
        departments = await StaffsService.GetDepartmentsAsync();
    }

    private async void Save() {
        var savedAsset = await StaffsService.SaveNewStaffAsync(staff, selectedDepartment);
        Snackbar.Add("Staff added successfully!", Severity.Success);
        MudDialog.Close(DialogResult.Ok(savedAsset));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStaffsService StaffsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAssetsService AssetsService { get; set; }
    }
}
#pragma warning restore 1591
