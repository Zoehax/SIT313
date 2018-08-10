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

namespace Calendar_1
{
    [Activity(Label = "INPUT TEXT PAGE")]
    public class Activity_mid : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Activity_mid);

            var edtName = FindViewById<EditText>(Resource.Id.edtName);//the edit text V7 supt
            var edtEmail = FindViewById<EditText>(Resource.Id.edtEmail);
            var btnSend = FindViewById<Button>(Resource.Id.btnSend);
            btnSend.Click += (s, e) =>
            {
                Intent nextActity = new Intent(this, typeof(Activity_info));
                nextActity.PutExtra("name", edtName.Text);
                nextActity.PutExtra("email", edtEmail.Text);
                StartActivity(nextActity);
            };

            var txtBack1 = FindViewById<Button>(Resource.Id.btnBack1);
            txtBack1.Click += delegate
            {
                this.Finish();
            };

        }
    }
}