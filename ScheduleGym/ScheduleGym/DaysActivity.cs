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
    [Activity(Label = "DaysActivity")]
    public class DaysActivity : Activity
    {
        ScheduleRepository db;
        private ListView ListView;
        int Program = 1;
           protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Dayslayout);
            DateTime tt = DateTime.Now;
            db = new ScheduleRepository();
            if (!db.HaveAnySchedule())
            {
                db.InsertSchedule(new Schedule() { Id = 1, Exercise_FK = 0, Exercise = "", Time = "", Set = 0, Count = 0, Program = 1, Day = -3, Enable = true });
            }
                       

            //exerciseRepository g = new exerciseRepository();
            //var t = g.GetExerciseById(3);
            //var tt= g.GetExerciseById(4);
            //db.InsertSchedule(new Schedule() { Exercise_FK = t.Id, Exercise = t.name, Time = "", Set = 3, Count = 6, Program = 1, Day = 1, Enable = true });
            // db.InsertSchedule(new Schedule() {  Exercise_FK = tt.Id, Exercise = tt.name, Time = "", Set = 4, Count = 12, Program = 1, Day = 1 ,Enable = true });
            //var y = db.GetAllSchedule();
            UpdateList();
            ListView.ItemClick += ListView_ItemClick;

            // Create your application here
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int id = (int)e.Id;
            var intent = new Intent(this, typeof(PerDayActivity));
            intent.PutExtra("personId", id);
           StartActivity(intent);
        }

        public void UpdateList()
        {
            int take = 0; 
            try
            {
                 take = db.Find(p => p.Enable == true & p.Day < 0).Day * -1;
             
            }
            catch (Exception)
            {

                 take=0;
            }

            Day rrr = new Day(take);
            ListView = FindViewById<ListView>(Resource.Id.listViewDays);
            ListView.Adapter = new DayAdapter(this, rrr.days());
        }
    }
}