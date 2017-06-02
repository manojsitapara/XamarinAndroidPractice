using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;

using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Support.Design.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;
using CXC.ClaimXO.Android.Fragments;
using System.Collections.Generic;

namespace CXC.ClaimXO.Android
{
    [Activity(Label = "ClaimXO", Theme = "@style/AppTheme")]
    public class AppMainActivity : AppCompatActivity
    {
        DrawerLayout drawerLayout;

        private SupportFragment mCurrentFragment;
        private DashboardFragment mDashboard;
        private ClaimAuditReportFragment mClaimAuditReportFragment;
        private Stack<SupportFragment> mStackFragments;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            
            SetContentView(Resource.Layout.AppMain);

            mDashboard = new DashboardFragment();
            mClaimAuditReportFragment = new ClaimAuditReportFragment();

            mStackFragments = new Stack<SupportFragment>();


            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);


            //FragmentOne fragment = (FragmentOne)mFragmentManager.findFragmentById(R.id.fragment_container);
            var fragment = (Fragment)FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);


            if (fragment == null)
            {
                var trans = SupportFragmentManager.BeginTransaction();

                trans.Add(Resource.Id.fragmentContainer, mDashboard, "DashboardFragment");
                this.Title = "Dashboard";

                trans.Add(Resource.Id.fragmentContainer, mClaimAuditReportFragment, "ClaimAuditReportFragment");
                trans.Hide(mClaimAuditReportFragment);
                trans.Commit();

            }


            
            mCurrentFragment = mDashboard;


            // Init toolbar
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            // Attach item selected handler to navigation view
            var navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;

            // Create ActionBarDrawerToggle button and add it to the toolbar
            var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.open_drawer, Resource.String.close_drawer);
            drawerLayout.SetDrawerListener(drawerToggle);
            drawerToggle.SyncState();
        }


        void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.MenuItem.ItemId)
            {
                case (Resource.Id.nav_home):
                    this.Title = "Dashboard";
                    ShowFragment(mDashboard);

                    // React on 'Home' selection
                    break;
                case (Resource.Id.nav_claim_audit_report):
                    this.Title = "Claim Audit Report";
                    ShowFragment(mClaimAuditReportFragment);
                    // React on 'Messages' selection
                    break;
                case (Resource.Id.nav_transaction_audit_report):
                    // React on 'Friends' selection
                    break;
                case (Resource.Id.nav_employer_report):
                    // React on 'Discussion' selection
                    break;

                case (Resource.Id.nav_transaction_feed):
                    // React on 'Discussion' selection
                    break;

                case (Resource.Id.nav_carrier_feed):
                    // React on 'Discussion' selection
                    break;
                case (Resource.Id.nav_substantiation_file):
                    // React on 'Discussion' selection
                    break;
                case (Resource.Id.nav_employer_matching_report):
                    // React on 'Discussion' selection
                    break;
                case (Resource.Id.nav_search_claims):
                    // React on 'Discussion' selection
                    break;
                case (Resource.Id.nav_search_transactions):
                    // React on 'Discussion' selection
                    break;


            }

            // Close drawer
            drawerLayout.CloseDrawers();
        }


        private void ShowFragment(SupportFragment fragment)
        {


            if (fragment.IsVisible)
            {
                return;
            }

            var trans = SupportFragmentManager.BeginTransaction();

            //trans.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);

            fragment.View.BringToFront();
            mCurrentFragment.View.BringToFront();

            trans.Hide(mCurrentFragment);
            trans.Show(fragment);

            trans.AddToBackStack(null);
            mStackFragments.Push(mCurrentFragment);
            trans.Commit();

            mCurrentFragment = fragment;
        }


        public override void OnBackPressed()
        {

            if (SupportFragmentManager.BackStackEntryCount > 0)
            {
                SupportFragmentManager.PopBackStack();
                mCurrentFragment = mStackFragments.Pop();
            }

            else
            {
                base.OnBackPressed();
            }
        }


        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            menu.Clear();
            MenuInflater.Inflate(Resource.Menu.DashboardActionBarMenu, menu);
            return base.OnPrepareOptionsMenu(menu);
            

        }

    }
}