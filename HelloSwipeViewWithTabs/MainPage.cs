using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using System.Collections.Generic;

namespace HelloSwipeViewWithTabs
{
    [Activity(Label = "MainPage",MainLauncher = true, Icon = "@drawable/icon")]
    public class MainPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.mainpage);

            // Create your application here
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            AddTab("Tab 1", Resource.Drawable.abc_ab_share_pack_mtrl_alpha, 0);
            AddTab("Tab 2", Resource.Drawable.abc_action_bar_item_background_material, 1);

           
        }

        private void AddTab(string tabText, int iconResourceId, int position)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);
            tab.SetIcon(Resource.Drawable.Icon);

            // must set event handler before adding tab
            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e) {
                switch (position)
                {
                    case 0:
                        e.FragmentTransaction.Replace(
                            Resource.Id.content_frame,
                            new Fragment1());
                        break;
                    case 1:
                        e.FragmentTransaction.Replace(
                            Resource.Id
                                .content_frame,
                            new Fragment2());
                        break;

                }
            };

            this.ActionBar.AddTab(tab);
        }
    }
}