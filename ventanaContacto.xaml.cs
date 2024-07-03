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
    /// Lógica de interacción para ventanaContacto.xaml
    /// </summary>
    public partial class ventanaContacto : Window
    {
        public ventanaContacto()
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

        }

        private void guardar(object sender, RoutedEventArgs e)
        {
            Contacto contacto = new Contacto();
            contacto.nombre = boxNombre.Text;
            contacto.telefono = boxTelefono.Text;
            contacto.mail = boxMail.Text;

            if(contacto.telefono == ""|| contacto.nombre == "" || contacto.mail == "")
            {
                MessageBox.Show("ERROR :  Datos insuficientes");
            }

            else {
                
                using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
                {

                    conn.CreateTable<Contacto>();
                    conn.Insert(contacto);

                }
                this.Close();
            }

            
            
        }
    }
}
