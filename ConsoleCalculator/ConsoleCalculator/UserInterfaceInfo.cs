using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class UserInterfaceInfo
    {
        static public void WriteInfo()
        {
            Console.WriteLine("\t Консольный калькулятор \n");
            Console.WriteLine(" доступные операции: +, -, *, / ");
            Console.WriteLine(" используйте кнопки на цифровой клавиатуре\n");
            Console.WriteLine(" Введите первую цифру, желаемую операцию вторую цифру и нажмите Enter\n");
        }
    }
}
