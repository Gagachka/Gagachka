using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("привет,как твои дела? ",name, "!");
            name = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
