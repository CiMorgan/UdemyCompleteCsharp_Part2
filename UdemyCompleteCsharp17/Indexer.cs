using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCompleteCsharp17
{
    public class ExampleClassWithIndexer
    {
        private string[] dataArray = new string[100];
        public object this[int index]
        {
            get { 
                if(index < 0 || index >= dataArray.Length)
                {
                    Console.WriteLine("Invalid Index");
                    return new object();
                } else
                {
                    return dataArray[index];
                }
                    
            }
            set {
                if(index < 0 || index >= dataArray.Length)
                {
                    Console.WriteLine("Invalid Index");
                } else
                {
                    dataArray[index] = value.ToString();
                }
                   
            }
        }
    }
}
