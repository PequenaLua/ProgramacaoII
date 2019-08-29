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
                Numeros a = new Numeros(int.Parse(Inicio.Text), int.Parse(Fim.Text));
                bool nPares, nImpares;
                if (Par.IsChecked == true) nPares = true;
                else nPares = false;
                if (Impar.IsChecked == true) nImpares = true;
                else nImpares = false;
                Lista.ItemsSource = a.Calcular(nPares, nImpares);
            }
        }
    }