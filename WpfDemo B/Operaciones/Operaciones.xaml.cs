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

namespace WpfDemo_B.Operaciones
{
    /// <summary>
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ingresos ingresos = new Ingresos();
            ingresos.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Salida salida = new Salida();
            salida.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
