﻿using System;
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
    /// Lógica de interacción para Camiones.xaml
    /// </summary>
    public partial class Camiones : Window
    {
        public Camiones()
        {
            InitializeComponent();
        }
        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            Crear crear = new Crear();
            crear.ShowDialog();

        }
        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            Listar listar = new Listar();
            listar.ShowDialog();

        }
    }
}
