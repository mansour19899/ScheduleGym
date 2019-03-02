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
        int i =1;
        public ScheduleAdapter(Activity context, List<Schedule> list)
        {
            _context = context;
            _list = list;
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

            view.FindViewById<TextView>(Resource.Id.lblNameExersice).Text = i+" - "+Schedule.Exercise;
            
            view.FindViewById<TextView>(Resource.Id.lblSet).Text = Schedule.Set+"*"+Schedule.Count;

            i++;

            return view;
        }
    }
}
