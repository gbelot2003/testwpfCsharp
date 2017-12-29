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
        
        /// <summary>
        /// Evento de suma en formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculo_Click(object sender, RoutedEventArgs e)
        {

            ///<summary>
            /// Instancia de objeto sumador desde namespace WpfApp.Data
            /// </summary>
            Sumador sumador = new Sumador(Convert.ToInt32(this.sumando.Text), Convert.ToInt32(this.sumador.Text));

            this.resultados.Content = sumador.proceso().ToString();
        }
    }
}
