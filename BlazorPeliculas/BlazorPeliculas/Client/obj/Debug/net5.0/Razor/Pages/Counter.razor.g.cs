#pragma checksum "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a033ee94601aa2865b7648253921ee3af81afb44"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "color:" + " " + (
#nullable restore
#line 3 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                   appState.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-a2z283tr5e");
            __builder.AddContent(3, "Counter");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "display:flex;");
            __builder.AddAttribute(7, "b-a2z283tr5e");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "width: 150px");
            __builder.AddAttribute(10, "b-a2z283tr5e");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "style", "margin-top: 15px");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                        appState.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appState.Color = __value, appState.Color));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(16, "b-a2z283tr5e");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "green");
            __builder.AddAttribute(19, "b-a2z283tr5e");
            __builder.AddContent(20, "Verde");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", "red");
            __builder.AddAttribute(24, "b-a2z283tr5e");
            __builder.AddContent(25, "Rojo");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n            ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "blue");
            __builder.AddAttribute(29, "b-a2z283tr5e");
            __builder.AddContent(30, "Azul");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "width: 150px");
            __builder.AddAttribute(34, "b-a2z283tr5e");
            __builder.OpenElement(35, "select");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "style", "margin-top: 15px");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                        appState.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appState.Size = __value, appState.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(40, "b-a2z283tr5e");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "12px");
            __builder.AddAttribute(43, "b-a2z283tr5e");
            __builder.AddContent(44, "12px");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n            ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "20px");
            __builder.AddAttribute(48, "b-a2z283tr5e");
            __builder.AddContent(49, "20px");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n            ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "30px");
            __builder.AddAttribute(53, "b-a2z283tr5e");
            __builder.AddContent(54, "30px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n\n");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "style", "color:" + " " + (
#nullable restore
#line 22 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                  appState.Color

#line default
#line hidden
#nullable disable
            ) + ";font-size:" + " " + (
#nullable restore
#line 22 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                                             appState.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "b-a2z283tr5e");
            __builder.AddContent(59, "Current count: ");
            __builder.AddContent(60, 
#nullable restore
#line 22 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                                                                            currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n\n");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "b-a2z283tr5e");
            __builder.AddContent(64, "Current count: ");
            __builder.AddContent(65, 
#nullable restore
#line 24 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n");
            __builder.OpenElement(67, "p");
            __builder.AddAttribute(68, "b-a2z283tr5e");
            __builder.AddContent(69, "Singleton count: ");
            __builder.AddContent(70, 
#nullable restore
#line 25 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                     singleton.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "b-a2z283tr5e");
            __builder.AddContent(74, "Transient count: ");
            __builder.AddContent(75, 
#nullable restore
#line 26 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                     transient.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n\n");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "btn btn-primary");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                  IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "b-a2z283tr5e");
            __builder.AddMarkupContent(81, "\n    Click me\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n\n");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "btn btn-primary");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\dcampos\Desktop\Blazor Training\BlazorPeliculas\BlazorPeliculas\Client\Pages\Counter.razor"
                  IncrementCountJavacript

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "b-a2z283tr5e");
            __builder.AddMarkupContent(87, "\n    Click me Javascript\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
