using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;

namespace Superheroes
{
    public partial class Superheroe : ObservableObject
    {
        [ObservableProperty]
        private string? _nombre;

        [ObservableProperty]
        private string? _imagenRuta;

        [ObservableProperty]
        private bool _vengador;

        [ObservableProperty]
        private bool _xmen;

        [ObservableProperty]
        private bool _heroe;

        // Constructores
        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagenRuta, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            ImagenRuta = imagenRuta;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }
    }
}