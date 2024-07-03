using SQLite;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        

        private void nuevoContacto(object sender, RoutedEventArgs e)
        {
            ventanaContacto vc = new ventanaContacto();
            vc.ShowDialog();
        }

        private void verContactos(object sender, RoutedEventArgs e)
        {
            ventanaListaContactos vlc = new ventanaListaContactos();
            vlc.ShowDialog();
            

        }

        private void borrarContacto(object sender, RoutedEventArgs e)
        {
            ventanaBorraContacto vbc = new ventanaBorraContacto();
            vbc.ShowDialog();


        }

        private void editarContacto(object sender, RoutedEventArgs e)
        {
            ventanaEditarContacto vec = new ventanaEditarContacto();
            vec.ShowDialog();


        }
    }
}
