#pragma checksum "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3fd3ca00f3117e66eb009b4b3eddc28dedac7f0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPortfolio.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using BlazorPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using BlazorPortfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\programming\c#\BlazorCV\BlazorCV\BlazorPortfolio\BlazorPortfolio\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
