using SQLite;
using System;
using System.Collections;
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
    /// Lógica de interacción para ventanaUpdate.xaml
    /// </summary>
    public partial class ventanaUpdate : Window
    {
        
        Contacto contacto = new Contacto();
        public ventanaUpdate(Contacto contacto)
        {
            this.contacto = contacto;

            InitializeComponent();

            boxNombre.Text= contacto.nombre;
            boxMail.Text = contacto.mail;
            boxTelefono.Text = contacto.telefono;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            contacto.nombre = boxNombre.Text;
            contacto.mail = boxMail.Text; 
            contacto.telefono = boxTelefono.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {


                conn.Update(contacto);
                MessageBox.Show("Se han guardado los cambios");


            }
            
            this.Close();
            
        }
    }
}
