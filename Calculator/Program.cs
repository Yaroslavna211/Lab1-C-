/*
  Автор     : Иванова Я.
  Группа    : ПИЗ-211
  Дата      : 02.06.2022
  Название  : Базовые понятия языка С#
*/
// 
using System;

namespace HelloWorld
{

    class Program
    {

        static void Main()
        {
            Console.Write("Число = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Степень = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int b = 1;

            for (int i = 1; i <= n; i++)
            {
                b *= a;
            }
            Console.WriteLine(a + " в степени " + n + " = " + b);

            // Ожидание нажатия клавиши
            Console.ReadKey();
        }
    }
}