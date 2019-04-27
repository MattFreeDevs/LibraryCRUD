#pragma checksum "C:\Users\Mloza\OneDrive\Escritorio\Repository\LibraryCRUD\Pages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af94bb1cfa6aebf77c1a2a68600b3e45815c47b"
// <auto-generated/>
#pragma warning disable 1591
namespace LibraryCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using LibraryCRUD;
    using LibraryCRUD.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/admin")]
    public class Admin : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Admin Menu</h1>\n\n");
            builder.AddMarkupContent(1, "<p>Clients</p>\n\n");
#line 9 "C:\Users\Mloza\OneDrive\Escritorio\Repository\LibraryCRUD\Pages\Admin.cshtml"
 if (clients == null)
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#line 12 "C:\Users\Mloza\OneDrive\Escritorio\Repository\LibraryCRUD\Pages\Admin.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.OpenElement(5, "table");
            builder.AddAttribute(6, "class", "table");
            builder.AddContent(7, "\n        ");
            builder.AddMarkupContent(8, @"<thead>
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Phone</th>
                <th>Email</th>
                <th>Registration date</th>
                <th>Amount</th>
                <th></th>
            </tr>
        </thead>
        ");
            builder.OpenElement(9, "tbody");
            builder.AddContent(10, "\n");
#line 28 "C:\Users\Mloza\OneDrive\Escritorio\Repository\LibraryCRUD\Pages\Admin.cshtml"
             foreach (var client in clients)
            {

#line default
#line hidden
            builder.AddContent(11, "                ");
            builder.OpenElement(12, "tr");
            builder.AddContent(13, "\n                    ");
            builder.OpenElement(14, "td");
            builder.AddContent(15, client.id);
            builder.CloseElement();
            builder.AddContent(16, "\n                    ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, client.name);
            builder.CloseElement();
            builder.AddContent(19, "\n                    ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, client.phone);
            builder.CloseElement();
            builder.AddContent(22, "\n                    ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, client.email);
            builder.CloseElement();
            builder.AddContent(25, "\n                    ");
            builder.OpenElement(26, "td");
            builder.AddContent(27, client.regDate.ToShortDateString());
            builder.CloseElement();
            builder.AddContent(28, "\n                    ");
            builder.OpenElement(29, "td");
            builder.AddContent(30, client.amount);
            builder.CloseElement();
            builder.AddContent(31, "\n                    ");
            builder.AddMarkupContent(32, "<td>\n                        <button type=\"button\" class=\"btn btn-primary\">Edit</button>\n                        <button type=\"button\" class=\"btn btn-danger\">Delete</button>\n                    </td>\n                ");
            builder.CloseElement();
            builder.AddContent(33, "\n");
#line 42 "C:\Users\Mloza\OneDrive\Escritorio\Repository\LibraryCRUD\Pages\Admin.cshtml"
            }

#line default
#line hidden
            builder.AddContent(34, "        ");
            builder.CloseElement();
            builder.AddContent(35, "\n    ");
            builder.CloseElement();
            builder.AddContent(36, "\n    ");
            builder.OpenElement(37, "button");
            builder.AddAttribute(38, "type", "button");
            builder.AddAttribute(39, "class", "btn btn-success");
            builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(AddClient));
            builder.AddContent(41, "Add");
            builder.CloseElement();
            builder.AddContent(42, "\n");
#line 46 "C:\Users\Mloza\OneDrive\Escritorio\Repository\LibraryCRUD\Pages\Admin.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 47 "C:\Users\Mloza\OneDrive\Escritorio\Repository\LibraryCRUD\Pages\Admin.cshtml"
           
    Client[] clients;

    protected override async Task OnInitAsync()
    {
        clients = await Http.GetJsonAsync<Client[]>("sample-data/client.json");
    }
    void AddClient(){
        UriHelper.NavigateTo("client");
    }

    class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime regDate { get; set; }
        public double amount { get; set; }
        
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
