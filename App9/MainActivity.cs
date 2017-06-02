﻿using System;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using CXC.ClaimXO.Android;

namespace App9
{
    [Activity(Label = "@string/ApplicationName", Theme = "@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button loginButton = FindViewById<Button>(Resource.Id.btn_login);

            loginButton.Click += LoginButton_Click;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);



        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            StartActivity(new Intent(Application.Context, typeof(AppMainActivity)));


            //EditText username = FindViewById<EditText>(Resource.Id.txtUserName);
            //EditText password = FindViewById<EditText>(Resource.Id.txtPassword);
            //var linearLayout = FindViewById<LinearLayout>(Resource.Id.main_content);

            //if (string.IsNullOrWhiteSpace(username.Text))
            //{
            //    Snackbar.Make(linearLayout, "Fill in username.", Snackbar.LengthLong)
            //        .SetAction("OK", (v) => { })
            //        .Show();
            //}
            //else if (password.Text != "monkey")
            //{
            //    Snackbar.Make(linearLayout, "Invalid Password", Snackbar.LengthLong)
            //            .SetAction("Clear", (v) => { password.Text = string.Empty; })
            //            .Show();
            //}
            //else
            //{
            //    //var progressDialog = ProgressDialog.Show(this, "Please wait...", "Checking account info...", true);
            //    //new Thread(new ThreadStart(delegate
            //    //{

            //    //    //LOAD METHOD TO GET ACCOUNT INFO                 
            //    //    RunOnUiThread(() => Toast.MakeText(this, "Toast within progress dialog.", ToastLength.Long).Show());
            //    //    //HIDE PROGRESS DIALOG                 
            //    //    RunOnUiThread(() => progressDialog.Hide());

            //    //})).Start();


            //    var progress = ProgressDialog.Show(this, "Loading...", "Please Wait (about 4 seconds)", true);

            //    new Thread(new ThreadStart(() =>
            //    {
            //        Thread.Sleep(4 * 1000);
            //        this.RunOnUiThread(() =>
            //        {
            //            //LOAD METHOD TO GET ACCOUNT INFO    
            //            progress.Dismiss();
            //        });
            //    })).Start();

            //    StartActivity(new Intent(Application.Context, typeof(DashboardActivity)));

            //    //Snackbar.Make(linearLayout, "You are now Logged in!", Snackbar.LengthLong)
            //    //        .Show();
            //}


        }
    }
}

