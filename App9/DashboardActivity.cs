using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using CXC.ClaimXO.Android;
using Com.Syncfusion.Charts;
using Android.Text;
using Android.Text.Style;
using Android.Graphics;

namespace App9
{
    [Activity(Label = "Dashboard", Theme = "@style/MyTheme")]
    public class DashboardActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Dashboard);

            //TextView txtTotalTransactions = FindViewById<TextView>(Resource.Id.txtTotalTransaction);
            //TextView txtTotalClaims = FindViewById<TextView>(Resource.Id.txtTotalClaims);
            //TextView txtTotalParticipants = FindViewById<TextView>(Resource.Id.txtTotalParticipants);

            ////String transactions = "20.5k \n\n  Transactions";
            ////SpannableString ssTotalTransactions = new SpannableString(transactions);
            ////ssTotalTransactions.SetSpan(new RelativeSizeSpan(2f), 0, 5, 0); // set size
            ////ssTotalTransactions.SetSpan(new ForegroundColorSpan(Color.Red), 0, 5, 0);// set color


            ////txtTotalTransactions.TextFormatted = ssTotalTransactions;

            //string transaction = "25.05k \n\n Transactions";
            //SpannableString ssTotalTransactions = FormateText(transaction);
            //txtTotalTransactions.TextFormatted = ssTotalTransactions;



            
            //string claims = "20.05k \n\n Claims";
            //SpannableString ssTotalClaims = FormateText(claims);
            //txtTotalClaims.TextFormatted = ssTotalClaims;



            //string participants = "45.05k \n\n Participants";
            //SpannableString ssTotalParticipants = FormateText(participants);
            //txtTotalParticipants.TextFormatted = ssTotalParticipants;





            //SfChart chart = new SfChart(this);

            ////Initializing Primary Axis

            //CategoryAxis primaryAxis = new CategoryAxis();

            //primaryAxis.Title.Text = "Month";

            //chart.PrimaryAxis = primaryAxis;

            ////Initializing Secondary Axis

            //NumericalAxis secondaryAxis = new NumericalAxis();

            //secondaryAxis.Title.Text = "Temperature";

            //chart.SecondaryAxis = secondaryAxis;

            //chart.Title.Text = "Weather Analysis";


            ////Adding the series to the chart

            //DataModel dataModel = new DataModel();
            //chart.Series.Add(new ColumnSeries()
            //{
            //    DataSource = dataModel.HighTemperature
            //});

            //SetContentView(chart);
            //// Create your application here
        }

        private static SpannableString FormateText(String stringToFormat)
        {
            SpannableString ssTotalClaims = new SpannableString(stringToFormat);
            ssTotalClaims.SetSpan(new RelativeSizeSpan(2f), 0, 5, 0); // set size
            ssTotalClaims.SetSpan(new ForegroundColorSpan(Color.Red), 0, 5, 0);// set color
            return ssTotalClaims;
        }

        public class DataModel
        {
            public ObservableArrayList HighTemperature;

            public DataModel()
            {
                HighTemperature = new ObservableArrayList();
                HighTemperature.Add(new ChartDataPoint("Jan", 42));
                HighTemperature.Add(new ChartDataPoint("Feb", 44));
                HighTemperature.Add(new ChartDataPoint("Mar", 53));
                HighTemperature.Add(new ChartDataPoint("Apr", 64));
                HighTemperature.Add(new ChartDataPoint("May", 75));
                HighTemperature.Add(new ChartDataPoint("Jun", 83));
                HighTemperature.Add(new ChartDataPoint("Jul", 87));
                HighTemperature.Add(new ChartDataPoint("Aug", 84));
                HighTemperature.Add(new ChartDataPoint("Sep", 78));
                HighTemperature.Add(new ChartDataPoint("Oct", 67));
                HighTemperature.Add(new ChartDataPoint("Nov", 55));
                HighTemperature.Add(new ChartDataPoint("Dec", 45));
            }
        }
    }
}