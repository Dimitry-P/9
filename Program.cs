using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        //•	Задача 9: Напишите программу, которая меняет местами
        //два числа, введенные пользователем.
        public static string num;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа через запятую:");
            num = Console.ReadLine();
            

            string[] pieces = num.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = pieces.Length-1; i >= 0; i--)
            {
               
                Console.Write(pieces[i]);
               if(i == pieces.Length - 1)
                {
                    Console.Write(",");
                }
                
            }
        }
    }
}
