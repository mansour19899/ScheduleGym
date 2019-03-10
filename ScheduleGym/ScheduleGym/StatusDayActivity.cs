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
        EditText txtAddWeight;
        private Button btnAdd;
        private Button btnAddWeight;
        private Button btnBack;
        private Button btnHistoryDay;
        WeightRepository db;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Statuslayout);
            db = new WeightRepository();

            lblLastExersice = FindViewById<TextView>(Resource.Id.lblLastExersice);
            lblCountExersice = FindViewById<TextView>(Resource.Id.lblCountExersice);
            lblShowDay = FindViewById<TextView>(Resource.Id.lblShowDay);
            btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            btnAddWeight = FindViewById<Button>(Resource.Id.btnAddWeight);
            btnBack = FindViewById<Button>(Resource.Id.btnBack);
            btnHistoryDay = FindViewById<Button>(Resource.Id.btnHistoryDay);
            txtAddWeight = FindViewById<EditText>(Resource.Id.txtAddWeight);


            lblCountExersice.Text= Intent.GetStringExtra("count");
            lblShowDay.Text = Intent.GetStringExtra("dayname");
            lblLastExersice.Text = Intent.GetStringExtra("last");

            btnAdd.Click += BtnAdd_Click;
            btnAddWeight.Click += BtnAddWeight_Click;
            btnBack.Click += BtnBack_Click;
            btnHistoryDay.Click += BtnHistoryDay_Click;
            // Create your application here
        }

        private void BtnHistoryDay_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(HistoryDayActivity));
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void BtnAddWeight_Click(object sender, EventArgs e)
        {
            if(txtAddWeight.Text!="")
            {
                var ttt = db.GetAllWeight();
                var ty = Convert.ToDecimal(txtAddWeight.Text);

                if (db.Today())
                {
                    var y = db.GiveMe();
                    y.weight = ty;
                    db.UpdateWeight(y);
                    Toast.MakeText(this, "تغییر یافت", ToastLength.Long).Show();
                }
                else
                {
                    db.InsertWeight(new Weight() { weight = Convert.ToDecimal(txtAddWeight.Text), Date = DateTime.Now });
                    Toast.MakeText(this, "ثبت شد", ToastLength.Long).Show();
                }
            }

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