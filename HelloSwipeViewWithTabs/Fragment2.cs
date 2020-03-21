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

namespace HelloSwipeViewWithTabs
{
    public class Fragment2:Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            //View ignored = base.OnCreateView(inflater, container, savedInstanceState);
            View rootView = inflater.Inflate(Resource.Layout.fragment2, null);
            var test =  rootView.FindViewById<TextView>(Resource.Id.test2222);
            test.Text = "aaa";
            return rootView    ;
        }
    }
}