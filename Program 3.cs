using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age and gender:");
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (gender == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (gender == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (gender == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else if (gender == "f" && age < 16)
            {
                Console.WriteLine("Miss");
            }
            else 
            {
                Console.WriteLine("Error!");
            }







        }
    }
}
