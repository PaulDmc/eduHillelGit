using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Hillel_HW41_Demchenko
{

    public class Program
    {

        static void Main()
        {
            int weekDay;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the day of the week");
                weekDay = Convert.ToInt32(Console.ReadLine());
                switch (weekDay)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day of week");
                        break;

                }

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
            

    