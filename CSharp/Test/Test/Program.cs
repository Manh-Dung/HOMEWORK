using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        class test
        {
            private double diem;
            public double Diem
            {
                get { return diem; }
                set { diem = value; }
            }
        }
        static void Main(string[] args)
        {
            test t = new test();
            t.Diem = 10;
            Console.WriteLine(t.Diem);
            Console.ReadLine();
        }
    }
}
