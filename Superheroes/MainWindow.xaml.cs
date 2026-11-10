using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Superheroes
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private List<Superheroe> _superheroes;
        private int _indiceActual = 0;

        public int PosicionActual => _indiceActual + 1;
        public int TotalSuperheroes => _superheroes.Count;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            _superheroes = DataService.GetSamples();
            DataContext = _superheroes[_indiceActual];
        }

        private void Siguiente_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_indiceActual < _superheroes.Count - 1)
            {
                _indiceActual++;
            }
            else
            {
                _indiceActual = 0;
            }

            ActualizarVista();
        }

        private void Anterior_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_indiceActual > 0)
            {
                _indiceActual--;
            }
            else
            {
                _indiceActual = _superheroes.Count - 1;
            }

            ActualizarVista();
        }

        private void ActualizarVista()
        {
            DataContext = _superheroes[_indiceActual];
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PosicionActual)));
        }
    }
}