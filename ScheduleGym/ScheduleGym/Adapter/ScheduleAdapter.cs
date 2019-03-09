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
    class ScheduleAdapter : BaseAdapter<Schedule>
    {
        private Activity _context;
        private List<Schedule> _list;
        
        RegisterDayRepository db;
        public ScheduleAdapter(Activity context, List<Schedule> list)
        {
            _context = context;
            _list = list;
            db = new RegisterDayRepository();
        }
        public override Schedule this[int position]
        {
            get { return _list[position]; }
        }

        public override int Count
        {
            get { return _list.Count; }
        }

        public override long GetItemId(int position)
        {
            return _list[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
                view = _context.LayoutInflater.Inflate(Resource.Layout.ListItemSchedule, null);


            Schedule Schedule = _list[position];

            view.FindViewById<TextView>(Resource.Id.lblNameExersice).Text = (position+1)+" - "+Schedule.Exercise;
            view.FindViewById<TextView>(Resource.Id.lblSet).Text = Schedule.Set + "*" + Schedule.Count;
            if (Schedule.Count==0)
            {
                view.FindViewById<TextView>(Resource.Id.lblSet).Text = Schedule.Time + "    دقیقه";
            }
           
            if(db.Today(Schedule.Exercise_FK, DateTime.Now))
            {
                view.FindViewById<TextView>(Resource.Id.lblNameExersice).SetTextColor(Android.Graphics.Color.DarkGreen);
                view.FindViewById<TextView>(Resource.Id.lblSet).SetTextColor(Android.Graphics.Color.DarkGreen);
            }

           

            return view;
        }
    }
}
