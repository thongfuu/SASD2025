using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Refactoring101
{
    // Do Refactoring the following code:
    public class QuestionsAndAnswers
    {
        public void Run()
        {
            //1.
            double max = Max(57, 96);
            Console.WriteLine("Max = " + max);

            //2.
            Print();

            //3.
            Shotgun1 shotgun1 = new Shotgun1();
            shotgun1.DisplayStudents();
            Shotgun2 shotgun2 = new Shotgun2();
            shotgun2.PrintTotal();

            //4. + 5.
            Date date = new Date(23, 01, 2026);
            PrintDate(date);
        }
        // 1. Mysterious Name
        public double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        // 2. Duplicate Code
        public void Print()
        {
            PrintPersonBanner("Mr.Harry Potter");
            PrintPersonBanner("Ms.Mary Poppin");
            PrintPersonBanner("Mr.Johny Black");
        }
        private void PrintPersonBanner(string name)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"   {name}");
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        // 3. Shotgun Surgery
        public static class StudentConfig
        {
            public const int TotalCount = 48;
        }
        public class Shotgun1
        {
            public void DisplayStudents()
            {
                Console.WriteLine("Student Count = " + StudentConfig.TotalCount);
            }
        }
        public class Shotgun2
        {
            public void PrintTotal()
            {
                Console.WriteLine("Total Students : " + StudentConfig.TotalCount);
            }
        }

        // 4. Data Clump
        public void PrintDate(Date date)
        {
            Console.WriteLine(date.Format());
        }
        public class Date
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public Date(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
        // 5. Feature Envy
        //     จากข้อที่แล้ว น่าจะได้สร้างคลาส Date ขึ้นมา
        //     ในคลาส Date นั้นให้สร้าง method: public string Format()
        //     ปรับให้ PrintDate(...) ของเดิม ไปเรียก date.Format() ดังกล่าว
            public string Format()
            {
                return $"{Day:00}/{Month:00}/{Year:0000}";
            }
        }
    }
}
