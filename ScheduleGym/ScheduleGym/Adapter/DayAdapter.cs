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
        RegisterDayRepository db;
        public DayAdapter(Activity context, List<Day> list)
        {
            _context = context;
            _list = list;
            db = new RegisterDayRepository();
            var tttt = db.GetAllRegisterDay();
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

            view.FindViewById<TextView>(Resource.Id.lblDay).Text = day.DayName;
            var t = db.Where(p => p.Day == position+1 & p.Program == 1).ToList().LastOrDefault();
            if(t!=null)
            {
                view.FindViewById<TextView>(Resource.Id.lblLastDay).Text ="آخرین تمرین :"+ t.Date.ToPersianDateString();
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.lblLastDay).Text = "";
            }
          



            return view;
        }
    }
}