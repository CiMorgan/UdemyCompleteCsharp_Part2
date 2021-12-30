using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCompleteCsharp17
{
    public class Class1
    {
        public void Print()
        {
            Console.WriteLine("Hello World");
        }
    }
    public class Class2 : Class1
    {
        Class2 obj = new Class2();
        obj.Print();

}
}
