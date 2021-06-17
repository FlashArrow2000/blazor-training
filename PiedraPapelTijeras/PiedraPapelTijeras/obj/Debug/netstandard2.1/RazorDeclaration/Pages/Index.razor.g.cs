// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PiedraPapelTijeras.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using PiedraPapelTijeras;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using PiedraPapelTijeras.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\dcampos\Desktop\Blazor Training\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
       

    List<Jugada> jugadas = new List<Jugada>()
    {
        new Jugada{Imagen = "piedra.jpg", OpcionPPT = OpcionPPT.Piedra, VenceA = OpcionPPT.Tijera, PierdeContra = OpcionPPT.Papel },
        new Jugada{Imagen = "tijeras.jpg", OpcionPPT = OpcionPPT.Tijera, VenceA = OpcionPPT.Papel, PierdeContra = OpcionPPT.Piedra},
        new Jugada{Imagen = "papel.jpg", OpcionPPT = OpcionPPT.Papel, VenceA = OpcionPPT.Piedra, PierdeContra = OpcionPPT.Tijera}
    };

    Jugada jugadaOponente;
    String resultadoMensaje;
    String resultadoMensajeColor;
    Timer timer;

    protected override void OnInitialized()
    {
        jugadaOponente = jugadas[0];
        timer = new Timer();
        timer.Interval = 80;
        timer.Elapsed += TimerOnElaped;
        timer.Start();
    }

    private void Reiniciar()
    {
        timer.Start();
        resultadoMensaje = null;
        resultadoMensajeColor = null;
    }

    private void SeleccionarJugada( Jugada jugada)
    {
        timer.Stop();
        var result = jugada.JugarContra(jugadaOponente);

        if (result == StatusJuego.Victoria)
        {
            resultadoMensaje = "¡Ganaste!";
            resultadoMensajeColor = "green";
        }
        else if (result == StatusJuego.Derrota)
        {
            resultadoMensaje = "¡Perdiste!";
            resultadoMensajeColor = "red";
        }
        else{
            resultadoMensaje = "¡Empate!";
            resultadoMensajeColor = "black";
        }
    }

    int indiceJugadaOponente = 0;

    private void TimerOnElaped(object sender, ElapsedEventArgs e)
    {
        indiceJugadaOponente = (indiceJugadaOponente + 1) % jugadas.Count;
        jugadaOponente = jugadas[indiceJugadaOponente];
        StateHasChanged();//Con esto le decimos a blazor que se debe de re-renderizar el componente
    }

    class Jugada
    {
        public OpcionPPT OpcionPPT { get; set; }
        public OpcionPPT VenceA { get; set; }
        public OpcionPPT PierdeContra { get; set; }
        public string Imagen { get; set; }
        public StatusJuego JugarContra(Jugada jugada2)
        {
            if (OpcionPPT == jugada2.OpcionPPT)
            {
                return StatusJuego.Empate;
            }

            if (VenceA == jugada2.OpcionPPT)
            {
                return StatusJuego.Victoria;
            }

            return StatusJuego.Derrota;
        }
    }

    enum OpcionPPT
    {
        Piedra, Papel, Tijera
    }

    enum StatusJuego
    {
        Victoria, Derrota, Empate
    }

    public void Dispose()//Estp es para desposar los recursos del navegado a esta funcion, asi ahorra recursos
    {
        if (timer != null)
        {
            timer.Dispose();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
