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

namespace Ex4
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


        class EquacaoIIGrau{

            private double a, b, c;
            public void SetA(double v) { a = v; }
            public void SetB(double v) { b = v; }
            public void SetC(double v) { c = v; }
            public double Delta() { return (b * b) + 4 * a * c; }
            public double X1() { return -b + Math.Sqrt(Delta()); }
            public double X2() { return -b - Math.Sqrt(Delta()); }
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EquacaoIIGrau x = new EquacaoIIGrau();
            x.SetA(double.Parse(A.Text));
            x.SetB(double.Parse(B.Text));
            x.SetC(double.Parse(C.Text));
            D.Text = x.Delta().ToString();
            X1.Text = x.X1().ToString();
            X2.Text = x.X2().ToString();

        }
    }
}
