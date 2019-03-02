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

namespace ScheduleGym
{
    [Activity(Label = "PerActivity")]
    public class PerDayActivity : Activity
    {
        ScheduleRepository db;
        private ListView ListView;
        private TextView lblNameDay;
        List<Schedule> schedules;
        int program = 1;
        int day = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PerDaylayout);

            db = new ScheduleRepository();

            day = Intent.GetIntExtra("personId", 0);


            lblNameDay = FindViewById<TextView>(Resource.Id.lblNameDay);


            switch (day)
            {
                case 1:
                    lblNameDay.Text = " روز اول";
                    break;
                case 2:
                    lblNameDay.Text = " روز دوم";
                    break;
                case 3:
                    lblNameDay.Text = "روز سوم";
                    break;
                case 4:
                    lblNameDay.Text = "روز چهارم";
                    break;
                case 5:
                    lblNameDay.Text = "روز پنجم";
                    break;
                case 6:
                    lblNameDay.Text = "روز ششم";
                    break;
                case 7:
                    lblNameDay.Text = "روز هفتم";
                    break;
                default:
                    lblNameDay.Text = "-1";
                    break;
            }

            ListView = FindViewById<ListView>(Resource.Id.lstPerDay);

           schedules= db.Where(p=>p.Program==program&p.Day==day).ToList();

            ListView.Adapter = new ScheduleAdapter(this, schedules);

          lblNameDay.Click += LblNameDay_Click;
            // Create your application here
        }

        private void LblNameDay_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(StatusDayActivity));
            intent.PutExtra("count","تعداد حرکات:  "+ schedules.Count());
            intent.PutExtra("dayname", lblNameDay.Text);
            intent.PutExtra("last","");
            intent.PutExtra("day",day);
            intent.PutExtra("program", program);
            StartActivity(intent);
        }
    }
}