using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Смоделируйте работу простого калькулятора
            //Программа должна запрашивать 2 числа, а затем – код операции(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
            //После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число. X=");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("   1 - сложение");
                Console.WriteLine("   2 - вычитание");
                Console.WriteLine("   3 - умножение");
                Console.WriteLine("   4 - деление");
                Console.Write("Ваш выбор: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ответ: ");
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine(a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(a-b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(a*b);
                            break;
                        }
                    case 4:
                        {
                            if (b != 0)
                            {
                                double x = Convert.ToDouble(a);
                                double y = Convert.ToDouble(b);
                                Console.WriteLine(x / y);
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Деление на ноль");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка! Нет операции с указанным номером");
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }
            Console.ReadKey();
        }
    }
}
