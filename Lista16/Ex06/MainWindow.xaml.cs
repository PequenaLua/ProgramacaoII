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

namespace Ex06
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
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Bingo b = new Bingo();
            b.Iniciar(10);
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
        }
    }
}