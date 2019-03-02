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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Exerciselayout);

            var t = Intent.GetIntExtra("program", 0);
            var tt = Intent.GetIntExtra("day", 0);
            var ttt = Intent.GetIntExtra("type", 0);

            int x = 0;
            // Create your application here
        }
    }
}