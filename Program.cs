using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            float var1 = InputFloat("Число 1");
            float var2 = InputFloat("Число 2");
            float var3 = InputFloat("Число 3");
            Console.WriteLine("Ваше уравнение:" + var1 + "*(x^2) + " + var2 + "*x + " + var3);
            var var4 = var2 * var2 - 4 * var1 * var3;
            Console.WriteLine("Дискриминант равен: " + var4);
            if (var4 < 0)
            {
                Console.WriteLine("Нет корней, так как дискриминант меньше '0'.");
            }
            if (var4 == 0)
            {
                Console.WriteLine("Дискриминант равен нулю, значит будет один корень и он равен:");
            }
            var x1 = (-var2 - Math.Sqrt(var4)) / (2 * var1);
            var x2 = (-var2 + Math.Sqrt(var4)) / (2 * var1);
            Console.WriteLine("Ответ: х1 = " + x1 + "; x2 = " + x2 + ".");
            Console.ReadLine();
        }
        static float InputFloat(String name)
        {
            float result = 0;
            bool var1_error = true;
            while (var1_error == true)
            {
                Console.Write("Введите " + name + " и нажмите Enter: ");
                String var1 = Console.ReadLine();
                if (float.TryParse(var1, out result) == true)
                {
                    Console.WriteLine("Введено число");

                    var1_error = false;
                }
                else
                {
                    Console.WriteLine("Введено не число!");
                }
            }
            return result;
        }
    }
}