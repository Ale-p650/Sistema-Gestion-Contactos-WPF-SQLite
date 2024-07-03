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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para ventanaBorraContacto.xaml
    /// </summary>
    public partial class ventanaBorraContacto : Window
    {
        List<Contacto> contactosLista;


        public ventanaBorraContacto()
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {


                contactosLista = conn.Table<Contacto>().ToList();

                

            }


            lista.ItemsSource = contactosLista;

        }

        private void barraBusca_TextChanged(object sender, TextChangedEventArgs e)
        {
            var listaFiltrada = (from c in contactosLista
                                 where c.nombre.ToLower().Contains(barraBusca.Text.ToLower())
                                 select c).ToList();

            lista.ItemsSource = listaFiltrada;

            

            


        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            
            botonBorra.IsEnabled = true;

           
        }

        private void botonBorra_Click(object sender, RoutedEventArgs e)
        {
            Contacto contacto = lista.SelectedItem as Contacto;
            

            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {


                conn.Delete(contacto);

            }

            

            MessageBox.Show($" Se ha borrado Contacto :   {contacto.nombre}");

            

            botonBorra.IsEnabled = false;

            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {


                contactosLista = conn.Table<Contacto>().ToList();
                lista.ItemsSource = contactosLista;


            }

        }
    }
    
}
