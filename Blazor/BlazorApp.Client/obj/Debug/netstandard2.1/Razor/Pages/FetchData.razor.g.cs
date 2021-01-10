#pragma checksum "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "152d00a611ad38abc8df9d81735c635ee6e40679"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using BlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using BlazorApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Learning\Blazor\BlazorApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Member/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> MEMBER DETAILS</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>IATCINDIA MEMBER DETAILS APIs</p>\r\n\r\n");
#nullable restore
#line 9 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
 if (memberdetails == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loding...</em></p>\r\n");
#nullable restore
#line 12 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 25 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
             foreach (var member in memberdetails)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
                         member.AddressLine1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
                         member.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
                         member.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 31 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
                         member.Iatcregno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 33 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 36 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Learning\Blazor\BlazorApp.Client\Pages\FetchData.razor"
       
    public IatcindiaMMemberdetailsTest[] memberdetails;

    protected override async Task OnInitializedAsync()
    {
        memberdetails = await Http.GetJsonAsync<IatcindiaMMemberdetailsTest[]>("/api/Member/GetAll");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
