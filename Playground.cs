using System;
using System.Text;

namespace C__7._0_in_a_Nutshell
{
    class Program
    {
        static int Foo<T> (T x) => (int) (object) x;
        static void Main(string[] args)
        {
            System.Console.WriteLine(Foo(10));
        }
    }
}
