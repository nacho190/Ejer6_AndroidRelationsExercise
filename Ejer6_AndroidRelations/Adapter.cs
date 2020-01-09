using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace Ejer6_AndroidRelations
{
    class Adapter : FragmentPagerAdapter
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
}