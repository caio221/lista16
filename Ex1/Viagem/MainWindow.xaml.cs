using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Viagem
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        class Viagem
        {
            private double distancia, tempo;
            public void SetDistancia(double v) { distancia = v; }
            public double GetDistancia() { return distancia; }
            public void SetTempo(double v) { tempo = v; }
            public double GetTempo() { return tempo; }
            public double CalcVM() { return distancia / tempo; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Viagem x = new Viagem();
            x.SetDistancia(double.Parse(D.Text));
            x.SetTempo(double.Parse(T.Text));
            VM.Text = x.CalcVM().ToString();
        }
    }
}
