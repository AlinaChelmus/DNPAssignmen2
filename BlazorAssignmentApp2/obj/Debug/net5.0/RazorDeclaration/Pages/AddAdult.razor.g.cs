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
#nullable restore
#line 1 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\_Imports.razor"
using System.Net.Http;

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
#line 2 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AddAdult.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AddAdult.razor"
using BlazorAssignmentApp2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AddAdult.razor"
using BlazorAssignmentApp2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AddAdult.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AddAdult.razor"
           [Authorize(Policy = "Login")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\alina\RiderProjects\Assig2\DNPAssignmen2\BlazorAssignmentApp2\Pages\AddAdult.razor"
       
    private Adult addNewAdultItem = new Adult();
    
    private IList<Adult> adults;
    private IList<Adult> adultsToShow;

    private void AddNewAdult()
    {
        WebService.AddAdultAsync(addNewAdultItem);
        NavigationManager.NavigateTo("/Adults");
    }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData WebService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591