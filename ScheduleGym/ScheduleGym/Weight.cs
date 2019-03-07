using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net;
using SQLite.Net.Attributes;

namespace ScheduleGym
{
    class Weight
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public decimal weight { get; set; }

        [NotNull]
        public DateTime Date { get; set; }
    }
    class WeightRepository
    {
        private string dbPath = "";
        private string dbName = "MyScheduleDb";
        private SQLiteConnection db;

        public WeightRepository()
        {
            dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            db = new SQLiteConnection(platform, Path.Combine(dbPath, dbName));

            db.CreateTable<Weight>();
        }

        public List<Weight> GetAllWeight()
        {
            return db.Table<Weight>().ToList();
        }

        public Weight GetWeightById(int WeightId)
        {
            return db.Table<Weight>().SingleOrDefault(f => f.Id == WeightId);
        }

        public int GetLastId()
        {
            return db.Table<Weight>().Max(p => p.Id);
        }
        public void InsertWeight(Weight Weight)
        {
            Weight.Id = Weight.Id;
            db.Insert(Weight);
        }

        public void UpdateWeight(Weight Weight)
        {
            db.Update(Weight);
        }

        public void DeleteWeight(Weight Weight)
        {
            db.Delete(Weight);
        }

        public Weight Find(System.Linq.Expressions.Expression<Func<Weight, bool>> predicate)
        {
            try
            {
                return db.Find(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<Weight> Where(System.Linq.Expressions.Expression<Func<Weight, bool>> predicate)
        {
            try
            {
                return db.Table<Weight>().Where(predicate).AsQueryable();
            }
            catch
            {
                return null;
            }
        }
        public bool Today()
        {
            try
            {
                return db.Table<Weight>().Any(p => p.Date.ToShortDateString()==DateTime.Now.ToShortDateString());

            }
            catch
            {
                return false;
            }
        }
        public Weight GiveMe()
        {
            try
            {
                //   return db.Table<Weight>().Where(p => p.Date.ToShortDateString().CompareTo(DateTime.Now.ToShortDateString()) == 0).ToList().LastOrDefault();
                var lastID = GetLastId ();
                var lastWeight= GetWeightById(lastID);
                
                if(lastWeight.Date.Year == DateTime.Today.Year&lastWeight.Date.DayOfYear==DateTime.Today.DayOfYear)
                {
                    return lastWeight;
                }
                else
                return null;

            }
            catch
            {
                return null;
            }
        }
        public bool HaveAnyWeight()
        {
            return db.Table<Weight>().Any();
        }
    }

}