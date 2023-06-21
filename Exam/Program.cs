using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
        internal class Program
        {
            static void Main(string[] args)
            {
            /*  Созданный массив положительных целых чисел  arr, реорганизовать таким образом, 
             чтобы возвратить сумму всех возможных подмассивов нечетной длины arr .
             Ввод: arr = [1, 4, 2, 5, 3]
             Вывод: 58
             Объяснение: Подмассивы нечетной длины массива arr и их суммы:
             [1] = 1
             [4] = 4
             [2] = 2
             [5] = 5
             [3] = 3
             [1, 4, 2] = 7
             [4, 2, 5] = 11
             [2, 5, 3] = 10
             [1, 4, 2, 5, 3] = 15
             Если мы сложим все это вместе, то получим 1 + 4 + 2 + 5 + 3 + 7 + 11 + 10 + 15 = 58.

             Ввод: arr = [1, 2]
             Вывод: 3
             Объяснение: Есть только 2 подмассива нечетной длины, [1] и [2]. Их сумма равна 3.
             */
            //Ввод исходных данных
            Console.WriteLine("Введите размер исходного массива:");
                int size;
                if (Int32.TryParse(Console.ReadLine(), out int value))
                {
                    size = value;
                }
                else
                {
                    throw new ApplicationException("Ошибка! Вы ввели не число!");
                }
                int[] arr = new int[size];
                Console.WriteLine("Введите массив положительных целых чисел:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Введите значение: ");
                    arr[i] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine("Ввод исходных данных завершен.");

                //Вычисление сумм всех массивов нечетных длин
                int result = 0;
                for (int l = 1; l <= arr.Length; l += 2)
                {
                    for (int k = 0; k <= arr.Length - l; k++)
                    {
                        Console.WriteLine("Массивы длиной " + l + "=>");
                        for (int j = k; j < k + l; j++)
                        {
                            Console.Write(arr[j] + " ");
                            result += arr[j];
                        }
                        Console.WriteLine();
                    }
                }

                //Вывод результата
                Console.WriteLine("Вывод исходного массива:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                    Console.Write('\t');
                }
                Console.WriteLine("Сумма всех подмассивов нечетной длины равна " + result + '.');
            }
        }
}

