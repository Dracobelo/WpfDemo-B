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
    /// Lógica de interacción para Ingresos.xaml
    /// </summary>
    public partial class Ingresos : Window
    {
        public Ingresos()
        {
            InitializeComponent();
        }

        private void btn_Cancelar(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Show();
            this.Close();
        }
    }
}
