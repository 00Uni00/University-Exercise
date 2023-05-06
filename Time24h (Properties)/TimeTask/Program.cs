namespace TimeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //One of the testcase.
            var t = new Time24h(2, 15, 37);
            t.Minute = 20;
            t.Hour = 1;
            t.Second = 26;
            Console.WriteLine(t);
        }
        public class Time24h
        {
            private int numberOfSeconds;

            public int Second
            {
                get => numberOfSeconds - Hour * 60 * 60 - Minute * 60;
                set => numberOfSeconds = (value <= 59 && value >= 0) ? numberOfSeconds = value + 60 * Minute + 3600 * Hour : throw new ArgumentException("The seconds were entered incorrectly.");

            }

            public int Minute
            {
                get => (numberOfSeconds / 60) % 60;
                set => numberOfSeconds = (value <= 59 && value >= 0) ? numberOfSeconds = Second + 60 * value + 3600 * Hour : throw new ArgumentException("The minutes were entered incorrectly");
            }

            public int Hour
            {
                get => numberOfSeconds / 3600;
                set => numberOfSeconds = (value <= 23 && value >= 0) ? numberOfSeconds = Second + 60 * Minute + 3600 * value : throw new ArgumentException("The hours were entered incorrectly");
            }

            public Time24h(int hour, int minute, int second)
            {
                if ((hour > 23 || hour < 0) || (minute > 59 || minute < 0) || (second > 59 || second < 0))
                    throw new ArgumentException("When did u create a instance of object, you have made mistake in properties values.");
                numberOfSeconds = second + 60 * minute + 3600 * hour;
            }


            public override string ToString() => $"{Hour}:{Minute:D2}:{Second:D2}";
        }
    }

}