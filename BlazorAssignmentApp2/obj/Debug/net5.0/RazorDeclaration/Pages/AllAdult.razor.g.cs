// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAssignmentApp2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using BlazorAssignmentApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using BlazorAssignmentApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AllAdult.razor"
using BlazorAssignmentApp2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AllAdult.razor"
using BlazorAssignmentApp2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AllAdult.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllAdult")]
    public partial class AllAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AllAdult.razor"
       
    private IList<Adult> adults;
    private IList<Adult> adultsToShow;
    
    
    string? FilterByName = null;
    private void FilterByName_(ChangeEventArgs changeEventArgs)
    
    {
        
        try
        {
            FilterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {}

    }
    
    private async Task ExecuteFilter()
    {
        adultsToShow = await WebService.GetAdults(null);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData WebService { get; set; }
    }
}
#pragma warning restore 1591
