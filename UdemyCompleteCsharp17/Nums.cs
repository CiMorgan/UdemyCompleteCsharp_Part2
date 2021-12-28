using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCompleteCsharp17
{
    class Nums
    {
        private static int number1 = 3;
        private static int number2 = 5;

        public static int MultiplyWithExtra(int num1, int num2)
        {
            return num1 * num2 + number1 + number2;
        }
    }
}
