using System;
using System.Windows;
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculo_Click(object sender, RoutedEventArgs e)
        {
            Sumador sumador = new Sumador(Convert.ToInt32(this.sumando.Text), Convert.ToInt32(this.sumador.Text));
            this.resultados.Content = sumador.proceso().ToString();
        }
    }
}
