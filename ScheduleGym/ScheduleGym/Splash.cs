using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ScheduleGym
{
    [Activity(Label = "MyGym", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true,NoHistory =true)]
    public class Splash : Activity
    {
        exerciseRepository db;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Splash);


            db = new exerciseRepository();
            var t = db.GetAllExercise().Count();

            if(t==234)
            {
                Toast.MakeText(this, "Hello ", ToastLength.Long).Show();
                StartActivity(typeof(DaysActivity));
            }
            else
            {
                DeleteAllExercise();
                AddExercise();
                Toast.MakeText(this, "ADD ", ToastLength.Long).Show();
                StartActivity(typeof(DaysActivity));

            }
            // Create your application here
        }

        public void DeleteAllExercise()
        {
            db.ClearAll();
        }
        public void AddExercise()
        {

            db.InsertExercise(new Exercise() { Id = 1, type = 1, name = " سینه", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 2, type = 1, name = "پرس سینه هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 3, type = 1, name = "پرس بالا سینه با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 4, type = 1, name = "فلای سینه با دستگاه (پروانه)", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 5, type = 1, name = "پل اور دمبل دست صاف", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 6, type = 1, name = "پرس بالا سینه دمبل دست موازی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 7, type = 1, name = "پوش آپ با شیب منفی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 8, type = 1, name = "فلای بالا سینه با سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 9, type = 1, name = "پل اور دمبل دست خم", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 10, type = 1, name = "پل اور دمبل دست خم", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 11, type = 1, name = "سیم کش آیرون کراس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 12, type = 1, name = "پوش آپ با بوسو بال", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 13, type = 1, name = "کراس اور سیم کش تک دست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 14, type = 1, name = "فلای سینه با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 15, type = 1, name = "فلای بالا سینه با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 16, type = 1, name = "فلای سینه سیم کش روی نیمکت صاف", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 17, type = 1, name = "پرس زیر سینه با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 18, type = 1, name = "شنا و پلانک به پهلو", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 19, type = 1, name = "پرس بالا سینه با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 20, type = 1, name = "فلای سینه با سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 21, type = 1, name = "پرس بالا سینه با اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 22, type = 1, name = "پرس بالا سینه با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 23, type = 1, name = "پرس سینه متناوب بر روی سطح زمین", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 24, type = 1, name = "پوش آپ یا شنا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 25, type = 1, name = "پرس سینه با اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 26, type = 1, name = "پرس سینه با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 27, type = 1, name = "پرس سینه با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 28, type = 1, name = "پارالل سینه (دیپ)", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 29, type = 1, name = "پرس زیر سینه با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id =30, type = 1, name = "پرس زیر سینه با دمبل", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 40, type = 2, name = " شانه", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 41, type = 2, name = "پرس سرشانه نشسته با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 42, type = 2, name = "نشر از جانب به نشر از جلو", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 43, type = 2, name = "نشر از جلو با صفحه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 44, type = 2, name = "اسکوات به پرس سرشانه با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 45, type = 2, name = "بتل روپ", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 46, type = 2, name = "نشر از جلو نشسته با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 47, type = 2, name = "پرس سرشانه با اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 48, type = 2, name = "نشر از جلو با سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 49, type = 2, name = "نشر از جلو با سیم کش تک دست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 50, type = 2, name = "کلین اند پرس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 51, type = 2, name = "پرس سرشانه نشسته با سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 52, type = 2, name = "فلای معکوس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 53, type = 2, name = "نشر از جانب تک دست بر روی میز شیب دار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 54, type = 2, name = "پرس سرشانه ایستاده با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 55, type = 2, name = "نشر از جانب با دمبل نشسته", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 56, type = 2, name = "پرس سرشانه با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 57, type = 2, name = "فلای معکوس با سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 58, type = 2, name = "نشر از جانب با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 59, type = 2, name = "نشر از جلو با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 60, type = 2, name = "پرس سرشانه هالتر نظامی نشسته", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 61, type = 2, name = "نشر از جلو دمبل بر روی میز شیب دار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 62, type = 2, name = "پرس سرشانه دمبل تک دست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 63, type = 2, name = "نشر خم نشسته با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 64, type = 2, name = "نشر از جانب تک دست با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 65, type = 2, name = "کشش به طرفین با کش ورزشی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 66, type = 2, name = "پرس نظامی ایستاده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 67, type = 2, name = "کول با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 68, type = 2, name = "پرس دمبل آرنولدی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 69, type = 2, name = "فلای معکوس با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 70, type = 2, name = "پرس سرشانه با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 71, type = 2, name = "نشر از جانب با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 72, type = 2, name = "فیس پول", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 73, type = 2, name = "نشر خم با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 74, type = 2, name = "نشر از جلو با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 75, type = 2, name = "نشر از جانب ایستاده با سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 76, type = 2, name = "پرس سرشانه نشسته با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 77, type = 2, name = "سرشانه ایستاده با هالتر از جلو", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 80, type = 3, name = "دوسر بازو", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 81, type = 3, name = "جلو بازو دمبل بر روی میز شیبدار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 82, type = 3, name = "جلو بازو هالتر تا پیشانی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 83, type = 3, name = "جلو بازو چکشی سیم کش با طناب", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 84, type = 3, name = "جلو بازو دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 85, type = 3, name = "جلو بازو دمبل تک دست روی میز لاری", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 86, type = 3, name = "جلو بازو هالتر EZ دست جمع", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 87, type = 3, name = "جلو بازو تک دمبل خم (متمرکز)", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 88, type = 3, name = "جلو بازو لاری", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 89, type = 3, name = "جلو بازو چکشی دمبل بر روی میز شیبدار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 90, type = 3, name = "جلو بازو سیم کش ایستاده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 91, type = 3, name = "جلو بازو دمبل لاری", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 92, type = 3, name = "جلو بازو نشسته با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 93, type = 3, name = "جلو بازو درگ", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 94, type = 3, name = "جلو بازو عنکبوتی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 95, type = 3, name = "جلو بازو چکشی با صفحه هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 96, type = 3, name = "جلو بازو با هالتر EZ", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 97, type = 3, name = "جلو بازو هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 98, type = 3, name = "جلو بازو سیم کش جفت دست (صلیبی)", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 99, type = 3, name = "جلو بازو هالتر مچ برعکس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 100, type = 3, name = "جلو بازو دمبل متناوب", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 101, type = 3, name = "جلو بازو دمبل دمبل تک تک چکشی", cardio = false, IsExercise = true });


            db.InsertExercise(new Exercise() { Id = 110, type = 4, name = "سه سر پشت بازو", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 111, type = 4, name = "پشت بازو هالتر نشسته از پشت سر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 112, type = 4, name = "پشت بازو سیم کش کیک بک", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 113, type = 4, name = "پشت بازو دمبل کیک بک", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 114, type = 4, name = "پشت بازو هالتر ایستاده از پشت سر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 115, type = 4, name = "پرس سینه هالتر دست جمع", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 116, type = 4, name = "پشت بازو سیم کش میله V", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 117, type = 4, name = "پشت بازو دمبل جفت دست ایستاده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 118, type = 4, name = "دیپ بین دو نیمکت با وزنه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 119, type = 4, name = "دیپ بین دو نیمکت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 120, type = 4, name = "پشت بازو سیم کش با طناب", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 121, type = 4, name = "پشت بازو با سیم کش", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 122, type = 4, name = "پشت بازو خوابیده با هالتر EZ", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 123, type = 4, name = "پشت بازو سیم کش از پشت سر با طناب", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 124, type = 4, name = "پرس پشت بازو نشسته با دمبل جفت دست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 125, type = 4, name = "پشت بازو سیم کش تک دست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 126, type = 4, name = "پشت بازو دیپ بر روی زمین", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 127, type = 4, name = "پشت بازو هالتر پرس مچ برعکس", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 140, type = 5, name = "چهارسر زانو", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 141, type = 5, name = "اسکوات لندماین", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 142, type = 5, name = "لانگ با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 143, type = 5, name = "لانگ به عقب با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 144, type = 5, name = "جلو پا دستگاه تک پا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 145, type = 5, name = "اسکوات اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 146, type = 5, name = "لانگ با وزن بدن", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 147, type = 5, name = "لانگ پرشی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 148, type = 5, name = "اسکوات با مکث", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 149, type = 5, name = "اندرسون اسکوات", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 150, type = 5, name = "پرس پا دستگاه تک پا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 151, type = 5, name = "در جا دویدن", cardio = true, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 152, type = 5, name = "در جا راه رافتن", cardio = true, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 153, type = 5, name = "گابلت اسکوات", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 154, type = 5, name = "اسکوات با وزن بدن", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 155, type = 5, name = "اسکوات پرشی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 156, type = 5, name = "دوچرخه ثابت", cardio = true, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 157, type = 5, name = "طناب زدن", cardio = true, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 158, type = 5, name = "پرس پا دستگاه پا باز", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 159, type = 5, name = "سی سی اسکوات با وزنه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 160, type = 5, name = "اسکوات هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 161, type = 5, name = "اسکوات هالتر پا باز", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 162, type = 5, name = "جامپ اسپلیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 163, type = 5, name = "لانگ دمبل راه رفتن", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 164, type = 5, name = "اسپلیت اسکوات با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 165, type = 5, name = "تردمیل", cardio = true, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 166, type = 5, name = "هک اسکوات", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 167, type = 5, name = "کوهنوردی", cardio = true, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 168, type = 5, name = "برپی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 169, type = 5, name = "اسکوات پا باز پرشی به پا جمع", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 170, type = 5, name = "جامپینگ جک", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 171, type = 5, name = "لانگ کتل بل به کنار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 172, type = 5, name = "الپتیکال", cardio = true, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 173, type = 5, name = "اسکوات هالتر کامل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 174, type = 5, name = "جلو پا دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 175, type = 5, name = "پرس پا با دستگاه", cardio = false, IsExercise = true });


            db.InsertExercise(new Exercise() { Id = 180, type = 6, name = "ساق پا", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 181, type = 6, name = "ساق پا پرس با دستگاه پرس پا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 182, type = 6, name = "ساق پا ایستاده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 183, type = 6, name = "ساق پا نشسته با دستگاه", cardio = false, IsExercise = true });


            db.InsertExercise(new Exercise() { Id = 190, type = 7, name = "پشت یا زیربغل", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 191, type = 7, name = "پول آپ با وزنه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 192, type = 7, name = "بارفیکس مچ برعکس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 193, type = 7, name = "زیر بغل سیم کش میله V", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 194, type = 7, name = "زیر بغل سیم کش مچ برعکس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 195, type = 7, name = "زیر بغل سیم کش از جلو دست جمع", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 196, type = 7, name = "زیر بغل سیم کش دست صاف", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 197, type = 7, name = "زیر بغل دستگاه اچ", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 198, type = 7, name = "زیر بغل سیم کش دست باز", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 199, type = 7, name = "بارفیکس", cardio = false, IsExercise = true });
 
            db.InsertExercise(new Exercise() { Id = 210, type = 8, name = "گردن", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 211, type = 8, name = "جلو بازو دمبل چکشی", cardio = false, IsExercise = true });
         
            db.InsertExercise(new Exercise() { Id = 220, type = 9, name = "ذوزنقه", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 221, type = 9, name = "مچ دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 222, type = 9, name = "شراگ هالتر از پشت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 223, type = 9, name = "شراگ دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 224, type = 9, name = "شراگ با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 225, type = 9, name = "شراگ با دستگاه اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 226, type = 9, name = "شراگ با هالتر", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 230, type = 10, name = "میان کمر", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 231, type = 10, name = "پارویی معکوس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 232, type = 10, name = "زیر بغل خم دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 233, type = 10, name = "زیر بغل دمبل روی میز شیبدار", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 234, type = 10, name = "زیر بغل خم با اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 235, type = 10, name = "تی بار دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 236, type = 10, name = "زیر بغل هالتر خم مچ برعکس", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 237, type = 10, name = "زیر بغل خم با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 238, type = 10, name = "پارویی رو به بالا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 239, type = 10, name = "زیر بغل قایقی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 240, type = 10, name = "زیر بغل تک دمبل خم", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 250, type = 11, name = "پایین کمر", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 251, type = 11, name = "رک پول", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 252, type = 11, name = "هایپراکستنشن (فیله کمر)", cardio = false, IsExercise = true });

            db.InsertExercise(new Exercise() { Id = 260, type = 12, name = "ساعد", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 261, type = 12, name = "ساعد ایستاده با هالتر از پشت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 262, type = 12, name = "ساعد با هالتر نشسته", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 263, type = 12, name = "مچ", cardio = false, IsExercise = true });


            db.InsertExercise(new Exercise() { Id = 270, type = 13, name = "شکم", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 271, type = 13, name = "بالا آوردن موربی زانو در حالت آویزان", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 272, type = 13, name = "کرانچ بر روی میز با شیب منفی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 273, type = 13, name = "کرانچ روی توپ تمرین", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 274, type = 13, name = "لمس انگشتان پا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 275, type = 13, name = "کشیدن توپ تمرین به سمت شکم", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 276, type = 13, name = "شکم غلطک", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 277, type = 13, name = "کرانچ دوچرخه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 278, type = 13, name = "پلانک", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 279, type = 13, name = "کرانچ مورب", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 280, type = 13, name = "کرانچ", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 281, type = 13, name = "بالابردن باسن با اسمیت", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 282, type = 13, name = "شکم خلبانی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 283, type = 13, name = "کرانچ شکم با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 284, type = 13, name = "درازنشست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 285, type = 13, name = "درازنشست روی میز با شیب منفی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 286, type = 13, name = "چرخش آرنج به زانوی پای مخالف", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 287, type = 13, name = "کرانچ معکوس روی میز با شیب منفی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 288, type = 13, name = "درازنشست پروانه ای", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 289, type = 13, name = "چرخش روسی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 290, type = 13, name = "کرانچ مورب بر روی میز با شیب منفی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 291, type = 13, name = "درازنشست جک نایف", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 292, type = 13, name = "بالا آوردن پاها در حالت آویزان", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 293, type = 13, name = "بالا آوردن پاها در حالت خوابیده", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 294, type = 13, name = "کرانچ سیم کش با طناب", cardio = false, IsExercise = true });




            db.InsertExercise(new Exercise() { Id = 300, type = 14, name = "همسترینگ", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 301, type = 14, name = "ددلیفت دمبل پا صاف", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 302, type = 14, name = "هل دادن سورتمه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 303, type = 14, name = "بالا آوردن همسترینگ و باسن", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 304, type = 14, name = "پرش درجا با آوردن پاها داخل شکم", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 305, type = 14, name = "سوئینگ کتل بل تک دست", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 306, type = 14, name = "ددلیفت رومانیایی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 307, type = 14, name = "ددلیفت هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 308, type = 14, name = "ددلیفت پا صاف", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 309, type = 14, name = "ددلیفت تک پا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 310, type = 14, name = "صبح بخیر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 311, type = 14, name = "پشت پا با توپ تمرین", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 312, type = 14, name = "ددلیفت سومو", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 313, type = 14, name = "پشت پا ایستاده با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 314, type = 14, name = "ددلیفت رومانیایی با دمبل", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 315, type = 14, name = "پشت پا نشسته با دستگاه", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 316, type = 14, name = "پشت پا خوابیده با دستگاه", cardio = false, IsExercise = true });
            

            db.InsertExercise(new Exercise() { Id = 320, type = 15, name = "دورکننده", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 321, type = 15, name = "اَبداکتور ران", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 322, type = 15, name = "راه رفتن از جانب با کش ورزشی", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 323, type = 15, name = "اَبداکشن ایستاده با کش ورزشی", cardio = false, IsExercise = true });


            db.InsertExercise(new Exercise() { Id = 330, type = 16, name = "باسن(سرینی)", cardio = false, IsExercise = false });
            db.InsertExercise(new Exercise() { Id = 331, type = 16, name = "پل باسن با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 332, type = 16, name = "پل باسن تک پا", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 333, type = 16, name = "هیپ تراست با هالتر", cardio = false, IsExercise = true });
            db.InsertExercise(new Exercise() { Id = 334, type = 16, name = "کیک بک با سیم کش", cardio = false, IsExercise = true });
            
            db.InsertExercise(new Exercise() { Id = 340, type = 17, name = "نزدیک کننده", cardio = false, IsExercise = false });
       


            Toast.MakeText(this, "ADD Shod ", ToastLength.Long).Show();
        }
    }
}