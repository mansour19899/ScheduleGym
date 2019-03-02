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
    class RegisterDay
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public int Exercise_FK { get; set; }
        [NotNull]
        [MaxLength(20)]
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
        public DateTime Date { get; set; }
        public float weight { get; set; }
    }

    class RegisterDayRepository
    {
        private string dbPath = "";
        private string dbName = "MyScheduleDb";
        private SQLiteConnection db;

        public RegisterDayRepository()
        {
            dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            db = new SQLiteConnection(platform, Path.Combine(dbPath, dbName));

            db.CreateTable<RegisterDay>();
        }

        public List<RegisterDay> GetAllRegisterDay()
        {
            return db.Table<RegisterDay>().ToList();
        }

        public RegisterDay GetRegisterDayById(int RegisterDayId)
        {
            return db.Table<RegisterDay>().SingleOrDefault(f => f.Id == RegisterDayId);
        }

        public int GetLastId()
        {
            return db.Table<RegisterDay>().Max(p => p.Id);
        }
        public void InsertRegisterDay(RegisterDay RegisterDay)
        {
            RegisterDay.Id = RegisterDay.Id;
            db.Insert(RegisterDay);
        }

        public void UpdateRegisterDay(RegisterDay RegisterDay)
        {
            db.Update(RegisterDay);
        }

        public void DeleteRegisterDay(RegisterDay RegisterDay)
        {
            db.Delete(RegisterDay);
        }

        public bool HaveAnyRegisterDay()
        {
            return db.Table<RegisterDay>().Any();
        }
    }
}