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

namespace Ex05
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numeros x = new numeros(int.Parse(i.Text), int.Parse(f.Text));
            lb.ItemsSource = x.Calcular(cbp.IsChecked.Value, cbi.IsChecked.Value);
        }
    }


    class numeros
    {
        private int inicio, fim;

        public numeros(int inicio, int fim)
        {
            this.inicio = inicio;
            this.fim = fim;
        }

        public int[] Calcular(bool p, bool i)
        {
            int x;
            int y = 0;
            int[] num = new int[fim];

            if (p == true && i == true)
            {
                for (x = inicio; x <= fim; x++)
                    num[y++] = x;
            }

            if (p == true && i == false)
            {
                for (x = inicio; x <= fim; x++)
                    if (x % 2 == 0)
                        num[y++] = x;
            }

            if (p == false && i == true)
            {
                for (x = inicio; x <= fim; x++)
                    if (x % 2 == 1)
                        num[y++] = x;
            }
            int[] cop = new int[y];
            Array.Copy(num, cop, y);


            return cop;
        }
    }
}


