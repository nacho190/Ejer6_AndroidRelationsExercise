using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;


namespace Ejer6_AndroidRelations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, NoHistory = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText texto;
        Button boton1;
        Button boton2;
        Button boton3;
        Button boton4;
        Button botonMensaje;
        Button check;
        TextView textomensaje;   
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Binding();
            Retrieveset();
        }

        protected void Saveset(){
        //store
        var prefs = Application.Context.GetSharedPreferences("Archivo", FileCreationMode.Private);
        var prefEditor = prefs.Edit();
        prefEditor.PutString("cadena", "iniciado");
        prefEditor.Commit();
        }

    // Function called from OnCreate
        protected void Retrieveset()
        {
        //retreive 
        var prefs = Application.Context.GetSharedPreferences("Archivo", FileCreationMode.Private);              
        var somePref = prefs.GetString("cadena", "");
            if (somePref.Equals("iniciado"))
            {
                StartActivity(typeof(ContentActivity));
            }
        }
        private void Binding()
        {
            texto = FindViewById<EditText>(Resource.Id.textInputEditText1);
            boton1 = FindViewById<Button>(Resource.Id.uno);
            boton2 = FindViewById<Button>(Resource.Id.dos);
            boton3 = FindViewById<Button>(Resource.Id.tres);
            boton4 = FindViewById<Button>(Resource.Id.cuatro);
            check = FindViewById<Button>(Resource.Id.ok);
            botonMensaje = FindViewById<Button>(Resource.Id.mensaje);
            textomensaje = FindViewById<TextView>(Resource.Id.textomensaje);

            boton1.Click += Cambiotexto;
            boton2.Click += Cambiotexto;
            boton3.Click += Cambiotexto;
            boton4.Click += Cambiotexto;
            check.Click += Validar;
            botonMensaje.Click += Mensaje;
        }

        public void Mensaje(object sender, EventArgs e)
        {
            textomensaje.Text = "Hola Chema!";
            Toast.MakeText(Application.Context, "Hola Chema!", ToastLength.Short).Show();
        }

        public void Validar(object sender, EventArgs e)
        {
            if (texto.Text != "1234")
            {
                texto.SetTextColor(Android.Graphics.Color.Red);
            }
            else
            {
                Saveset();
                StartActivity(typeof(ContentActivity));
            }
        }

        public void Cambiotexto(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            texto.Text += boton.Text; ;
        }
      
    }
}

