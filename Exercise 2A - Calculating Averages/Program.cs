using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A___Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition();
            
        }
        
        static void Addition()
        {            
            int countDown = 10;
            int countUp = 1;
            double total = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You may enter any number between 0 - 100");
                Console.Write($"\nPlease enter #{countUp}: ");
                double input = double.Parse(Console.ReadLine());
                // catches any entries made outside the expected parameters. 
                //This does not catch errors where the user enters text or hit a wrong key
                if (input > 100 || input <0)
                {
                    while (input > 100 || input < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That number is out of range.");
                        Console.WriteLine("You may enter any number between 0 - 100");
                        Console.Write($"\nPlease re-enter #{countUp}: ");
                        input = double.Parse(Console.ReadLine());
                    }                                            
                }
                
                countDown--;
                countUp++;
                total = input + total;
                

            } while (countDown > 0);
            Console.Clear();
            Console.WriteLine("SUCCESS!!!");
            Console.WriteLine($"\nYour total is {total}! Your contribution really added" +
                $" up!");
            Console.ReadLine();
        }
        
        
    }
}
