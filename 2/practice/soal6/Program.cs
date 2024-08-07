enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class Program
{
    static void Main()
    {
        Days today = Days.Wednesday;

        switch (today)
        {
            case Days.Monday:
                Console.WriteLine("Today is Monday");
                break;
            case Days.Wednesday:
                Console.WriteLine("Today is Wednesday");
                break;
            case Days.Friday:
                Console.WriteLine("Today is Friday");
                break;
            default:
                Console.WriteLine("Other day");
                break;
        }
    }
}
