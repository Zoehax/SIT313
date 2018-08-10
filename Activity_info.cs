using System;
using Android.App;
using Android.Content;
using Android.OS;

using Android.Widget;

namespace Calendar_1
{
    [Activity(Label = "Activity_info")]
    public class Activity_info : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Activity_info);

            string name = Intent.GetStringExtra("name" ?? "Not recv");
            string email = Intent.GetStringExtra("email" ?? "Not recv");

            var txtName = FindViewById<TextView>(Resource.Id.txtName);
            var txtEmail = FindViewById<TextView>(Resource.Id.txtEmail);
            var txtBack = FindViewById<Button>(Resource.Id.btnBack);

            txtName.Text = name;
            txtEmail.Text = email;
            txtBack.Click += delegate
            {
                this.Finish();
            };
        }
    }
}