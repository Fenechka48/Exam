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
}
    }
}
