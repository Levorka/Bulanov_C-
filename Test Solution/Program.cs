using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool isEnd = true;
            int exerciseNumber=0;
            while (isEnd)
            {
                Console.WriteLine("Введите номер задания 1,2 или 3");
                try
                {
                    exerciseNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                if (exerciseNumber == 1)
                {
                    Console.WriteLine("Составить алгоритм: если введенное число больше 7, то вывести “Привет”");
                    Console.WriteLine("Введите целое число:");
                    int firstData = Convert.ToInt32(Console.ReadLine());
                    ExerciseOne(firstData);
                }
                else if (exerciseNumber == 2)
                {
                    Console.WriteLine("Составить алгоритм: если введенное имя совпадает с Вячеслав,");
                    Console.WriteLine("то вывести “Привет, Вячеслав”, если нет, то вывести 'Нет такого имени'");
                    Console.WriteLine("Введите имя:");
                    string secondData = Console.ReadLine();
                    ExerciseTwo(secondData);
                }
                else if (exerciseNumber == 3)
                {
                    Console.WriteLine("Введите количество элементов вашего массива");
                    int arraylength = Convert.ToInt32(Console.ReadLine());
                    int[] firdData = new int[arraylength];
                    for (var i = 0;i< arraylength; i++)
                    {
                        Console.WriteLine("Введите элемент массива под номером" + i);
                        firdData[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Clear();
                    ExerciseThree(firdData);
                }
                else
                    Console.WriteLine("Вы ввели неверные данные");

                Console.WriteLine("\nПовторим ? \n\nВведите 'Да' или 'Нет'");
                string answer = Console.ReadLine();
                if (answer == "Нет")
                    isEnd = false;

            }
            
        }

        static void ExerciseOne(int num)
        {
            if (num > 7)
                Console.WriteLine("\nПривет");
        }
        static void ExerciseTwo(string userData)
        {
            if (userData=="Вячеслав")
                Console.WriteLine("\nПривет, Вячеслав");
            else
                Console.WriteLine("\nНет такого имени");
        }
        static void ExerciseThree(int[] userArray)
        {
            foreach (var item in userArray)
            {
                if (item % 3 == 0)
                    Console.WriteLine(item);
            }
        }
    }
}
