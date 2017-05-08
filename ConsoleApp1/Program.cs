using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthName mn = MonthName.March;
            Console.WriteLine("{0}", (byte)mn);
            return;
        }
    }
    public enum MonthName : byte
    {
        January, Feburary, March
    }
}
