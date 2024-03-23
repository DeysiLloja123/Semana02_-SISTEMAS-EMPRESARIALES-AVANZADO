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
    /// Lógica de interacción para Salida.xaml
    /// </summary>
    public partial class Salida : Window
    {
        public Salida()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.ShowDialog();
           

        }
    }
}
