#pragma checksum "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c138f753d7ae9bda5122ff18ab8a4e54e64d419"
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
    public partial class ListadoGenerico<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
 if (Listado == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     if (Cargando == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando...");
#nullable restore
#line 9 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 13 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         Cargando

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 13 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     
}
else if (Listado.Count == 0)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     if (NoHayRegistros == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No hay registros ");
#nullable restore
#line 21 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                      
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 25 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         NoHayRegistros

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 25 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                       
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     

} else
{
    foreach (var item in Listado)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 32 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         HayRegistros(item)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 32 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                           
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
       
    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<Titem> HayRegistros { get; set; }
    [Parameter] public List<Titem> Listado { get; set; }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
