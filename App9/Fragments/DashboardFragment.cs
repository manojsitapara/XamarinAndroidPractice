using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace CXC.ClaimXO.Android.Fragments
{
    [Activity(Label = "Dashboard", Theme = "@style/MyTheme")]
    public class DashboardFragment : SupportFragment
    {
        View view;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            view = inflater.Inflate(Resource.Layout.Dashboard, container, false);

            var spinner = (Spinner)view.FindViewById(Resource.Id.ddDashboardYear);
            List<string> year = new List<string>();
            year.Add(System.DateTime.Now.Year.ToString());
            year.Add(DateTime.Now.AddYears(-1).Year.ToString());
            ArrayAdapter adapter = new ArrayAdapter(Activity, Android.Resource.Layout.support_simple_spinner_dropdown_item, year);
            spinner.Adapter = adapter;

            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

            return view;
            //return base.OnCreateView(inflater, container, savedInstanceState);
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            //Merchant merch = (Merchant)spinner.SelectedItem;
            string toast = string.Format("Selected text is {0}", spinner.GetItemAtPosition(e.Position));
            var txtTransactions = (TextView)view.FindViewById(Resource.Id.txtTransactions);
            var txtClaims = (TextView)view.FindViewById(Resource.Id.txtClaims);
            var txtParticipants = (TextView)view.FindViewById(Resource.Id.txtParticipants);
            var txtTransactionsWithNoClaims = (TextView)view.FindViewById(Resource.Id.txtTransactionsWithNoClaims);
            var txtFilteredTransactions = (TextView)view.FindViewById(Resource.Id.txtFilteredTransactions);
            var txtYetToSubstantiated = (TextView)view.FindViewById(Resource.Id.txtYetToSubstantiated);
            var txtSubstantiatedTransactions = (TextView)view.FindViewById(Resource.Id.txtSubstantiatedTransactions);
            



            if (spinner.GetItemAtPosition(e.Position).ToString().Equals("2016"))
            {
                txtTransactions.Text = "58.9k";
                txtClaims.Text = "101.5k";
                txtParticipants.Text = "68.1k";
                txtTransactionsWithNoClaims.Text = "2.9k";
                txtFilteredTransactions.Text = "1.3k";
                txtYetToSubstantiated.Text = "5.9k";
                txtSubstantiatedTransactions.Text = "50.9k";
                

            }
            if (spinner.GetItemAtPosition(e.Position).ToString().Equals("2017"))
            {
                txtTransactions.Text = "85.9k";
                txtClaims.Text = "155.2k";
                txtParticipants.Text = "105.9k";
                txtTransactionsWithNoClaims.Text = "1.5k";
                txtFilteredTransactions.Text = "2.9k";
                txtYetToSubstantiated.Text = "3.9k";
                txtSubstantiatedTransactions.Text = "80.9k";
            }


        }


        public override void OnPrepareOptionsMenu(IMenu menu)
        {


        }
    }
}