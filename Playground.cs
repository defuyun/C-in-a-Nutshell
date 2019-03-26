using System;
using System.Text;

namespace C__7._0_in_a_Nutshell
{
    class Program
    {
        static void Foo(ref StringBuilder fooSB) {
            fooSB.Append("texture");
            fooSB = null;
        }
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            Foo(ref sb);
            System.Console.WriteLine(sb);
        }
    }
}
