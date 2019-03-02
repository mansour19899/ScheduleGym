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
    [Activity(Label = "ExerciseActivity")]
    public class ExerciseActivity : Activity
    {
        private ListView ListView;
        exerciseRepository db;
        List<Exercise> listGroup;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Exerciselayout);

            var program = Intent.GetIntExtra("program", 0);
            var day = Intent.GetIntExtra("day", 0);
            var type = Intent.GetIntExtra("type", 0);

            db = new exerciseRepository();

            TextView lblNameGroup = FindViewById<TextView>(Resource.Id.lblNameGroup);
            lblNameGroup.Text = Intent.GetStringExtra("namegroup");

            listGroup = db.Where(p => p.IsExercise == true&p.type==type).ToList(); ;

            ListView = FindViewById<ListView>(Resource.Id.lstShowExercise);
            ListView.Adapter = new ExersiceGroupAdapter(this, listGroup);

            ListView.ItemClick += ListView_ItemClick;
            int x = 0;
            // Create your application here
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int id = (int)e.Id;
            var intent = new Intent(this, typeof(AddExerciseActivity));
            intent.PutExtra("id", listGroup[e.Position].Id);
            intent.PutExtra("day", Intent.GetIntExtra("day", 0));
            intent.PutExtra("program", Intent.GetIntExtra("program", 0));
            StartActivity(intent);
        }
    }
}