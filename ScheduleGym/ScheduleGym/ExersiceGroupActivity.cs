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
    [Activity(Label = "ExersiceGroupActivity")]
    public class ExersiceGroupActivity : Activity
    {
        exerciseRepository db;
        private ListView ListView;
        List<Exercise> listGroup;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ExersiceGrouplayout);

            db = new exerciseRepository();

             listGroup = db.Where(p => p.IsExercise == false).ToList(); ;

            ListView = FindViewById<ListView>(Resource.Id.lstExersiceGroup);
            ListView.Adapter = new ExersiceGroupAdapter(this, listGroup);

            ListView.ItemClick += ListView_ItemClick;
            // Create your application here
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int id = (int)e.Id;
            var intent = new Intent(this, typeof(ExerciseActivity));
            intent.PutExtra("type", listGroup[e.Position].type);
            intent.PutExtra("namegroup", listGroup[e.Position].name);
            intent.PutExtra("day", Intent.GetIntExtra("day", 0));
            intent.PutExtra("program", Intent.GetIntExtra("program", 0));
            StartActivity(intent);
        }
    }
}