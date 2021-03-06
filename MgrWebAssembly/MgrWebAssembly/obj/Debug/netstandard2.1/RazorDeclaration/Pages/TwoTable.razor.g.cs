#pragma checksum "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\Pages\TwoTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a41233370aabeb6d911f6318383d07a69808ae3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MgrWebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using MgrWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using MgrWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using MgrWebAssemblyLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/twoTable")]
    public partial class TwoTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\Michal\source\repos\MgrWebAssembly\MgrWebAssembly\Pages\TwoTable.razor"
       

    string baseUrl = "https://localhost:44347/";

    int selectedEmploeeId = -1;
    List<Employees> employees;
    List<Orders> orders;

    protected override async Task OnInitializedAsync()
    {
        employees = await httpClient.GetJsonAsync<List<Employees>>($"{baseUrl}api/employees");
        orders = new List<Orders>();
    }

    private async Task GetOrders(int employeeID)
    {
        selectedEmploeeId = employeeID;
        orders = await httpClient.GetJsonAsync<List<Orders>>($"{baseUrl}api/orders?id={employeeID}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
