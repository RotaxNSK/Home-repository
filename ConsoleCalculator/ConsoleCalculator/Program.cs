using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterfaceInfo.WriteInfo();
            UserInput.Input();
            Console.Clear();
            UserInterfaceInfo.WriteInfo();
            UserInput.CountResult();
            Console.ReadKey();
        }
    }
}
