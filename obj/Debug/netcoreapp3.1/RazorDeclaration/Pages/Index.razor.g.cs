#pragma checksum "C:\Users\7339R\Documents\Epitec\CMS\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a503833a1ac4851fa4a1745d5d3de4eb0606baf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CMS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS.DBCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\7339R\Documents\Epitec\CMS\Pages\Index.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\7339R\Documents\Epitec\CMS\Pages\Index.razor"
       
   

    private string sortType = "last";

    private async void toggleSortType(){
        sortType = sortType == "last" ? "first": "last";
        await ReloadAsync();
    }
    protected override async Task OnInitializedAsync(){
        await ReloadAsync();
    }
    private ICollection<Contact> Contacts { get; set; }

        
    
    /// <summary>
    /// Reload page based on filters and paging controls.
    /// </summary>
    /// <returns>A <see cref="Task"/>.</returns>
    private async Task ReloadAsync()
    {
       
        Contacts = null;

        using var context = DbFactory.CreateDbContext();
        

         //run the query to load the current page
        Contacts = await DBCommands.FetchAsync(context.Contacts.AsQueryable(), sortType);



    }

    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Commands DBCommands { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ContactContext> DbFactory { get; set; }
    }
}
#pragma warning restore 1591
