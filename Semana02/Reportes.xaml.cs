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
using System.Windows.Shapes;

namespace Semana02
{
    /// <summary>
    /// Lógica de interacción para Reportes.xaml
    /// </summary>
    public partial class Reportes : Window
    {
        public Reportes()
        {
            InitializeComponent();
        }
        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            Salidas salidas = new Salidas();
            salidas.ShowDialog();
        }
        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            Salida salida = new Salida();
            salida.ShowDialog();
        }
    }
}
