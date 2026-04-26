using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligates
{
    internal class Program
    {
        public delegate void mydel();
        public static void fun1()
        {
            Console.WriteLine("f1() called");
        }

        public static void fun2()
        {
            Console.WriteLine("Function called");
        }

        static void Main(string[] args)
        {
            Program p = new Program();            
            mydel del = new mydel(fun1);
            del += fun2;
            del();
           
        }
    }


}
