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
    class Schedule
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public int Exercise_FK { get; set; }
        [NotNull]
        [MaxLength(40)]
        public string Exercise { get; set; }
        [NotNull]
        [MaxLength(4)]
        public string Time { get; set; }
        [NotNull]
        public int Set { get; set; }
        [NotNull]
        public int Count { get; set; }
        [NotNull]
        public int Program { get; set; }
        [NotNull]
        public int Day { get; set; }

        [NotNull]
        public bool Enable { get; set; }

    }

    class ScheduleRepository
    {
        private string dbPath = "";
        private string dbName = "MyScheduleDb";
        private SQLiteConnection db;

        public ScheduleRepository()
        {
            dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            db = new SQLiteConnection(platform, Path.Combine(dbPath, dbName));

            db.CreateTable<Schedule>();
        }

        public List<Schedule> GetAllSchedule()
        {
            return db.Table<Schedule>().ToList();
        }

        public Schedule GetScheduleById(int ScheduleId)
        {
            return db.Table<Schedule>().SingleOrDefault(f => f.Id == ScheduleId);
        }

        public int GetLastId()
        {
            return db.Table<Schedule>().Max(p => p.Id);
        }
        public void InsertSchedule(Schedule Schedule)
        {
            Schedule.Id = Schedule.Id;
            db.Insert(Schedule);
        }

        public void UpdateSchedule(Schedule Schedule)
        {
            db.Update(Schedule);
        }

        public void DeleteSchedule(Schedule Schedule)
        {
            db.Delete(Schedule);
        }

        public bool HaveAnySchedule()
        {
            return db.Table<Schedule>().Any();
        }
    }
}