using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
    /// Lógica de interacción para ventanaListaContactos.xaml
    /// </summary>
    public partial class ventanaListaContactos : Window
    {
        List<Contacto> contactosLista;

        public ventanaListaContactos()
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;



            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {


                contactosLista = conn.Table<Contacto>().ToList();

                if (contactosLista.Count == 1)
                {
                    bloqueResultados.Text = $"{contactosLista.Count()} resultado";
                }

                else bloqueResultados.Text = $"{contactosLista.Count()} resultados";

            }


            lista.ItemsSource = contactosLista;
            
        }

        private void barraBusca_TextChanged(object sender, TextChangedEventArgs e)
        {
            var listaFiltrada = (from c in contactosLista 
                                where c.nombre.ToLower().Contains(barraBusca.Text.ToLower()) 
                                select c).ToList();

            lista.ItemsSource = listaFiltrada;

            bloqueResultados.Text = $"{listaFiltrada.Count()} resultados";

            if (listaFiltrada.Count == 1)
            {
                bloqueResultados.Text = $"{listaFiltrada.Count()} resultado";
            }

            if (listaFiltrada.Count == 0)
            {
                MessageBox.Show("No hay usuarios");
            }


        }
    }
}
