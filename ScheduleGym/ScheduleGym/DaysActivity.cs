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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Dayslayout);

            db = new ScheduleRepository();
            if (!db.HaveAnySchedule())
            {
                db.InsertSchedule(new Schedule() { Id = 1, Exercise_FK = 0, Exercise = "", Time = "", Set = 0, Count = 0, Program = 0, Day = -3, Enable = true });
            }

            ListView = FindViewById<ListView>(Resource.Id.listViewDays);

            var t = db.GetAllSchedule();
            int x = 0;
            // Create your application here
        }
    }
}