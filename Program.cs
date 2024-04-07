using System;

namespace SleepTimeTracker
{
    public class SleepTime
    {
        public int Hours { get; set; }

        // Unary operator overloading for missed sleep
        public static SleepTime operator -(SleepTime sleep)
        {
            return new SleepTime { Hours = -sleep.Hours };
        }
        public static SleepTime operator ++(SleepTime sleep)
        {
            return new SleepTime { Hours = sleep.Hours + 1 };
        }

        public static SleepTime operator --(SleepTime sleep)
        {
            return new SleepTime { Hours = sleep.Hours - 1 };
        }

        // Comparison operator overloading
        public static bool operator ==(SleepTime sleep1, SleepTime sleep2)
        {
            return sleep1.Hours == sleep2.Hours;
        }

        public static bool operator !=(SleepTime sleep1, SleepTime sleep2)
        {
            return sleep1.Hours != sleep2.Hours;
        }

        public static bool operator >(SleepTime sleep1, SleepTime sleep2)
        {
            return sleep1.Hours > sleep2.Hours;
        }

        public static bool operator <(SleepTime sleep1, SleepTime sleep2)
        {
            return sleep1.Hours < sleep2.Hours;
        }

        // Binary operator overloading
        public static SleepTime operator +(SleepTime sleep1, SleepTime sleep2)
        {
            return new SleepTime { Hours = sleep1.Hours + sleep2.Hours };
        }
        public static SleepTime operator -(SleepTime sleep1, SleepTime sleep2)
        {
            return new SleepTime { Hours = sleep1.Hours - sleep2.Hours };
        }

        public override string ToString()
        {
            return $"{Hours} hours";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating sleep time objects
            SleepTime mondaySleep = new SleepTime { Hours = 6 };
            SleepTime tuesdaySleep = new SleepTime { Hours = 8 };
            SleepTime wednesdaySleep = new SleepTime { Hours = 9 };
            SleepTime missedsleep = new SleepTime { Hours = 3 };

            Console.WriteLine($"Mondays sleep time:{mondaySleep}");
            Console.WriteLine($"Tuesday sleep time:{tuesdaySleep}");
            Console.WriteLine($"wednesday sleep time:{wednesdaySleep}");
            Console.WriteLine("");

            // Unary operator usage
            Console.WriteLine($"missed sleep due to staying up late: {-missedsleep}");

            // Comparison operator usage
            Console.WriteLine($"Is Monday sleep time equal to Tuesday sleep time? {mondaySleep == tuesdaySleep}");
            Console.WriteLine("");
            Console.WriteLine($"Is Tuesday sleep time not equal to Wednesday sleep time? {tuesdaySleep != wednesdaySleep}");
            Console.WriteLine("");
            Console.WriteLine($"Is Wednesday sleep time greater than Monday sleep time? {wednesdaySleep > mondaySleep}");
            Console.WriteLine("");
            Console.WriteLine($"Is Tuesday sleep time less than Wednesday sleep time? {tuesdaySleep < wednesdaySleep}");
            Console.WriteLine("");
            Console.WriteLine($"Increment Monday sleep time: {++mondaySleep}");
            Console.WriteLine("");
            Console.WriteLine($"Decrement Tuesday sleep time: {--tuesdaySleep}");
            // Binary operator usage
            Console.WriteLine($"Total sleep time for Monday, Tuesday and wednsday: {mondaySleep + tuesdaySleep + wednesdaySleep - missedsleep}");
        }
    }
}
