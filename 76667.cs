using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Въведи скорост:");
            int speed = int.Parse(Console.ReadLine());
            if (speed > 0 && speed <= 10)
            {
                Console.WriteLine("бавно");
            }
            else if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("средна");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("бърза");
            }
            else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("много бърза");
            }
            else if (speed > 1000)
            {
                Console.WriteLine("екстремно бърза");
            }
            else 
            {
                Console.WriteLine("грешка!");
            }
        }




        }
    }

