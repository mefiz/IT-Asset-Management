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
#line 1 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using IT.AssetManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using IT.AssetManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewAsset_Dialog.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewAsset_Dialog.razor"
using Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewAsset_Dialog.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
    public partial class NewAsset_Dialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewAsset_Dialog.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();

    private Asset asset = new Asset();
    private AssetType selectedType = null;
    private Staff selectedStaff = null;
    
    private string date = DateTime.Now.ToString();
    private string assignedDate = DateTime.Now.ToString();

    private IEnumerable<AssetType> types = null;
    private IEnumerable<Staff> staffs = null;

    protected override async Task OnInitializedAsync()
    {
        asset.AssetNumber = await AssetsService.GenerateAssetNumberAsync();
        types = await AssetsService.GetAssetTypesAsync();
        staffs = await StaffsService.GetStaffsAsync();

        asset.PurchasedDate = DateTime.Now;
    }

    private void updateDate(string date) {
        asset.PurchasedDate = DateTime.Parse(date);
    }

    private async void Save() {
        var savedAsset = await AssetsService.SaveNewAssetAsync(asset, selectedType, selectedStaff, assignedDate);
        MudDialog.Close(DialogResult.Ok(savedAsset));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStaffsService StaffsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAssetsService AssetsService { get; set; }
    }
}
#pragma warning restore 1591
