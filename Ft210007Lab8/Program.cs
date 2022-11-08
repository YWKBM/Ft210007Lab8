using System;
using System.IO;

namespace Ft210007Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Logger.txt");
            

            try //обработка ошибок ввода
            {
                int n;
                Console.WriteLine("Enter the range of lottery: ");
                n = int.Parse(Console.ReadLine());
                sw.WriteLine("Пользователь задал диапазон чисел: " + n);
                Generator g = new Generator(n);

                int k = n;

                while (k > 0)
                {
                    Console.WriteLine("Enter any key to generate lot\n");
                    Console.ReadKey();
                    Console.WriteLine();
                    int get = g.Generate();
                    Console.WriteLine(get);
                    sw.WriteLine("Пользователь получил: " + get);
                    k--;
                }
                sw.WriteLine("Список полученных чисел: ");
                for (int i = 0; i < g.response.Count; i++)
                {
                    sw.WriteLine(g.response[i]);
                }
            }
            catch (System.FormatException e) 
            {
                Console.WriteLine("Incorect range format, enter digit");
                sw.WriteLine("Пользователь допустил ошибку в задании диапазона");
            }
            sw.Close();
            

        }
    }
}
