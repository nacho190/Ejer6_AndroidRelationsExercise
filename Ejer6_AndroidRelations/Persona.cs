using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace Ejer6_AndroidRelations
{
    [Table("Personas")]
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(8)]
        public string nombre { get; set; }
        [MaxLength(8)]
        public string apellido { get; set; }

        public string sexo { get; set; }
    }
}