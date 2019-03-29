using System;
using System.Text;

namespace C__7._0_in_a_Nutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            (string,int) bob = ("Bob", 23);

            var joe = bob;

            string b = bob.Item1;

            b[1] = 'i';
            joe.Item1[1] = 'i';

            Console.WriteLine(bob.Item1);
            Console.WriteLine(bob.Item2);
        }
    }
}