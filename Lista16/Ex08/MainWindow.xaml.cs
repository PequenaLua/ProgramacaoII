using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Sys/tem.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex03
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
            Retangulo r = new Retangulo();
            r.SetBase(double.Parse(txtBase.Text));
            r.SetAltura(double.Parse(txtAltura.Text));
            txtArea.Text = r.CalcArea().ToString();
            txtDiagonal.Text = r.CalcDiagonal().ToString();
        }
    }
}

Class1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Retangulo
    {
        private double b, h;

        public void SetBase(double v)
        {
            b = v;
        }
        public void SetAltura(double v)
        {
            h = v;
        }
        public double GetBase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {
            return b * h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(b * b + h * h);
        }

    }
}
