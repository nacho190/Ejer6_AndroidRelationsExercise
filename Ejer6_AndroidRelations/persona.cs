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

namespace Ejer6_AndroidRelations
{
    class persona
    {
        string nombre;
        string apellido;

        public persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}