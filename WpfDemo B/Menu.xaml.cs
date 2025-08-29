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
using WpfDemo_B.Reportes;

namespace WpfDemo_B
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Mantenimiento mantenimiento = new Mantenimiento.Mantenimiento();
            mantenimiento.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Operaciones.Operaciones operaciones = new Operaciones.Operaciones();
            operaciones.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reportes.Reportes reportes = new Reportes.Reportes();
            reportes.Show();
        }
        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
