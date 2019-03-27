using System;
using System.Text;

namespace C__7._0_in_a_Nutshell
{

    class Rectangle {
        int number;

        public int Number {
            get {
                System.Console.WriteLine("Enter getter");
                return number;
            }

            set {
                System.Console.WriteLine("Enter setter");
                number = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Number = 10;
            rect.Number -= 3;
        }
    }
}
