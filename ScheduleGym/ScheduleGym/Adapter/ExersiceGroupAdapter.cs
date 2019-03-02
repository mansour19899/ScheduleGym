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
    class ExersiceGroupAdapter  : BaseAdapter<Exercise>
    {
        private Activity _context;
        private List<Exercise> _list;
        public ExersiceGroupAdapter(Activity context, List<Exercise> list)
        {
            _context = context;
            _list = list;
        }
        public override Exercise this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.ListItemExersiceGroup, null);


            Exercise Exercise = _list[position];

            view.FindViewById<TextView>(Resource.Id.lblExersiceGroup).Text = Exercise.name;


            return view;
        }
    }
}