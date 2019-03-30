using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Dynamic;

namespace C__7._0_in_a_Nutshell
{
    class Program
    {
        static dynamic Mean(dynamic x, dynamic y) => (x + y)/2;

        static void Foo([CallerLineNumber] int num = 0) => Console.WriteLine(num);

        static void Main(string[] args)
        {
            Foo();
            Foo();
        }
    }
}