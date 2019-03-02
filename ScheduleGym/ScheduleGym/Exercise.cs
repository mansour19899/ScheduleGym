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
    class Exercise
    {
        [PrimaryKey]
        public int Id { get; set; }
        [NotNull]
        [MaxLength(500)]
        public string name { get; set; }

        public int type { get; set; }

        public bool cardio { get; set; }
        public bool IsExercise { get; set; }
    }

    class exerciseRepository
    {
         private string dbPath = "";
        private string dbName = "MyScheduleDb";
        private SQLiteConnection db;

        public exerciseRepository()
        {
            dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            db = new SQLiteConnection(platform, Path.Combine(dbPath, dbName));

            db.CreateTable<Exercise>();
        }

        public List<Exercise> GetAllExercise()
        {
            return db.Table<Exercise>().ToList();
        }

        public Exercise GetExerciseById(int exerciseId)
        {
            return db.Table<Exercise>().SingleOrDefault(f => f.Id == exerciseId);
        }

        public int GetLastId()
        {            
            return db.Table<Exercise>().Max(p => p.Id);
        }
        public void InsertExercise(Exercise exercise)
        {
            exercise.Id = exercise.Id;
            db.Insert(exercise);
        }

        public void UpdateExercise(Exercise exercise)
        {
            db.Update(exercise);
        }

        public void DeleteExercise(Exercise exercise)
        {
            db.Delete(exercise);
        }

        public Exercise Find(System.Linq.Expressions.Expression<Func<Exercise, bool>> predicate)
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

        public IQueryable<Exercise> Where(System.Linq.Expressions.Expression<Func<Exercise, bool>> predicate)
        {
            try
            {
                return db.Table<Exercise>().Where(predicate).AsQueryable();
            }
            catch
            {
                return null;
            }
        }

        public bool HaveAnyExercise()
        {
            return db.Table<Exercise>().Any();
        }
    }

}