namespace Problem_2;

class Program
{
    static void Main()
    {
        do
        {
            int Year = 0;
            Console.WriteLine("Type in a year and see if it's a leap year!!");
            Year = Int32.Parse(Console.ReadLine());
            if (Year % 4 == 0)
            {
                if (Year % 100 == 0 && Year % 400 == 0)
                {

                    Console.WriteLine("Hump Yearr!!!!");
                }

            }
            else { Console.WriteLine("You've reached the mailbox of Uncle Rukus"); }

        } while (true); {
           

        }
        
    }
}
