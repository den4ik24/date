using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using System;

namespace date
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
       
        DatePicker datePicker;
        Button remain;
        TextView days;
        TextView hours;
        TextView minutes;
        TextView seconds;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
                      
            datePicker = FindViewById<DatePicker>(Resource.Id.datePicker);
            
            remain = FindViewById<Button>(Resource.Id.remain);
            remain.Click += Remain_Click;

            days = FindViewById<TextView>(Resource.Id.days);

            hours = FindViewById<TextView>(Resource.Id.hours);

            minutes = FindViewById<TextView>(Resource.Id.minutes);

            seconds = FindViewById<TextView>(Resource.Id.seconds);
        }

        private void Remain_Click(object sender, EventArgs e)
        {
            try
            {
                var dateTimeNow = DateTime.Today;
                TimeSpan span = datePicker.DateTime - dateTimeNow;

                days.Text = "Дней : " + span.TotalDays.ToString();
                hours.Text = "Часов : " + span.TotalHours.ToString();
                minutes.Text = "Минут : " + span.TotalMinutes.ToString();
                seconds.Text = "Секунд : " + span.TotalSeconds.ToString();
            }
            catch(Exception)
            {

            }
        }

        // Unhandled Exception: Java.Lang.RuntimeException: <Timeout exceeded getting exception details>
        // I/Process (12702): Sending signal. PID: 12702 SIG: 9
    }
}