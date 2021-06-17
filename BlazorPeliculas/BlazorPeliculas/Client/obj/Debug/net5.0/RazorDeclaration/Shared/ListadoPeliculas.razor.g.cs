// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

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
#nullable restore
#line 13 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class ListadoPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoPeliculas.razor"
       
    Confirmacion confirmacion;
    [Parameter] public List<Pelicula> Peliculas { get; set; }

    protected override void OnInitialized()
    {
        Console.WriteLine($"OnInitialized - Cantidad Peliculas: {Peliculas.Count}");
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine($"OnParametersSet - Cantidad Peliculas: {Peliculas.Count}");
    }

    protected override void OnAfterRender(bool primeraRenderizacion)
    {
        Console.WriteLine($"OnAfterRender: Primera vez: {primeraRenderizacion}");
    }

    protected override bool ShouldRender()
    {
        Console.WriteLine("ShouldRender");
        return true;
    }

    bool MostrarBotones = true;

    async Task EliminarPelicula(Pelicula pelicula)
    {
        confirmacion.Mostrar();
        peliculaABorrar = pelicula;
        //var confirmar = await js.Confirm($"¿Desea borrar la película {pelicula.Titulo}?");
        //if (confirmar)
        //{
        //    Peliculas.Remove(pelicula);
        //    Console.WriteLine($"Se ha eliminado la pelicula {pelicula.Titulo}");
        //}
    }
    Pelicula peliculaABorrar;
    void EliminarPeliculaConfirmacion()
    {
        Peliculas.Remove(peliculaABorrar);
        confirmacion.Ocultar();
        peliculaABorrar = null;
    }

    void onCancelConfirmacion()
    {
        confirmacion.Ocultar();
        peliculaABorrar = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591