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
    class ListViewAdapter : BaseAdapter<Persona>
    {
        public List<Persona> miItems;
        private Context miContext;

        public ListViewAdapter(Context context, List<Persona> items)
        {
            miItems = items;
            miContext = context;
        }

        public override Persona this[int position]
        {
            get { return miItems[position]; }
        }

        public override int Count
        {
            get { return miItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(miContext).Inflate(Resource.Layout.listele, null, false);
            }
            TextView nombre = row.FindViewById<TextView>(Resource.Id.textView1);
            nombre.Text = miItems[position].nombre;
            TextView apellido = row.FindViewById<TextView>(Resource.Id.textView2);
            apellido.Text = miItems[position].apellido;
            TextView sexo = row.FindViewById<TextView>(Resource.Id.textView3);
            sexo.Text = miItems[position].sexo;
            TextView id = row.FindViewById<TextView>(Resource.Id.textView4);
            id.Text = ""+miItems[position].id;

            return row;
        }
        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }


    }
}