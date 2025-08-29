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
using WpfDemo_B.Operaciones;

namespace WpfDemo_B.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para Mantenimiento.xaml
    /// </summary>
    public partial class Mantenimiento : Window
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conductores conductores = new Conductores();
            conductores.Show(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Transportistas transportistas = new Transportistas();
            transportistas.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Camiones camiones = new Camiones();
            camiones.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
