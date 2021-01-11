using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorPlusDemo
{
    class MyClass
    {
        public int number;
        public MyClass(int n)
        {
            number=n;
        }
        public static int operator+(MyClass a, MyClass b)
        {
            int m = a.number + b.number;
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            int num;
            num = A + B;
            Console.WriteLine("A+B= "+num);
        }
    }
}
