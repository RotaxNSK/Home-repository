using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{

    class UserInput
    {
        // актуальная операция
        static private char operation;

        // валидаторы оператора
        static private bool operationsValidation = false;

        // переменная в которой будет храница строка ввода пользователя
        public static string Sample { get; set; }

        // списки для записи и хранения первого и второго операнда
        static private string firstOperand;
        static private string secondOperand;

        //метод отвечающий за ввод пользовательских данных
        public static void Input()
        {
            Console.Write(" ");
            Sample = Console.ReadLine();
            UserInput.Check();
        }

        #region Метод для проверки, обработки пользовательского ввода 
        //метод отвечающий за обработку пользовательских данных
        public static void Check()
        {
            for (int i = 0; i < Sample.Length; i++)
            {
                if (!operationsValidation)
                {
                    switch (Sample[i])
                    {
                        case '1': firstOperand += Convert.ToString(Sample[i]); break;
                        case '2': firstOperand += Convert.ToString(Sample[i]); break;
                        case '3': firstOperand += Convert.ToString(Sample[i]); break;
                        case '4': firstOperand += Convert.ToString(Sample[i]); break;
                        case '5': firstOperand += Convert.ToString(Sample[i]); break;
                        case '6': firstOperand += Convert.ToString(Sample[i]); break;
                        case '7': firstOperand += Convert.ToString(Sample[i]); break;
                        case '8': firstOperand += Convert.ToString(Sample[i]); break;
                        case '9': firstOperand += Convert.ToString(Sample[i]); break;
                        case '0': firstOperand += Convert.ToString(Sample[i]); break;
                        case '+':
                            {
                                operation = '+';
                                operationsValidation = true;
                                break;
                            }
                        case '-':
                            {
                                operation = '-';
                                operationsValidation = true;
                                break;
                            }
                        case '*':
                            {
                                operation = '*';
                                operationsValidation = true;
                                break;
                            }
                        case '/':
                            {
                                operation = '/';
                                operationsValidation = true;
                                break;
                            }
                        default: Console.WriteLine(" Вы ввели неверный символ! "); break;
                    }
                }
                else if (operationsValidation)
                {
                    switch ((char)Sample[i])
                    {

                        case '1': secondOperand += Convert.ToString(Sample[i]); break;
                        case '2': secondOperand += Convert.ToString(Sample[i]); break;
                        case '3': secondOperand += Convert.ToString(Sample[i]); break;
                        case '4': secondOperand += Convert.ToString(Sample[i]); break;
                        case '5': secondOperand += Convert.ToString(Sample[i]); break;
                        case '6': secondOperand += Convert.ToString(Sample[i]); break;
                        case '7': secondOperand += Convert.ToString(Sample[i]); break;
                        case '8': secondOperand += Convert.ToString(Sample[i]); break;
                        case '9': secondOperand += Convert.ToString(Sample[i]); break;
                        case '0': secondOperand += Convert.ToString(Sample[i]); break;
                    }
                }
            }
        }
        #endregion

        #region Метод для подсчёта и вывод результата
        public static void CountResult()
        {
            switch (operation)
            {
                case '+': Console.WriteLine(" {0}{1}{2} = {3:f2}", firstOperand, operation, secondOperand, ((double)(Convert.ToDouble(firstOperand) + Convert.ToDouble(secondOperand)))); break;
                case '-': Console.WriteLine(" {0}{1}{2} = {3:f2}", firstOperand, operation, secondOperand, ((double)(Convert.ToDouble(firstOperand) - Convert.ToDouble(secondOperand)))); break;
                case '*': Console.WriteLine(" {0}{1}{2} = {3:f2}", firstOperand, operation, secondOperand, ((double)(Convert.ToDouble(firstOperand) * Convert.ToDouble(secondOperand)))); break;
                case '/': Console.WriteLine(" {0}{1}{2} = {3:f2}", firstOperand, operation, secondOperand, ((double)(Convert.ToDouble(firstOperand) / Convert.ToDouble(secondOperand)))); break;
            }
        }
        #endregion
    }
}
