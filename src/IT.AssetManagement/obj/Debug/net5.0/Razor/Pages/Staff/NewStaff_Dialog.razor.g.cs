#pragma checksum "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b81b0bc5bef399595d1640e1edbdab8aa0c784"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
    public partial class NewStaff_Dialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudForm>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(4);
                    __builder3.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(6);
                        __builder4.AddAttribute(7, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(8, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                     4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(10);
                            __builder5.AddAttribute(11, "Label", "Staff Number");
                            __builder5.AddAttribute(12, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(13, "RequiredError", "Staff Number required!");
                            __builder5.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 13 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                                staff.StaffNumber

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.StaffNumber = __value, staff.StaffNumber))));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(16, "\n\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(17);
                        __builder4.AddAttribute(18, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                     4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(21);
                            __builder5.AddAttribute(22, "Label", "Name");
                            __builder5.AddAttribute(23, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(24, "RequiredError", "Staff Name required!");
                            __builder5.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 17 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                        staff.Name

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.Name = __value, staff.Name))));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\n\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(28);
                        __builder4.AddAttribute(29, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                     4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(32);
                            __builder5.AddAttribute(33, "Label", "National ID Number");
                            __builder5.AddAttribute(34, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                                                                                    true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(35, "RequiredError", "NID required!");
                            __builder5.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 21 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                                      staff.NationalIdentificationNumber

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.NationalIdentificationNumber = __value, staff.NationalIdentificationNumber))));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(38, "\n\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(39);
                        __builder4.AddAttribute(40, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                     4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudSelect<Department>>(43);
                            __builder5.AddAttribute(44, "Label", "Department");
                            __builder5.AddAttribute(45, "MultiSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                                                                   false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(46, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                                                                                    true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(47, "RequiredError", "Department is required!");
                            __builder5.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Department>(
#nullable restore
#line 25 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                               selectedDepartment

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Department>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Department>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedDepartment = __value, selectedDepartment))));
                            __builder5.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 26 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                         foreach (var department in departments)
                        {

#line default
#line hidden
#nullable disable
                                __Blazor.IT.AssetManagement.Pages.Staff.NewStaff_Dialog.TypeInference.CreateMudSelectItem_0(__builder6, 51, 52, 
#nullable restore
#line 28 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                    department

#line default
#line hidden
#nullable disable
                                , 53, (__builder7) => {
                                    __builder7.AddContent(54, 
#nullable restore
#line 28 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                                  department.Name

#line default
#line hidden
#nullable disable
                                    );
                                }
                                );
#nullable restore
#line 29 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                        }

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(55, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(56);
                __builder2.AddAttribute(57, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(59, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(61);
                __builder2.AddAttribute(62, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 38 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
                                                  Save

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(65, "Ok");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/NewStaff_Dialog.razor"
       
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
namespace __Blazor.IT.AssetManagement.Pages.Staff.NewStaff_Dialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelectItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591