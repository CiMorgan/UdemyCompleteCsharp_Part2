using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCompleteCsharp17
{
    public class Ex1
    {
        public virtual void Print()
        {
            Console.WriteLine("Hello World");
        }
    }

    public class Ex2 : Ex1
    {
        public override void Print()
        {
            Console.WriteLine("Hi There World");
        }
    }

}
