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
    public class TabFragment1 : Android.Support.V4.App.Fragment
    {

        EditText nom;
        EditText ape;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var v = inflater.Inflate(Resource.Layout.tab1, container, false);

            nom = v.FindViewById<EditText>(Resource.Id.nombre);
            ape = v.FindViewById<EditText>(Resource.Id.apellido);

            Button b = v.FindViewById<Button>(Resource.Id.okname);
            b.Click += Agregar;

           
            return v;
        }
        void Agregar(object sender, EventArgs e)
        {


        }
    }
}