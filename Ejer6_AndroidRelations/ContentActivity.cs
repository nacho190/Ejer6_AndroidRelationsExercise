using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Android.Views;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
namespace Ejer6_AndroidRelations
{
    class ContentActivity : AppCompatActivity
    {
        ViewPager viewpager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.content_main);
            viewpager = FindViewById<ViewPager>(Resource.Id.viewpager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);

            SupportActionBar.SetIcon(Resource.Mipmap.fesac);

            SupportActionBar.SetDisplayShowTitleEnabled(false);

            setupViewPager(viewpager);
            var tabLayout = FindViewById<TabLayout>(Resource.Id.tabs);

            tabLayout.SetupWithViewPager(viewpager);

        }
        void setupViewPager(ViewPager viewPager)
        {
            var adapter = new FragmentAdapter(SupportFragmentManager);
            adapter.AddFragment(new TabFragment1(), "Nombre");
            adapter.AddFragment(new TabFragment2(), "Listado");

            viewPager.Adapter = adapter;

            viewpager.Adapter.NotifyDataSetChanged();

            //viewpager.OffscreenPageLimit(4);
        }
    }
}