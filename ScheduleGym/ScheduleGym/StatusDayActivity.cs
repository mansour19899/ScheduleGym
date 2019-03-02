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
    [Activity(Label = "StatusDayActivity")]
    public class StatusDayActivity : Activity
    {
        private TextView lblShowDay;
        private TextView lblLastExersice;
        private TextView lblCountExersice;
        private Button btnAdd;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Statuslayout);

            lblLastExersice = FindViewById<TextView>(Resource.Id.lblLastExersice);
            lblCountExersice = FindViewById<TextView>(Resource.Id.lblCountExersice);
            lblShowDay = FindViewById<TextView>(Resource.Id.lblShowDay);
            btnAdd = FindViewById<Button>(Resource.Id.btnAdd);


            lblCountExersice.Text= Intent.GetStringExtra("count");
            lblShowDay.Text = Intent.GetStringExtra("dayname");
            lblLastExersice.Text = Intent.GetStringExtra("last");

            btnAdd.Click += BtnAdd_Click;
            // Create your application here
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(ExersiceGroupActivity));
            intent.PutExtra("day", Intent.GetIntExtra("day", 0));
            intent.PutExtra("program", Intent.GetIntExtra("program", 0));
            StartActivity(intent);

        }
    }
}