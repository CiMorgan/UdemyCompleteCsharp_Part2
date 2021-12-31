using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCompleteCsharp17
{
    public class Poly1
    {
        public virtual void Example()
        {
            Console.WriteLine("Poly1's Example Method");
        }
    }

    public class Poly2 : Poly1
    {
        public override void Example()
        {
            Console.WriteLine("Poly2's Example Method");
        }
    }
}
