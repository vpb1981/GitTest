using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("hello");
            PrintWorld();
            PrintUniverse();
        }

        private static void PrintUniverse()
        {
            Console.WriteLine("Universe");
            
        }

        private static void PrintWorld()
        {
            Console.WriteLine("World");
        }
    }
}
