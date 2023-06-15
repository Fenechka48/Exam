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
            int[] intArray ={1,2,3,4,5};

            int sum = 0;
            //Array.ForEach(intArray, x => sum += x);
            //Console.WriteLine(sum);
            int[] intArray1 = new int[6];
            intArray1[1] = 1;
            intArray1[4] = 4;
            intArray1[2] = 2;
            intArray1[5] = 5;
            intArray1[3] = 3;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Element in index " + i + ": " + intArray[i]);
            }
            Console.WriteLine("Summa" + intArray[1] + intArray[4] + intArray[2]);
            Console.ReadLine();

            Console.WriteLine(intArray[1]);
        }
    }
}
