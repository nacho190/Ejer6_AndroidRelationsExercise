using System;
using System.IO;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using SQLite;
using Environment = System.Environment;

namespace Ejer6_AndroidRelations
{
    public class TabFragment1 : Android.Support.V4.App.Fragment
    {

        EditText EditTextnom;
        EditText EditTextape;
        SQLiteConnection db;
        RadioGroup RadioGroupsex;
        string sex = "Hombre";
        View v;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            v = inflater.Inflate(Resource.Layout.tab1, container, false);

            Binding();
            Connectionbd();
            AddPeople();

            return v;
        }
        void Connectionbd()
        { 
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "try.db3");
            db = new SQLiteConnection(dbPath);

            db.CreateTable<Persona>();
        }
        void Binding()
        {
            EditTextnom = v.FindViewById<EditText>(Resource.Id.nombre);
            EditTextape = v.FindViewById<EditText>(Resource.Id.apellido);

            Button bok = v.FindViewById<Button>(Resource.Id.okname);
            Button bbd = v.FindViewById<Button>(Resource.Id.checkbd);

            RadioGroupsex = v.FindViewById<RadioGroup>(Resource.Id.sexo);
            RadioGroupsex.CheckedChange += MyRadioGroup_CheckedChange;

            bok.Click += Agregar;
            bbd.Click += Checkbd;
        }
        void AddPeople()
        {

            if (db.Table<Persona>().Count() == 0)
            {
                db.Insert(new Persona() { nombre = "Nacho", apellido = "Limon", sexo = "Hombre" });
                db.Insert(new Persona() { nombre = "Ana", apellido = "Muñoz", sexo = "Mujer" });
                db.Insert(new Persona() { nombre = "Pepe", apellido = "Perez", sexo = "Hombre" });
            }
            
                foreach (var i in db.Table<Persona>())
                {
                    ServicioLista.Instance.MyList.Add(i);
                }
        }

        void MyRadioGroup_CheckedChange(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            int checkedItemId = RadioGroupsex.CheckedRadioButtonId;
            RadioButton checkedRadioButton = v.FindViewById<RadioButton>(checkedItemId);
            sex = Convert.ToString(checkedRadioButton.Text);
        }

        void Agregar(object sender, EventArgs e)
        {
            Persona p = new Persona() {nombre = EditTextnom.Text, apellido = EditTextape.Text, sexo = sex };

            ServicioLista.Instance.MyList.Add(p);                    
            db.Insert(p);
            Toast.MakeText(Application.Context, $"Has añadido a {p.id} {p.nombre} {p.apellido} {p.sexo}", ToastLength.Short).Show();
        }

        void Checkbd(object sender, EventArgs e)
        {
            var table = db.Table<Persona>();

            foreach (var s in table)
            {
                Console.WriteLine($"{s.id} {s.nombre} {s.sexo}");
            }

            if (db.Table<Persona>().Count() > 0)
            {
                Toast.MakeText(Application.Context, $"El item con la pk 1 es: {db.Get<Persona>(1).nombre}", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(Application.Context, "No hay elementos en la base de datos", ToastLength.Short).Show();
            }
        }
       
    }
}