using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете точките си: ");
            int points = int.Parse(Console.ReadLine());
            if (points < 0)
            {
                Console.Write("Грешка!");
            }
            else if (points >= 0 && points < 50)
            {
                Console.WriteLine("Получаваш бронзова награда");
                Console.WriteLine("Остават " + (50 - points) + " точки до сребърна награда");
            }
            else if (points >= 50 && points <= 100)
            {
                Console.WriteLine("Получаваш сребърна награда");
                Console.WriteLine("Остават " + (100 - points) + " точки до златна награда");
            }
            else if (points >= 100 && points < 150)
            {
                Console.WriteLine("Получаваш златна награда");
                Console.WriteLine("Остават " + (150 - points) + " точки до шампионска награда");
            }
            else 
            {
                Console.WriteLine("Получаваш шампионска награда ");
                Console.WriteLine("Достигнахте най-високото ниво");
            }

         














        }
    
    
    
    
    
    
    
    
    
    
    
    }
}
