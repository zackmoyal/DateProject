namespace DateExercise
{
    public class DateClient
    {
        public static void Main(string[] args)
        {
            Date d1, d2, d3;

            d1 = new Date();
            d2 = new Date();
            d3 = new Date(11, 3, 2021);

            if (d1.Equals(d2))
            {
                Console.WriteLine("Equals test 1 - PASSED");
            }

            d1.Month = 11;
            d1.Day = 3;
            d1.Year = 2021;
            if (!d2.Equals(d3))
            {
                Console.WriteLine("Equals test 2 - PASSED");
            }

            d2.Month = 2;
            d2.Day = 30; // invalid day?
            d2.Year = 2021;

            if (d3.ToString().Equals("11-3-2021"))
            {
                Console.WriteLine("ToString test 1 - PASSED");
            }
        }
    }
}