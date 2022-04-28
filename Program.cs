using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionExmp
{
    internal class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Action<int> printaction = new Action<int>(ConsolePrint);
            printaction(10);
        }
    }
}
