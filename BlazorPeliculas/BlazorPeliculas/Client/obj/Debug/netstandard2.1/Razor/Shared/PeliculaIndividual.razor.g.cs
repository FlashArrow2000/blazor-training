#pragma checksum "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05082fb78ed8395ef81255e7a927f58d0aa3c79e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositorios;

#line default
#line hidden
#nullable disable
    public partial class PeliculaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Titulo: ");
            __builder.OpenElement(4, "b");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                    (MarkupString)Pelicula.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Fecha Lanzamiento: ");
            __builder.OpenElement(9, "b");
            __builder.AddContent(10, 
#nullable restore
#line 6 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                              Pelicula.Lanzamiento.ToString("dd MMM yyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
#nullable restore
#line 8 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
     if (MostrarBotones)
    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                                ()=> EliminarPelicula.InvokeAsync(Pelicula)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Borrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 14 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
       

    [Parameter] public Pelicula Pelicula { get; set; }
    [Parameter] public bool MostrarBotones { get; set; } = false;
    [Parameter] public EventCallback<Pelicula> EliminarPelicula { get; set; }

    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
