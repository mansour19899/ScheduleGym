﻿using System;
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
    [Activity(Label = "AddExerciseActivity",NoHistory =true)]

    public class AddExerciseActivity : Activity
    {
        int Id;
        int day;
        int program;
        int _set = 0;
        int _count = 0;
        string _time = "";
        exerciseRepository db;
        ScheduleRepository dbb;
        EditText txtSet;
        EditText txtCount;
        EditText txtMin;
        Button btnAddExersice;
        Exercise exercise;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AddExerciselayout);

            db = new exerciseRepository();
            dbb = new ScheduleRepository();

            Id = Intent.GetIntExtra("id", 0);
             day = Intent.GetIntExtra("day", 0);
             program = Intent.GetIntExtra("program", 0);

             exercise = db.Find(p => p.Id == Id);

            TextView lblShowExercise = FindViewById<TextView>(Resource.Id.lblShowExercise);
            txtSet = FindViewById<EditText>(Resource.Id.txtSet);
            txtCount = FindViewById<EditText>(Resource.Id.txtCount);
            txtMin = FindViewById<EditText>(Resource.Id.txtMin);
            btnAddExersice = FindViewById<Button>(Resource.Id.btnAddExersice);

            LinearLayout liner1 = FindViewById<LinearLayout>(Resource.Id.liner1);
            LinearLayout liner2 = FindViewById<LinearLayout>(Resource.Id.liner2);

            if (exercise.cardio)
            {
                liner1.Visibility = ViewStates.Invisible;
            }
            else
            {
                liner2.Visibility = ViewStates.Invisible;
            }

            lblShowExercise.Text =exercise.name;
            btnAddExersice.Click += BtnAddExersice_Click;
            // Create your application here
        }

        private void BtnAddExersice_Click(object sender, EventArgs e)
        {
            if (exercise.cardio)
            {
                _set = 0;
                _count = 0;
                _time = txtMin.Text;
            }
            else
            {
                _set = Convert.ToInt16(txtSet.Text);
                _count = Convert.ToInt16(txtCount.Text);
                _time ="";
            }


            if ((txtCount.Text==""||txtSet.Text=="")&txtMin.Text=="")
            {
                Toast.MakeText(this, "مقادیر را وارد کنید", ToastLength.Long).Show();
            }
            else
            {
                
                dbb.InsertSchedule(new Schedule() { Exercise_FK = exercise.Id, Exercise = exercise.name, Time = _time, Set = _set, Count = _count, Program = program, Day = day, Enable = true });
                Toast.MakeText(this, "اضافه شد", ToastLength.Long).Show();
                FinishAffinity();
                StartActivity(typeof(DaysActivity));
                var intent = new Intent(this, typeof(PerDayActivity));
                intent.PutExtra("personId", day);
                StartActivity(intent);

            }


        }
    }
}