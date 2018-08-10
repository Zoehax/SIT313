using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace Calendar_1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var calendarView = FindViewById<CalendarView>(Resource.Id.calendarView);
            var txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);

            txtDisplay.Text = "Date: ";

            calendarView.DateChange += (s, e) =>
            {
                int day = e.DayOfMonth;
                int month = e.Month;
                int year = e.Year;
                txtDisplay.Text = "Date: " + day + " / " + month + " / " + year;

            };

            var edtName = FindViewById<EditText>(Resource.Id.edtName);//the edit text V7 supt
            var edtEmail = FindViewById<EditText>(Resource.Id.edtEmail);
            var btnSend = FindViewById<Button>(Resource.Id.btnSend);
            btnSend.Click += (s, e) =>
            {
                Intent nextActity = new Intent(this, typeof(Activity_info));
                nextActity.PutExtra( "name", edtName.Text);
                nextActity.PutExtra("email", edtEmail.Text);
                StartActivity(nextActity);
            };

        }
    }
}

