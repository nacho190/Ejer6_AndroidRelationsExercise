using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText texto;
        Button boton1;
        Button boton2;
        Button boton3;
        Button boton4;
        Button check;
     
       // ViewPager viewpager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Binding();
           // viewpager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewpager);


            //setupViewPager(viewpager);
           // var tabLayout = FindViewById<TabLayout>(Resource.Id.tabLayout1);
           // tabLayout.SetupWithViewPager(viewpager);


        }
        /*
        void setupViewPager(Android.Support.V4.View.ViewPager viewPager)
        {
            var adapter = new Adapter(SupportFragmentManager);
            adapter.AddFragment(new TabFragment1(), "Nombre");
            adapter.AddFragment(new TabFragment2(), "Listado");
            viewPager.Adapter = adapter;
            viewpager.Adapter.NotifyDataSetChanged();
            //viewpager.OffscreenPageLimit(4);


        }
        */
        private void Binding()
        {
            texto = FindViewById<EditText>(Resource.Id.textInputEditText1);
            boton1 = FindViewById<Button>(Resource.Id.uno);
            boton2 = FindViewById<Button>(Resource.Id.dos);
            boton3 = FindViewById<Button>(Resource.Id.tres);
            boton4 = FindViewById<Button>(Resource.Id.cuatro);
            check = FindViewById<Button>(Resource.Id.ok);

            boton1.Click += Cambiotexto;
            boton2.Click += Cambiotexto1;
            boton3.Click += Cambiotexto2;
            boton4.Click += Cambiotexto3;
            check.Click += Validar;
        }
        public void Validar(object sender, EventArgs e)
        {
            if (texto.Text != "1234")
            {
                texto.SetTextColor(Android.Graphics.Color.Red);
            }
            else
            {
                SetContentView(Resource.Layout.content_main);
            }
        }
        public void Cambiotexto(object sender, EventArgs e)
        {

            texto.Text += "1";
        }
        public void Cambiotexto1(object sender, EventArgs e)
        {

            texto.Text = texto.Text + "2";
        }
        public void Cambiotexto2(object sender, EventArgs e)
        {

            texto.Text = texto.Text + "3";
        }
        public void Cambiotexto3(object sender, EventArgs e)
        {

            texto.Text = texto.Text + "4";
        }
    }
    /*
    class Adapter : Android.Support.V4.App.FragmentPagerAdapter
    {
        List<Fragment> fragments = new List<Fragment>();
        List<string> fragmentTitles = new List<string>();


        public Adapter(FragmentManager fm) : base(fm)
        {
        }

        public void AddFragment(Fragment fragment, String title)
        {
            fragments.Add(fragment);
            fragmentTitles.Add(title);


        }

        public override Fragment GetItem(int position)
        {
            return fragments[position];

        }

        public override int Count
        {
            get { return fragments.Count; }
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(fragmentTitles[position]);
        }


    }
    */
}

