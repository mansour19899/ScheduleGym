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
    [Activity(Label = "Splash", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true,NoHistory =true)]
    public class Splash : Activity
    {
        exerciseRepository db;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Splash);

             db = new exerciseRepository();
            if(db.HaveAnyExercise())
            {
                Toast.MakeText(this, "Hello ", ToastLength.Long).Show();
                StartActivity(typeof(MainActivity));
            }
            else
            {
                AddExercise();
                Toast.MakeText(this, "ADD ", ToastLength.Long).Show();
                StartActivity(typeof(MainActivity));

            }
            // Create your application here
        }

        public void AddExercise()
        {
            db.InsertExercise(new Exercise() { Id = 1, type = 1, name = "عضله سینه", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 2, type = 1, name = "پرس سینه هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 3, type = 1, name = "پرس بالاسینه هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 4, type = 1, name = "شنا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 5, type = 1, name = "کراس اُوِر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 6, type = 1, name = "فلای دمبل میز شیبدار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 7, type = 1, name = "فلای دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 8, type = 1, name = "پرس بالاسینه دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 9, type = 1, name = "پرس سینه دمبل با دست های موازی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 10, type = 1, name = "پرس زیرسینه دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 11, type = 1, name = "فلای زیرسینه دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 12, type = 1, name = "پرس بالا سینه دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 13, type = 1, name = "پرس زیر سینه دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 14, type = 1, name = "دستگاه قفسه سینه (باترفلای)", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 15, type = 1, name = "پرس سینه دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 16, type = 1, name = "پرس بالاسینه با اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 17, type = 1, name = "پرس سینه هالتر با اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 18, type = 1, name = "پاس دادن مدیسین بال", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 19, type = 1, name = "کشش سینه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 20, type = 1, name = "کشش سینه و جلوی سرشانه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 21, type = 1, name = "سوئِند پرس (پرس میانه سینه)", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 22, type = 2, name = "عضله شانه", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 23, type = 2, name = "طناب کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 24, type = 2, name = "نشر از بغل با کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 25, type = 2, name = "سرکول با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 26, type = 2, name = "پرس سرشانه از پشت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 27, type = 2, name = "نشر از جانب تک دست با سیمکش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 28, type = 2, name = "نشر از جلو تک دست با سیمکش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 29, type = 2, name = "فیس پول نشسته", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 30, type = 2, name = "سرشانه خلفی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 31, type = 2, name = "نشر از جلو دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 32, type = 2, name = "نشر از بغل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 33, type = 2, name = "نشر از طرفین نشسته", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 34, type = 2, name = "پرس سرشانه دمبل ایستاده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 35, type = 2, name = "فلای برعکس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 36, type = 2, name = "نشر از جانب با دمبل روی بنچ شیبدار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 37, type = 2, name = "پرس سرشانه دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 38, type = 2, name = "سرشانه خلفی دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 39, type = 2, name = "شراگ با اسمیت از پشت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 40, type = 2, name = "شراگ با اسمیت از جلو", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 41, type = 2, name = "پرتاب مدیسین بال", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 42, type = 2, name = "گردش سرشانه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 43, type = 2, name = "طول موج", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 44, type = 2, name = "کشش سرشانه", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 45, type = 3, name = "عضله جلو بازو", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 46, type = 3, name = "جلوبازو هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 47, type = 3, name = "جلوبازو هالتر معکوس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 48, type = 3, name = "جلوبازو چکش با طناب", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 49, type = 3, name = "جلوبازو دوبل با سیمکش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 50, type = 3, name = "جلوبازو سیمکش خوابیده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 51, type = 3, name = "چکش دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 52, type = 3, name = "جلو بازو دمبل لاری", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 53, type = 3, name = "جلو بازو دمبل روی میز شیبدار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 54, type = 3, name = "جلوبازو دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 55, type = 3, name = "جلوبازو تمرکزی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 56, type = 3, name = "جلوبازو دمبل نشسته", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 57, type = 3, name = "جلوبازو لاری ایستاده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 58, type = 3, name = "جلوبازو عنکبوتی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 59, type = 3, name = "جلوبازو لاری معکوس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 60, type = 3, name = "فوم رولینگ روی جلوبازو", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 61, type = 3, name = "دستگاه جلوبازی لاری", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 62, type = 4, name = "عضلات پشت بازو", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 63, type = 4, name = "پرس سینه هالتر دست جمع", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 64, type = 4, name = "بورد پرس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 65, type = 4, name = "پرس سینه دست جمع", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 66, type = 4, name = "پرس پشت بازو هالتر معکوس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 67, type = 4, name = "شنا پشت بازو", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 68, type = 4, name = "دیپ پشت بازو", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 69, type = 4, name = "دیپ پشت بازو با بنچ", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 70, type = 4, name = "پشت بازو سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 71, type = 4, name = "پشت بازو طناب از پشت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 72, type = 4, name = "پشت بازو طناب", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 73, type = 4, name = "پشت بازو سیمکش برعکس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 74, type = 4, name = "پشت بازو سیمکش معکوس تک دست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 75, type = 4, name = "اسکال کراشر با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 76, type = 4, name = "پشت بازو دمبل ایستاده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 77, type = 4, name = "پشت بازو دمبل همزمان از بالای سر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 78, type = 4, name = "پرس پشت بازو دمبل نشسته", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 79, type = 4, name = "پشت بازو کیک بک با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 80, type = 4, name = "اسکال کراشر با میله لاری", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 81, type = 4, name = "دستگاه دیپ", cardio = false, IsExercise = true });

           // db.InsertExercise(new Exercise() { Id = 43, type = 4, name = "", cardio = false, IsExercise = true });






            Toast.MakeText(this, "ADD Shod ", ToastLength.Long).Show();
        }
    }
}