using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange ett decimal: ");
            string inputFromUser = Console.ReadLine();
            try
            {
                
                string[] tiondel = inputFromUser.Split('.');
                float FloatInput = int.Parse(tiondel[1]);
                if(tiondel[0] != "0")
                {
                    Console.WriteLine("ser ut som du använder heltal, det skulle normalt crasha programmet, \n" + 
                        "fast jag är en kol person så jag tar bara bort dom för dig automatiskt");

                }

                if(tiondel[1] == null)
                {
                    Console.WriteLine("Fel format");
                }
                else
                {
                    Console.WriteLine("0." + FloatInput);
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong format");
                Console.ReadKey();
            }
        }
    }
}
