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
    [Activity(Label = "HistoryDayActivity")]
    public class HistoryDayActivity : Activity
    {
        private ListView ListView;
        RegisterDayRepository db;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HistoryDaylayout);

            db = new RegisterDayRepository();
            ListView = FindViewById<ListView>(Resource.Id.lstHistoryDay);
            List<Schedule> listd = new List<Schedule>();
            var list = db.GetLatestRegisterDay(20);

            foreach (var item in list)
            {
                listd.Add(new Schedule() { Exercise=item.Exercise+"------"+item.Date.ToPersianDateString()});
            }
            ListView.Adapter = new ScheduleAdapter(this, listd);
            // Create your application here
        }
    }
}