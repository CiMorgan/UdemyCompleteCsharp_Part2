using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCompleteCsharp17
{
    public static class Car
    {
        static int speed;
        static string color;
        static float price;

        public static void Start()
        {
            Console.WriteLine("Car started");
        }

        public static void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public static void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }
}
