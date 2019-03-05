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
    [Activity(Label = "PerExerciseActivity")]
    public class PerExerciseActivity : Activity
    {
        int id;
        EditText txtWeight;
        Button btnPassed;
        Button btnNotNow;
        RegisterDayRepository db;
        ScheduleRepository dbb;
        Schedule schedule;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PerExerciselayout);

            id = Intent.GetIntExtra("Id", 0);

            db = new RegisterDayRepository();
            dbb = new ScheduleRepository();

            TextView lblShowPerExercise = FindViewById<TextView>(Resource.Id.lblShowPerExercise);
            TextView lblShowPerSet = FindViewById<TextView>(Resource.Id.lblShowPerSet);
            txtWeight = FindViewById<EditText>(Resource.Id.txtWeight);
            btnPassed = FindViewById<Button>(Resource.Id.btnPassed);
            btnNotNow = FindViewById<Button>(Resource.Id.btnNotNow);

            schedule = dbb.Find(p => p.Id == id);
            lblShowPerExercise.Text = schedule.Exercise;
            lblShowPerSet.Text = schedule.Set + "*" + schedule.Count;

            btnNotNow.Click += BtnNotNow_Click;
            btnPassed.Click += BtnPassed_Click;

            // Create your application here
        }

        private void BtnPassed_Click(object sender, EventArgs e)
        {
            if(txtWeight.Text != "")
            {
                if (db.Today(schedule.Exercise_FK, DateTime.Today))
                {
                    var date = DateTime.Today.ToShortDateString();
                    var y = db.GiveMe(schedule.Exercise_FK, DateTime.Today);
                    var f = db.GetAllRegisterDay();
                    var u = y.Date.ToShortDateString();
                    if (u == date)
                    {
                        y.Date = DateTime.Today;
                        y.weight = Convert.ToDecimal(txtWeight.Text);
                    }

                    db.UpdateRegisterDay(y);
                    Toast.MakeText(this, "تغییر یافت", ToastLength.Long).Show();
                    var intent = new Intent(this, typeof(PerDayActivity));
                    intent.PutExtra("personId", y.Day);
                    StartActivity(intent);
                    Finish();
                }
                else
                {
                    db.InsertRegisterDay(new RegisterDay()
                    {
                        Exercise = schedule.Exercise,
                        Exercise_FK = schedule.Exercise_FK,
                        Time = schedule.Time,
                        Set = schedule.Set,
                        Count = schedule.Count,
                        Program = schedule.Program,
                        Day = schedule.Day,
                        Date = DateTime.Now,
                        weight = Convert.ToDecimal(txtWeight.Text)
                    });
                    Toast.MakeText(this, "ثبت شد", ToastLength.Long).Show();
                    var intent = new Intent(this, typeof(PerDayActivity));
                    intent.PutExtra("personId", schedule.Day);
                    StartActivity(intent);
                    Finish();

                }
            }
            else
            {
                Toast.MakeText(this, "وزن را وارد کنید", ToastLength.Long).Show();
            }



        }

        private void BtnNotNow_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(PerDayActivity));
            intent.PutExtra("personId", schedule.Day);
            StartActivity(intent);
            Finish();
        }
    }
}