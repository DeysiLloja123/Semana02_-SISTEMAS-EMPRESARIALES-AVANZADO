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
    /// Lógica de interacción para login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usuario = Usuario.Text;
            string password = Password.Password;

            if (ValidarCredenciales(usuario, password))
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Las credenciales son incorrectas");
            }
        }

        private bool ValidarCredenciales(string usuario, string password)
        {
            return usuario == "deysi" && password == "lloja123";
        }
    }
}

