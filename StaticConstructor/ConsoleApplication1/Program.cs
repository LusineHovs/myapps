using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Own
    {
        public static  DateTime start;
        public static int a;
        static Own()
        {
            start = DateTime.Now;
            Console.WriteLine(start);
        }
        public Own(int a1)
        {
            a = a1;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Own own = new Own(10);
           
        }
    }
}
