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
    class Day
    {
        public int id { get; set; }
        public string DayName { get; set; }
        private int _takeDay =7;
        public Day()
        {

        }
        public Day(int take)
        {
            _takeDay = take;
        }
        public List<Day> days()
        {
            return (new List<Day>()
            {
                new Day() {id=1, DayName="   روز اول"},
                new Day() {id=2, DayName="   روز دوم"},
                new Day() {id=3, DayName="  روز سوم"},
                new Day() {id=4, DayName="روز چهارم"},
                new Day() {id=5, DayName="روز پنجم"},
                new Day() {id=6, DayName="روز ششم"},
                new Day() {id=7, DayName="روز هفتم"},

            }).Take(_takeDay).ToList();
        }
    }


}