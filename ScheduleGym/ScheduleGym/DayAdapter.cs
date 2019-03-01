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
    class DayAdapter : BaseAdapter<Day>
    {
        private Activity _context;
        private List<Day> _list;
        public DayAdapter(Activity context, List<Day> list)
        {
            _context = context;
            _list = list;
        }
        public override Day this[int position]
        {
            get { return _list[position]; }
        }

        public override int Count {
            get { return _list.Count; }
        }

        public override long GetItemId(int position)
        {
            return _list[position].id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
                view = _context.LayoutInflater.Inflate(Resource.Layout.ListItemDay, null);


            Day day = _list[position];

            view.FindViewById<TextView>(Resource.Id.lblyear).Text = day.DayName;


            return view;
        }
    }
}