using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWoof{
class Program
    {
        static void Main(string[] args)
        {


            {
                Console.WriteLine( "Press enter to begin");
               
                string stringStop = Console.ReadLine();
                do
                {Console.WriteLine("Pick a number and type stop to stop ");
                    string userInput = Console.ReadLine();
                    int userInput2 = Convert.ToInt32(userInput);
                    if (userInput2 % 3 == 0 && userInput2 % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        continue;
                    }
                    if (userInput2 % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        continue;
                    }
                    if (userInput2 % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        continue;
                    }
                    if (userInput2 % 7 == 0)
                    {
                        Console.WriteLine("Woof");
                        continue;
                    }
                    if (userInput2 % 7 == 0 && userInput2 % 5 == 0)
                    {
                        Console.WriteLine("WoofBuzz");
                        continue;
                    }
                   
                } while (stringStop != "stop");
                
            }
            
        
        }
       
    }
}
