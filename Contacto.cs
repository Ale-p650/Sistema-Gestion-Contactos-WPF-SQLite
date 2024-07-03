using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp2
{
    public class Contacto
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        public string nombre { get; set; }

        public string mail { get; set; }

        public string telefono { get; set; }
    }
}
