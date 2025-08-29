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

namespace WpfDemo_B.Reportes
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cargas cargas = new Cargas();
            cargas.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ingresoso ingresos = new Ingresoso();
            ingresos.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Salidas salidas = new Salidas();
            salidas.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
