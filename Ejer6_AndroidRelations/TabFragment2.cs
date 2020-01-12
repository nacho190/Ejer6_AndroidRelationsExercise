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
    public class TabFragment2 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var v = inflater.Inflate(Resource.Layout.tab2, container, false);
            
            var milistview = v.FindViewById<ListView>(Resource.Id.lista);

            var mitems = new List<persona>();

            mitems.Add(new persona() { nombre = "Nacho", apellido = "Limon" });
            mitems.Add(new persona() { nombre = "Ana", apellido = "Muñoz" });
            mitems.Add(new persona() { nombre = "Pepe", apellido = "Perez" });
            

            ListViewAdapter adapter = new ListViewAdapter(this.Context, mitems);
            milistview.Adapter = adapter;
            
            return v;

        }
    }
}